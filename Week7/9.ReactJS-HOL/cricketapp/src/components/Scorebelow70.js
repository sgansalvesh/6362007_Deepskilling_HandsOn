import React from "react";

const Scorebelow70 = ({ players }) => {
  const below70 = players.filter(player => player.score < 70);

  return (
    <ul>
      {below70.map((player) => (
        <li key={player.name}>Mr. {player.name} - {player.score}</li>
      ))}
    </ul>
  );
};
//code by sourav
export default Scorebelow70;
