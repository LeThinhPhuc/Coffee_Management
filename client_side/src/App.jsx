import React, { useEffect } from "react";
import { BrowserRouter as Router } from "react-router-dom";
import { Provider, useDispatch } from "react-redux";
import { AppProvider } from "./context/MenuContext";
import Navbar from "./components/Navbar/Navbar";
import AnimateRoute from "./components/Animate/AnimateRoute";
import store from "./redux/Store/store";
import { fetchDrinks } from "./redux/Action/drinkAction";
import { fetchTypes } from "./redux/Action/typeAction";
import { fetchOrders } from './redux/Action/orderAction';

function App() {
    const dispatch = useDispatch();

    useEffect(() => {
        dispatch(fetchDrinks());
        dispatch(fetchTypes());
        dispatch(fetchOrders())
    }, [dispatch]);

    return (
        <AppProvider>
                <Router>
                    <AnimateRoute />
                </Router>
        </AppProvider>
    );
}

export default App;
