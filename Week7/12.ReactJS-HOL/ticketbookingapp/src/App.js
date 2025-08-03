// src/App.js
import React, { useState } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate, Link } from "react-router-dom";
import GuestPage from "./components/GuestPage";
import UserPage from "./components/UserPage";
import Login from "./components/Login";
import './App.css';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  return (
    <Router>
      <div className="App">
        <header>
          <h2>Ticket Booking App</h2>
          <nav>
            <Link to="/">Home</Link> |{" "}
            {isLoggedIn ? (
              <>
                <Link to="/user">User Page</Link> |{" "}
                <button onClick={handleLogout}>Logout</button>
              </>
            ) : (
              <Link to="/login">Login</Link>
            )}
          </nav>
        </header>

        <Routes>
          <Route path="/" element={<GuestPage />} />
          <Route path="/login" element={<Login onLogin={handleLogin} />} />
          <Route
            path="/user"
            element={
              isLoggedIn ? <UserPage /> : <Navigate to="/" replace />
            }
          />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
