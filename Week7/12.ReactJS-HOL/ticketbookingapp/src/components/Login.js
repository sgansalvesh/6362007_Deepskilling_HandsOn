// src/components/Login.js
import React from "react";
import { useNavigate } from "react-router-dom";

const Login = ({ onLogin }) => {
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    onLogin();
    navigate("/user");
  };

  return (
    <div>
      <h3>Login Page</h3>
      <form onSubmit={handleSubmit}>
        <input type="text" placeholder="Username" required /><br/>
        <input type="password" placeholder="Password" required /><br/>
        <button type="submit">Login</button>
      </form>
    </div>
  );
};

export default Login;
