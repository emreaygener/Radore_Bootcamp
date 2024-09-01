import { useEffect, useState } from "react";

function VeriGetir() {
  const [usersArray, setData] = useState([]);
  //Thunk incele!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
  useEffect(() => {
    const getirecekFonksiyon = async () => {
      const gelenData = await fetch("https://jsonplaceholder.org/users");
      if (gelenData.ok) {
        const gelenJson = await gelenData.json();
        setData(gelenJson);
      }
    };
    getirecekFonksiyon();
  }, []);
  return (
    <div>
      <h1>Veri Getir</h1>
      <ul>
        {usersArray.map((item) => (
          <li key={item.id}>
            {item.firstname} {item.lastname}, {item.birthDate}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default VeriGetir;
