import React from "react";
import logo from "./logo.svg";
import "./App.css";
import ListActivity from "./components/Activities/ListActivity";
import NavBar from "./components/Layout/NavBar/NavBar";

function App() {
  return (
    <div className="App">
      <NavBar />
      <ListActivity />
      <img src="/images/a.jpg" alt="logo"></img>
    </div>
  );
}

export default App;
