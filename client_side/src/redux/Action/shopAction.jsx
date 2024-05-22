// actions/DrinkActions.js
import adminService from "../../services/adminService";
import drinkService from "../../services/drinkService";
import { 
    approveShopSuccess,
    updateShopSuccess,
    updateShopFailure,
    fetchShopsSuccess,
    fetchShopsFailure,
    approveShopFailure
 } from "../Reducer/shopSlice";

export const fetchShops = () => {
  return async (dispatch) => {
    try {
      // Gọi API để lấy danh sách drinks
      const response = await adminService.getAllShopsAsAdmin();
      // const data = await response.json();

      // Dispatch action fetchDrinksSuccess với dữ liệu drinks
      dispatch(fetchShopsSuccess(response.data));
    } catch (error) {
      // Nếu gặp lỗi, dispatch action fetchDrinksFailure với thông điệp lỗi
      dispatch(fetchShopsFailure(error.message));
    }
  };
};

export const approveShop = (idShop) => {
  return async (dispatch) => {
    try {
      const response = await adminService.approveShop(idShop);

      response.status == 200 && dispatch(fetchShops());
    } catch (error) {
      dispatch(approveShopFailure(error.message));
    }
  };
};

export const updateShop = (idShop) => {
  return async (dispatch) => {
    try {
      const response = await drinkService.updateDrink(idShop);

      response.status == 200 && dispatch(fetchShops());
    } catch (error) {
      dispatch(updateShopFailure(error.message));
    }
  };
};
