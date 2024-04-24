
import VoucherService from "../../services/VoucherService";
import {fetchVoucherSuccess } from "../Reducer/voucherSlice";
export const fetchVouchers = () => {
    return async (dispatch) => {
      try {
        // Gọi API để lấy danh sách người dùng
        const response = await VoucherService.getAll();
        console.log("order trong db: ",response.data)
        // const data = await response.json();
  
        // Dispatch action fetchDrinksSuccess với dữ liệu người dùng
        dispatch(fetchVoucherSuccess(response.data));
      } catch (error) {
        console.log(error.message);
        // Nếu gặp lỗi, dispatch action fetchDrinksFailure với thông điệp lỗi
        // dispatch(fetchDrinksFailure(error.message));
      }
    };
  };