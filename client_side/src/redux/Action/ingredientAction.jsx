import ingredientService from "../../services/ingredientService";
import {
  deleteIngredientDataFail,
  fetchIngredientData,
} from "../Reducer/ingredientSlice";

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
      const response = await ingredientService.addIngredient(ingredientData);
      console.log(response);

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

      console.log(response);

      response.status == 200 && dispatch(fetchIngredients());
    } catch (error) {
      console.log(error);
    }
  };
};

export const deleteIngredient = (id) => {
  return async (dispatch) => {
    try {
      // console.log(id);
      const response = await ingredientService.deleteIngredient(id);
      // console.log(response);

      if (response.data.succeeded) {
        dispatch(fetchIngredients());
      } else {
        dispatch(deleteIngredientDataFail(response.data.message));
      }
      // dispatch(fetchIngredients()); // do response trả về không có item đã thêm
    } catch (error) {
      console.log(error);
    }
  };
};
