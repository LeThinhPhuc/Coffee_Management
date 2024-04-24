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
import Table from "./../Statistic/Table/Table";
import Discount from '../Discount/Discount'
import Statistic from '../Statistic/Statistic';
import MainPage from '../MainPage/MainPage';
const AnimateRoute = () => {
    const location = useLocation();

    return (
        <Routes location={location} key={location.pathname}>
            <Route path="/" element={<LoginSignup/>} />
            <Route path="/home" element={<MainPage/>}>
                <Route exact path="/home/order" element={<OrderPage/>}/>
                <Route exact path="/home/drink" element={<ManageMenu/>}/>
                <Route exact path="/home/voucher" element={<Discount/>}/>
                <Route exact path="/home/ingredient" element={<ManageIngredient/>}/>
                <Route exact path="/home/static" element={<Statistic/>}/>
                <Route path="*" element={<div className='text-center text-[100px]'>PAGE NOT FOUND</div>} />
            </Route>
        </Routes>
    )
}
export default AnimateRoute;
