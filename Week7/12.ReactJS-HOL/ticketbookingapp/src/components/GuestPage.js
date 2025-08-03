// src/components/GuestPage.js
import React from "react";

const GuestPage = () => {
  return (
    <div>
      <h3>Flight Listings (Guest View)</h3>
      <ul>
        <li>✈️ New York → London | ₹25,000</li>
        <li>✈️ Delhi → Dubai | ₹15,000</li>
        <li>✈️ Mumbai → Singapore | ₹20,000</li>
      </ul>
      <p><strong>Note:</strong> Please login to book tickets.</p>
    </div>
  );
};

export default GuestPage;
