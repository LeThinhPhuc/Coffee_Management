import React, { useEffect } from "react";
import { BrowserRouter as Router } from "react-router-dom";
import { Provider, useDispatch } from "react-redux";
import { AppProvider } from "./context/MenuContext";
import Navbar from "./components/Navbar/Navbar";
import AnimateRoute from "./components/Animate/AnimateRoute";
import store from "./redux/Store/store";
import { fetchDrinks } from "./redux/Action/drinkAction";

function App() {
    const dispatch = useDispatch();

    useEffect(() => {
        dispatch(fetchDrinks());
    }, [dispatch]);

    return (
        <AppProvider>
            <Router>
                <Navbar />
                <AnimateRoute />
            </Router>
        </AppProvider>
    );
}

export default App;
