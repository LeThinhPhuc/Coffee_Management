// actions/DrinkActions.js
import drinkService from "../../services/drinkService";
import {
    addDrinkSuccess,
    addDrinkFailure,
    deleteDrinkSuccess,
    deleteDrinkFailure,
    updateDrinkSuccess,
    updateDrinkFailure,
    fetchDrinksSuccess,
    fetchDrinksFailure,
} from "../Reducer/drinkSlice";

export const fetchDrinks = () => {
    return async (dispatch) => {
        try {
            // Gọi API để lấy danh sách drinks
            const response = await drinkService.getAll();
            console.log("Drinks: " + response.data);
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
            const response = await fetch("https://api.example.com/Drinks", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(drinkData),
            });
            const data = await response.json();

            // Dispatch action addDrinkSuccess với dữ liệu drink-item mới được thêm
            dispatch(addDrinkSuccess(data));
        } catch (error) {
            // Nếu gặp lỗi, dispatch action addDrinkFailure với thông điệp lỗi
            dispatch(addDrinkFailure(error.message));
        }
    };
};

export const deleteDrink = (DrinkId) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu DELETE để xóa người dùng
            await fetch(`https://api.example.com/Drinks/${DrinkId}`, {
                method: "DELETE",
            });

            // Dispatch action deleteDrinkSuccess với ID của người dùng đã bị xóa
            dispatch(deleteDrinkSuccess(DrinkId));
        } catch (error) {
            // Nếu gặp lỗi, dispatch action deleteDrinkFailure với thông điệp lỗi
            dispatch(deleteDrinkFailure(error.message));
        }
    };
};

export const updateDrink = (DrinkId, updatedDrinkData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu PUT để cập nhật người dùng
            const response = await fetch(
                `https://api.example.com/Drinks/${DrinkId}`,
                {
                    method: "PUT",
                    headers: {
                        "Content-Type": "application/json",
                    },
                    body: JSON.stringify(updatedDrinkData),
                }
            );
            const data = await response.json();

            // Dispatch action updateDrinkSuccess với ID của người dùng và dữ liệu cập nhật
            dispatch(
                updateDrinkSuccess({ id: DrinkId, updatedDrinkData: data })
            );
        } catch (error) {
            // Nếu gặp lỗi, dispatch action updateDrinkFailure với thông điệp lỗi
            dispatch(updateDrinkFailure(error.message));
        }
    };
};
