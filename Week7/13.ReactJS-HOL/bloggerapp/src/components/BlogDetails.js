import React from 'react';

const BlogDetails = () => {
  const blogs = [
    {
      title: "React Learning",
      author: "Smruti Gansalvesh",
      description: "Welcome to learning React!"
    },
    {
      title: "Installation",
      author: "Shesha",
      description: "You can install React from npm."
    }
  ];

  return (
    <div className="column">
      <h2>Blog Details</h2>
      {blogs.map((blog, idx) => (
        <div key={idx}>
          <h3>{blog.title}</h3>
          <strong>{blog.author}</strong>
          <p>{blog.description}</p>
        </div>
      ))}
    </div>
  );
};

export default BlogDetails;
