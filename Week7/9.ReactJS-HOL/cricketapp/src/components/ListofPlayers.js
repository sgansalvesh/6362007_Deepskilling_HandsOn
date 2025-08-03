import React from "react";

const ListofPlayers = ({ players }) => {
  return (
    <ul>
      {players.map((player) => (
        <li key={player.name}>Mr. {player.name} - {player.score}</li>
      ))}
    </ul>
  );
};

export default ListofPlayers;
