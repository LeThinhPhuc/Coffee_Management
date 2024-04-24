import ingredientService from "../../services/ingredientService";
import {
    fetchIngredientData,
    addIngredientData,
} from "../Reducer/ingredientSlice";

export const fetchIngredients = () => {
    return async (dispatch) => {
        try {
            const response = await ingredientService.getAll();
            console.log("INGREDIENTS");
            console.log(response.data);

            dispatch(fetchIngredientData(response.data));
        } catch (error) {
            console.log(error);
        }
    };
};

export const addIngredient = (ingredientData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu POST để thêm drink-item
            const response = await ingredientService.addDrink(ingredientData);
            console.log("Add INGREDIENTS");
            console.log(response);

            dispatch(addIngredientData(response.data)); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};

// export const deleteDrink = (drinkId) => {
//     return async (dispatch) => {
//         try {
//             // Gửi yêu cầu DELETE để xóa người dùng
//             const response = await drinkService.deleteDrink(drinkId);
//             console.log("delete drink");
//             console.log(response);

//             dispatch(fetchDrinks()); // do response trả về không có item đã thêm
//         } catch (error) {
//             // Nếu gặp lỗi, dispatch action deleteDrinkFailure với thông điệp lỗi
//             dispatch(deleteDrinkFailure(error.message));
//         }
//     };
// };

// export const updateDrink = (drinkData) => {
//     return async (dispatch) => {
//         try {
//             // Gửi yêu cầu PUT để cập nhật drink
//             const response = await drinkService.updateDrink(drinkData);
//             console.log("UPDATE");
//             console.log(response.data);

//             dispatch(fetchDrinks()); // do response trả về không có item đã thêm
//         } catch (error) {
//             // Nếu gặp lỗi, dispatch action updateDrinkFailure với thông điệp lỗi
//             dispatch(updateDrinkFailure(error.message));
//         }
//     };
// };
