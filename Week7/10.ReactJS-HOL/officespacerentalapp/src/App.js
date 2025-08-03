import React from 'react';
import './App.css';

function App() {
  const heading = "Office Space Rental Listings";
  const imageSrc = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSse_HKrAfd5RezE--0f32dwkx-XOsCiioa2WnS70BKS4GzriGyrdEiCd5Q2Q8tztUlZIs&usqp=CAU";

  const office = {
    Name: "DBS",
    Rent: 50000,
    Address: "Chennai"
  };

  const officeList = [
    { Name: "DBS", Rent: 50000, Address: "Chennai" },
    { Name: "WeWork", Rent: 75000, Address: "Bangalore" },
    { Name: "Innov8", Rent: 45000, Address: "Delhi" }
  ];

  return (
    <div className="container">
      <h1>{heading}</h1>
      <img src={imageSrc} alt="Office Space" width="20%" height="25%" />

      <h2>Office Details:</h2>
      <p>Name: {office.Name}</p>
      <p className={office.Rent <= 60000 ? 'textRed' : 'textGreen'}>
        Rent: Rs. {office.Rent}
      </p>
      <p>Address: {office.Address}</p>

      <h2>All Office Listings:</h2>
      {officeList.map((item, index) => (
        <div key={index}>
          <p>Name: {item.Name}</p>
          <p className={item.Rent <= 60000 ? 'textRed' : 'textGreen'}>
            Rent: Rs. {item.Rent}
          </p>
          <p>Address: {item.Address}</p>
          <hr />
        </div>
      ))}
    </div>
  );
}

export default App;
