import ingredientService from "../../services/ingredientService";
import { fetchIngredientData } from "../Reducer/ingredientSlice";

export const fetchIngredients = () => {
    return async (dispatch) => {
        try {
            const response = await ingredientService.getAll();
            // console.log("INGREDIENTS");
            // console.log(response.data);

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

            response.status == 200 && dispatch(fetchIngredients()); // do response trả về không có item đã thêm
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

            response.status == 200 && dispatch(fetchIngredients());
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

            response.status == 200 && dispatch(fetchIngredients()); // do response trả về không có item đã thêm
            // dispatch(fetchIngredients()); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};
