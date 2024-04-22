import ingredientService from "../../services/ingredientService";

export const fetchIngredient = () => {
    return async (dispatch) => {
        try {
            const response = await ingredientService.getAll();
            console.log("INGREDIENTS");
            console.log(response.data);

            dispatch(fetchIngredient(response.data));
        } catch (error) {}
    };
};

//! cần hoàn cải thiện
export const addDrink = (drinkData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu POST để thêm drink-item
            const response = await drinkService.addDrink(drinkData);
            console.log("Add drink");
            console.log(response);

            dispatch(fetchDrinks()); // do response trả về không có item đã thêm
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
            console.log("delete drink");
            console.log(response);

            dispatch(fetchDrinks()); // do response trả về không có item đã thêm
        } catch (error) {
            // Nếu gặp lỗi, dispatch action deleteDrinkFailure với thông điệp lỗi
            dispatch(deleteDrinkFailure(error.message));
        }
    };
};

export const updateDrink = (drinkData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu PUT để cập nhật drink
            const response = await drinkService.updateDrink(drinkData);
            console.log("UPDATE");
            console.log(response.data);

            dispatch(fetchDrinks()); // do response trả về không có item đã thêm
        } catch (error) {
            // Nếu gặp lỗi, dispatch action updateDrinkFailure với thông điệp lỗi
            dispatch(updateDrinkFailure(error.message));
        }
    };
};
