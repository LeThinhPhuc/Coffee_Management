import { useEffect } from "react";
import { BrowserRouter as Router } from "react-router-dom";
import { useDispatch } from "react-redux";
import { AppProvider } from "./context/MenuContext";
import AnimateRoute from "./components/Animate/AnimateRoute";
import { fetchDrinks } from "./redux/Action/drinkAction";
import { fetchDrinkType } from "./redux/Action/typeAction";
import { fetchOrders } from "./redux/Action/orderAction";
import { fetchIngredients } from "./redux/Action/ingredientAction";
import { fetchVouchers } from "./redux/Action/voucherAction";
import {
  fetchLastMonthRevenueByDrinkType,
  fetchMonthlyRevenueStatus,
} from "./redux/Reducer/statisticSlice";
import {
  fetchCurrentMonthByDrinkType,
  fetchLastMonthByDrinkType,
  fetchMonthlyStatus,
  fetchWeeklyStatus,
} from "./redux/Action/statisticAction";

function App() {
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(fetchDrinks());
    dispatch(fetchDrinkType());
    dispatch(fetchOrders());
    dispatch(fetchIngredients());
    dispatch(fetchVouchers());
    dispatch(fetchMonthlyStatus());
    dispatch(fetchWeeklyStatus());
    dispatch(fetchLastMonthByDrinkType());
    dispatch(fetchCurrentMonthByDrinkType());
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
