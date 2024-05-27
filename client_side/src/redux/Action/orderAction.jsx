import { useContext } from "react";
import orderService from "../../services/orderService";
import { addOrderFailure, addOrderSuccess, fetchOrderSuccess } from "../Reducer/orderSlice";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
export const addOrder = (OrderData) => {
    return async (dispatch) => {
        try {
            console.log('order data: ', OrderData);
            const res = await orderService.postOrder(OrderData);
            dispatch(fetchOrders());
        } catch (error) {
            dispatch(addOrderFailure(error.message))

            console.error('Error placing order:', error);
        }
    };
};

export const fetchOrders = () => {
    return async (dispatch) => {
        try {

            const user = localStorage.getItem("user");
            const userJson = JSON.parse(user);
            const jwt = userJson.accessToken;
            let shopId = userJson.shops[0].id


            // Gọi API để lấy danh sách người dùng
            const response = await orderService.getOrderByShopId(shopId,jwt);
            console.log("order trong db: ", response.data)
            // const data = await response.json();

            // Dispatch action fetchDrinksSuccess với dữ liệu người dùng
            dispatch(fetchOrderSuccess(response.data));
        } catch (error) {
            console.log(error.message);
            // Nếu gặp lỗi, dispatch action fetchDrinksFailure với thông điệp lỗi
            // dispatch(fetchDrinksFailure(error.message));
        }
    };
};

