import { useState } from "react";

function StateHook() {
  const [adet, adetiDegistir] = useState(0);
  const abc = () => adetiDegistir(adet + 1);
  return (
    <div>
      <h1>State Hook</h1>
      <h2>{adet} kere tıkladınız</h2>
      <button onClick={abc}>Tıkla</button>
    </div>
  );
}

export default StateHook;
