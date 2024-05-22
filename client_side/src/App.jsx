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
import AdminPage from "./components/AdminPage/AdminPage";
import { fetchShops } from "./redux/Action/shopAction";

function App() {
  const dispatch = useDispatch();

  useEffect(() => {
    if(localStorage.getItem("user")){
      if(JSON.parse(localStorage.getItem("user")).user.roles[0]=="Admin"){
        console.log(JSON.parse(localStorage.getItem("user")).user.roles[0])
        alert("day la admin")
        dispatch(fetchShops())
        
      }else{
        alert("day khong la admin")
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
    
    }
   
  }, [dispatch]);

  return (
    <AppProvider>
      <Router>
        {/* <AnimateRoute /> */}
        <AdminPage/>
      </Router>
    </AppProvider>
  );
}

export default App;
