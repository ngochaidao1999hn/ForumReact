import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Activity from "./components/activities/activity";
import NavBar from "./components/Layout/NavBar/NavBar";

function App() {
  return (
    <div className="App">
      <NavBar />
      <Activity />
    </div>
  );
}

export default App;
