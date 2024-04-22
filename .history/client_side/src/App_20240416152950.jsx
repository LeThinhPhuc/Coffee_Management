import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import Home from "./components/Home/Home";
import LeftMenu from "./components/Menu/LeftMenu/LeftMenu";
import ManageMenu from "./components/manage/manageMenu/ManageMenu";
import ManageIngredient from "./components/manage/manageIngredient/ManageIngredient";
import Manage from "./components/manage/Manage";
import Loading from "./components/manage/Loading";
import { AppProvider } from "./context/MenuContext";
import OrderPage from "./components/OrderPage/OrderPage";
import LoginSignup from "./components/Login_Signup/LoginSignup";

function App() {
    return (
        // <AppProvider>
            {/* <OrderPage></OrderPage> */}
            {/* <LoginSignup/> */}
            <ManageMenu></ManageMenu>
        // </AppProvider>
    );
}

export default App;
