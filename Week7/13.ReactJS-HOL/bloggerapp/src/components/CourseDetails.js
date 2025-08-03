import React from 'react';

const CourseDetails = () => {
  const courses = [
    { name: "Angular", date: "4/5/2025" },
    { name: "React", date: "6/3/2025" }
  ];

  return (
    <div className="column">
      <h2>Course Details</h2>
      {courses.map((course, idx) => (
        <div key={idx}>
          <h3>{course.name}</h3>
          <p>{course.date}</p>
        </div>
      ))}
    </div>
  );
};

export default CourseDetails;
