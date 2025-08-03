import React from 'react';

const BookDetails = () => {
  const books = [
    { title: "Master React", price: 890 },
    { title: "Deep Dive into Angular 11", price: 1300 },
    { title: "Mongo Essentials", price: 980 }
  ];

  return (
    <div className="column">
      <h2>Book Details</h2>
      {books.map((book, idx) => (
        <div key={idx}>
          <h3>{book.title}</h3>
          <p>{book.price}</p>
        </div>
      ))}
    </div>
  );
};

export default BookDetails;
