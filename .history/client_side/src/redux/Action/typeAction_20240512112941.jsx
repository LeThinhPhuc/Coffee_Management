import typeService from "../../services/typeService";
import { fetchDrinkTypeData } from "../Reducer/typeSlice";

export const fetchDrinkType = () => {
    return async (dispatch) => {
        try {
            const response = await typeService.getAll();
            console.log("TYPES");
            console.log(response.data);

            // Dispatch action fetchTypes với dữ liệu types
            dispatch(fetchDrinkTypeData(response.data));
        } catch (error) {
            console.log(error);
        }
    };
};

export const addDrinkType = (typeData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu POST để thêm drink-item
            const response = await typeService.addDrinkType(typeData);
            console.log("Add type");
            console.log(response);

            dispatch(fetchDrinkType()); // do response trả về không có item đã thêm
            // dispatch(addIngredientData(response.data)); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};
