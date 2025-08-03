import React from "react";
import ListofPlayers from "./components/ListofPlayers";
import Scorebelow70 from "./components/Scorebelow70";
import { OddPlayers, EvenPlayers, IndianPlayersMerged } from "./components/IndianPlayers";

function App() {
  const flag = false;

  const players = [
    { name: "Virat", score: 85 },
    { name: "Rohit", score: 45 },
    { name: "Gill", score: 77 },
    { name: "Iyer", score: 34 },
    { name: "Pant", score: 91 },
    { name: "Rahul", score: 68 },
    { name: "Jadeja", score: 75 },
    { name: "Hardik", score: 56 },
    { name: "Ashwin", score: 64 },
    { name: "Bumrah", score: 80 },
    { name: "Shami", score: 39 }
  ];

  const IndianTeam = ["Virat", "Rohit", "Gill", "Iyer", "Pant", "Rahul"];

   if (flag === true) // change it accordingly
    return (
      <div>
      <h1>List of Players</h1>
      <ListofPlayers players={players} />

      <h1>List of Players having Scores Less than 70</h1>
      <Scorebelow70 players={players} />
    </div>
    );
  else
    return (
      <div>
        <h1> Indian Team </h1>

        <h2> Odd Players </h2>
        {OddPlayers(IndianTeam)}

        <h2> Even Players </h2>
        {EvenPlayers(IndianTeam)}

        <h2> List of Indian Players (Merged T20 + Ranji) </h2>
        {IndianPlayersMerged()}
      </div>
    );
}

export default App;
