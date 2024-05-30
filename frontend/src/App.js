import { useEffect, useRef, useState } from 'react';
import './App.css';

function App() {
  const [tooted, setTooted] = useState([]);

  useEffect(() => {
    fetch("https://localhost:4444/tooted")
      .then(res => res.json())
      .then(json => setTooted(json));
  }, []);

  return (
    <div className="App">
      {tooted.map(toode => 
        <div>
          <div>{toode.id}</div>
          <div>{toode.name}</div>
          <div>{toode.price.toFixed(2)}</div>
        </div>)}
    </div>
  );
}

export default App;