import typeService from "../../services/typeService";
import { fetchDrinkTypeData } from "../Reducer/typeSlice";
import { HANDLE_AUTH_ERROR } from "./authError"; // Import the action type constant
import { handleAuthError } from "./authError";

// export const fetchDrinkType = () => {
//     return async (dispatch) => {
//         try {
//             const response = await typeService.getAll();
//             // console.log("TYPES");
//             console.log(response.data);

//             // Dispatch action fetchTypes với dữ liệu types
//             dispatch(fetchDrinkTypeData(response.data));
//         } catch (error) {
//             console.log(error);
//         }
//     };
// };

export const fetchDrinkType = () => {
    return async (dispatch) => {
        try {
            const response = await typeService.getAll();

            dispatch(fetchDrinkTypeData(response.data));
        } catch (error) {
            console.log(error);
            if (error.response && error.response.status === 401) {
                dispatch(handleAuthError()); // Dispatch handleAuthError if 401 Unauthorized
            }
        }
    };
};

export const addDrinkType = (drinkTypeData) => {
    return async (dispatch) => {
        try {
            // Gửi yêu cầu POST để thêm drink-item
            const response = await typeService.addDrinkType(drinkTypeData);
            // console.log("Add type");
            // console.log(response);

            response.status == 200 && dispatch(fetchDrinkType());
            // dispatch(addIngredientData(response.data)); // do response trả về không có item đã thêm
        } catch (error) {
            console.log(error);
        }
    };
};

export const updateDrinkType = (drinkTypeData) => {
    return async (dispatch) => {
        try {
            const response = await typeService.updateDrinkType(drinkTypeData);
            // console.log("UPDATE");
            // console.log(response.data);

            response.status == 200 && dispatch(fetchDrinkType());
        } catch (error) {
            console.log(error);
        }
    };
};

export const deleteDrinkType = (id) => {
    return async (dispatch) => {
        try {
            // console.log(id);
            const response = await typeService.deleteDrinkType(id);
            // console.log("delete");
            // console.log(response);

            response.status == 200 && dispatch(fetchDrinkType());
        } catch (error) {
            console.log(error);
        }
    };
};
