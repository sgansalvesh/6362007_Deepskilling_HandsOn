import React, { useState } from 'react';
import CurrencyConvertor from './CurrencyConvertor';

function App() {
  const [counter, setCounter] = useState(0);

  // Method to increment the counter
  const incrementCounter = () => {
    setCounter(prev => prev + 1);
  };

  // Method to say hello
  const sayHelloMessage = () => {
    alert("Hello! Welcome Smruti Gansalvesh.");
  };

  const handleIncrease = () => {
    incrementCounter();      
    sayHelloMessage();       
  };

  // Show welcome popup with different message
  const sayWelcome = () => {
    alert("Welcome welcome!!");
  };

  // Synthetic event popup
  const handleClick = () => {
    alert("I was clicked");
  };

  // Decrement
  const decrementCounter = () => {
    setCounter(prev => prev - 1);
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h2>Event Examples App</h2>

      {/* Counter Section */}
      <div style={{ marginBottom: '20px' }}>
        <h3>Counter: {counter}</h3>
        <button onClick={handleIncrease}>Increase</button>
        <button onClick={decrementCounter}>Decrease</button>
      </div>

      <div style={{ marginBottom: '20px' }}>
        <button onClick={sayWelcome}>Say Welcome</button>
      </div>

      <div style={{ marginBottom: '20px' }}>
        <button onClick={handleClick}>Click Me</button>
      </div>

      <CurrencyConvertor />
    </div>
  );
}

export default App;
