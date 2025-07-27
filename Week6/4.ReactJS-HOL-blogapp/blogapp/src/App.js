import React from 'react';
import Posts from './posts';

function App() {
  return (
    <div className="App"
      style={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
      }}
    >
      <h1 style={{ textAlign: 'center'}}>Blog App</h1>
      <Posts />
    </div>
  );
}
// By Smruti Gansalvesh
export default App;
