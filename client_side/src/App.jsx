import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import Home from "./components/Home/Home";
import LeftMenu from "./components/Menu/LeftMenu/LeftMenu";
import ManageMenu from "./components/manage/manageMenu/ManageMenu";
import ManageIngredient from "./components/manage/manageIngredient/ManageIngredient";

function App() {
    return <ManageIngredient></ManageIngredient>;
}

export default App;
