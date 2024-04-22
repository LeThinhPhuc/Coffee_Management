import { useEffect } from "react";
import { BrowserRouter as Router } from "react-router-dom";
import { useDispatch } from "react-redux";
import { AppProvider } from "./context/MenuContext";
import AnimateRoute from "./components/Animate/AnimateRoute";
import { fetchDrinks } from "./redux/Action/drinkAction";
import { fetchTypes } from "./redux/Action/typeAction";
import { fetchOrders } from "./redux/Action/orderAction";
import { fetchIngredient } from "./redux/Action/ingredientAction";

function App() {
    const dispatch = useDispatch();

    useEffect(() => {
        dispatch(fetchDrinks());
        dispatch(fetchTypes());
        dispatch(fetchOrders());
        dispatch(fetchIngredient());
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
