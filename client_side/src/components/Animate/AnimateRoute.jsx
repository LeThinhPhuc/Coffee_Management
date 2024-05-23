// import { Routes, Route, Router, useLocation } from "react-router-dom";
import {
    BrowserRouter as Router,
    Routes,
    Route,
    useLocation,
} from "react-router-dom";
import LoginSignup from "../Login_Signup/LoginSignup";
import OrderPage from "../OrderPage/OrderPage";
import ManageMenu from "../manage/manageMenu/ManageMenu";
import ManageIngredient from "../manage/manageIngredient/ManageIngredient";
import Statistic from "../Statistic/Statistic";
import MainPage from "../MainPage/MainPage";
import Discount from "../Discount/Discount";
import ManageDrinkType from "../manage/manageDrinkType/ManageDrinkType";
import PrivateRoute from "../../PrivateRoute/PrivateRoute";
import AdminRoute from "../../PrivateRoute/AdminRoute";
import AdminPage from "../AdminPage/AdminPage";
import Profile from "../Profile/Profile";
// import Voucher from "../Discount/TuanhayhoDemoVoucher";
const AnimateRoute = () => {
    const location = useLocation();

    return (
        <Routes location={location} key={location.pathname}>
            <Route path="/" element={<LoginSignup />} />
            <Route path="/home" element={<PrivateRoute component={MainPage}/>}>
                <Route exact path="/home/order" element={<PrivateRoute component={OrderPage}/>} />
                <Route exact path="/home/drink" element={<PrivateRoute component={ManageMenu}/>} />
                <Route exact path="/home/voucher" element={<PrivateRoute component={Discount}/>} />
                <Route exact path="/home/profile" element={<PrivateRoute component={Profile}/>} />
                <Route
                    exact
                    path="/home/ingredient"
                    element={<PrivateRoute component={ManageIngredient}/>}
                />

                <Route exact path="/home/static" element={<PrivateRoute component={Statistic}/>} />
                <Route exact path="/home/type" element={<PrivateRoute component={ManageDrinkType}/>} />
                
                <Route
                    path="*"
                    element={
                        <div className="text-center text-[100px]">
                            PAGE NOT FOUND
                        </div>
                    }
                />
            </Route>
            <Route exact path="/admin" element={<AdminRoute component={AdminPage}/>} />
            <Route
                    path="*"
                    element={
                        <div className="text-center text-[100px]">
                            PAGE NOT FOUND
                        </div>
                    }
                />
        </Routes>
    );
};
export default AnimateRoute;
