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
  fetchCurrentMonthByDrinkType,
  fetchDailyDrinkInRange,
  fetchDailyInRange,
  fetchLastMonthByDrinkType,
  fetchMonthlyByYear,
  fetchMonthlyStatus,
  fetchWeeklyStatus,
} from "./redux/Action/statisticAction";
import { fetchShops } from "./redux/Action/shopAction";

function App() {
  const dispatch = useDispatch();

  useEffect(() => {
    const userString = localStorage.getItem("user");
    if (userString) {
      try {
        const user = JSON.parse(userString);
        if (user?.user?.roles?.[0] === "Admin") {
          console.log("Fetching data for Admin");
          dispatch(fetchShops());
        } else {
          console.log("Fetching data for non-Admin");
          dispatch(fetchDrinks());
          dispatch(fetchDrinkType());
          dispatch(fetchOrders());
          dispatch(fetchIngredients());
          dispatch(fetchVouchers());
          dispatch(fetchMonthlyStatus());
          dispatch(fetchWeeklyStatus());
          dispatch(fetchLastMonthByDrinkType());
          dispatch(fetchCurrentMonthByDrinkType());
          dispatch(fetchDailyDrinkInRange());
          dispatch(fetchDailyInRange());
          dispatch(fetchMonthlyByYear());
        }
      } catch (error) {
        console.error("Failed to parse user from localStorage", error);
      }
    } else {
      console.log("No user found in localStorage");
    }
  }, [dispatch]);

  return (
    <AppProvider>
      <Router>
        <AnimateRoute />
        {/* <AdminPage/> */}
      </Router>
    </AppProvider>
  );
}

export default App;
