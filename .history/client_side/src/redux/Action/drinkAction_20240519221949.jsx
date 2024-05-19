// actions/DrinkActions.js
import drinkService from "../../services/drinkService";
import {
    addDrinkFailure,
    deleteDrinkFailure,
    updateDrinkFailure,
    fetchDrinksSuccess,
    fetchDrinksFailure,
} from "../Reducer/drinkSlice";

export const fetchDrinks = () => {
    return async (dispatch) => {
        try {
            // Gọi API để lấy danh sách drinks
            const response = await drinkService.getAll();
            // const data = await response.json();

            // Dispatch action fetchDrinksSuccess với dữ liệu drinks
            dispatch(fetchDrinksSuccess(response.data));
        } catch (error) {
            // Nếu gặp lỗi, dispatch action fetchDrinksFailure với thông điệp lỗi
            dispatch(fetchDrinksFailure(error.message));
        }
    };
};

export const addDrink = (drinkData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu POST để thêm drink-item
            const response = await drinkService.addDrink(drinkData);

            response.status == 200 && dispatch(fetchDrinks());
        } catch (error) {
            dispatch(addDrinkFailure(error.message));
        }
    };
};

export const deleteDrink = (drinkId) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu DELETE để xóa người dùng
            const response = await drinkService.deleteDrink(drinkId);
            // console.log("delete drink");
            // console.log(response);

            response.status == 200 && dispatch(fetchDrinks());
        } catch (error) {
            dispatch(deleteDrinkFailure(error.message));
        }
    };
};

export const updateDrink = (drinkData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu PUT để cập nhật drink
            const response = await drinkService.updateDrink(drinkData);

            response.status == 200 && dispatch(fetchDrinks());
        } catch (error) {
            dispatch(updateDrinkFailure(error.message));
        }
    };
};
