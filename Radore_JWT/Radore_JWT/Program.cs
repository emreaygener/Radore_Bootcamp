using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Radore_JWT.Entities;
using Radore_JWT.Helpers;
using Radore_JWT.Services.User;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Projemizde DbContext olarak ApplicationDbContext kullanacağımız belirtliyoruz.
builder.Services.AddDbContext<ApplicationDbContext>();
// appsettings.json içinde oluşturduğumuz gizli anahtarımızı AppSettings ile çağıracağımızı söylüyoruz.
var appSettingsSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingsSection);


// Oluşturduğumuz gizli anahtarımızı byte dizisi olarak alıyoruz.
var appSettings = appSettingsSection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

builder.Services.AddSingleton(appSettings);

//Projede farklı authentication tipleri olabileceği için varsayılan olarak JWT ile kontrol edeceğimizin bilgisini kaydediyoruz.
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})



    //JWT kullanacağım ve ayarları da şunlar olsun dediğimiz yer ise burasıdır.
    .AddJwtBearer(x =>
    {
        //Gelen isteklerin sadece HTTPS yani SSL sertifikası olanları kabul etmesi(varsayılan true)
        x.RequireHttpsMetadata = false;
        //Eğer token onaylanmış ise sunucu tarafında kayıt edilir.
        x.SaveToken = true;
        //Token içinde neleri kontrol edeceğimizin ayarları.
        x.TokenValidationParameters = new TokenValidationParameters
        {
            //Token 3.kısım(imza) kontrolü
            ValidateIssuerSigningKey = true,
            //Neyle kontrol etmesi gerektigi
            IssuerSigningKey = new SymmetricSecurityKey(key),
            //Bu iki ayar ise "aud" ve "iss" claimlerini kontrol edelim mi diye soruyor
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
