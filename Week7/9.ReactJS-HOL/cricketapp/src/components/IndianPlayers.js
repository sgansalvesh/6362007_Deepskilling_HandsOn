import React from "react";

// Odd players destructuring: 1st, 3rd, 5th
export function OddPlayers([first, , third, , fifth]) {
  return (
    <ul>
      <li>First : {first}</li>
      <li>Third : {third}</li>
      <li>Fifth : {fifth}</li>
    </ul>
  );
}

// Even players destructuring: 2nd, 4th, 6th
export function EvenPlayers([, second, , fourth, , sixth]) {
  return (
    <ul>
      <li>Second : {second}</li>
      <li>Fourth : {fourth}</li>
      <li>Sixth : {sixth}</li>
    </ul>
  );
}

// Merged player list display
export function IndianPlayersMerged() {
  const T20Players = ['First Player', 'Second Player', 'Third Player'];
  const RanjiTrophyPlayers = ['Fourth Player', 'Fifth Player', 'Sixth Player'];
  const AllPlayers = [...T20Players, ...RanjiTrophyPlayers];

  return (
    <ul>
      {AllPlayers.map((name) => (
        <li>{name}</li>
      ))}
    </ul>
  );
}
