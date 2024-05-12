import { useEffect } from "react";
import { BrowserRouter as Router } from "react-router-dom";
import { useDispatch } from "react-redux";
import { AppProvider } from "./context/MenuContext";
import AnimateRoute from "./components/Animate/AnimateRoute";
import { fetchDrinks } from "./redux/Action/drinkAction";
import { fetchTypes } from "./redux/Action/typeAction";
import { fetchOrders } from "./redux/Action/orderAction";
import { fetchIngredients } from "./redux/Action/ingredientAction";
import { fetchVouchers } from "./redux/Action/voucherAction";

function App() {
    const dispatch = useDispatch();

    useEffect(() => {
        dispatch(fetchDrinks());
        dispatch(fetchDrinkType());
        dispatch(fetchOrders());
        dispatch(fetchIngredients());
        dispatch(fetchVouchers());
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
