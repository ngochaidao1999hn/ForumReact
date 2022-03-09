import React, { useState,useEffect } from "react";
import logo from "./logo.svg";
import "./App.css";
import Activity from "./components/activities/activity";
import NavBar from "./components/Layout/NavBar/NavBar";
import { IActivity } from "./models/IActivity";
import axios from "axios";

function App() {
  const [openForm, setOpenForm] = useState(false);
  const createActivityHandler = (input: boolean) => {
    setOpenForm(input);
  };
  const CloseHandler = (close: boolean) => {
    setOpenForm(close);
  };

  console.log(openForm);
  return (
    <div className="App">
      <NavBar createActivity={createActivityHandler} />
      <Activity openForm={openForm} closeForm={CloseHandler} />
    </div>
  );
}

export default App;
