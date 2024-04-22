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
import Discount from "../Discount/Discount";
import ManageIngredient from "../manage/manageIngredient/ManageIngredient";
import Statistic from "../Statistic/Statistic";
const AnimateRoute = () => {
    const location = useLocation();

    return (
        <Routes location={location} key={location.pathname}>
            <Route exact path="/" element={<LoginSignup />} />
            <Route exact path="/order" element={<OrderPage />} />
            <Route exact path="/drink" element={<ManageMenu />} />
            <Route exact path="/voucher" element={<Discount />} />
            <Route exact path="/ingredient" element={<ManageIngredient />} />
            <Route exact path="/static" element={<Statistic />} />
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
