import ingredientService from "../../services/ingredientService";
import {
    fetchIngredientData,
    addIngredientData,
    updateIngredientData,
    deleteIngredientData,
} from "../Reducer/ingredientSlice";

export const fetchIngredients = () => {
    return async (dispatch) => {
        try {
            console.log("FETCHHHHHHHHHH");
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
            const response = await ingredientService.addIngredient(
                ingredientData
            );
            console.log("Add INGREDIENTS");
            console.log(response);

            dispatch(fetchIngredients()); // do response trả về không có item đã thêm
            // dispatch(addIngredientData(response.data)); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};

export const updateIngredient = (id, ingredientData) => {
    return async (dispatch) => {
        try {
            const response = await ingredientService.updateIngredient(
                id,
                ingredientData
            );
            console.log("UPDATE");
            console.log(response.data);

            dispatch(updateIngredientData(id, ingredientData)); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};

export const deleteIngredient = (id) => {
    return async (dispatch) => {
        try {
            console.log(id);
            const response = await ingredientService.deleteIngredient(id);
            console.log("delete");
            console.log(response);

            dispatch(fetchIngredients()); // do response trả về không có item đã thêm
            // dispatch(fetchIngredients()); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};
