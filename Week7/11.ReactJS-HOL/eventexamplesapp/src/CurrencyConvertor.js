import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState('');

  const handleSubmit = () => {
    const euroValue = parseFloat(rupees) / 90;
    setEuros(euroValue.toFixed(2));
  };

  return (
    <div style={{ marginTop: '30px' }}>
      <h3 style={{ color: 'green' }}>Currency Converter (INR to Euro)</h3>
      <input
        type="number"
        value={rupees}
        placeholder="Enter amount in INR"
        onChange={(e) => setRupees(e.target.value)}
      />
      <button onClick={handleSubmit} style={{ marginLeft: '10px' }}>
        Convert
      </button>
      <p>{rupees && `Converted Amount: €${euros}`}</p>
    </div>
  );
}

export default CurrencyConvertor;
