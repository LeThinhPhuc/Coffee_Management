import orderService from "../../services/orderService";
import { addOrderSuccess, fetchOrderSuccess } from "../Reducer/orderSlice";

export const addOrder = (OrderData) =>{
    return async (dispatch) =>{
        try{
            console.log('order data: ', OrderData)
            const res = await orderService.postOrder(OrderData);
            dispatch(addOrderSuccess(OrderData));

        } catch(error){
            console.log(error.message);
        }
    }
}
export const fetchOrders = () => {
    return async (dispatch) => {
      try {
        // Gọi API để lấy danh sách người dùng
        const response = await orderService.getAll();
        console.log("order trong db: ",response.data)
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