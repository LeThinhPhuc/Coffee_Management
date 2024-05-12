import typeService from "../../services/typeService";
import { fetchDrinkTypeData } from "../Reducer/typeSlice";

export const fetchDrinkType = () => {
    return async (dispatch) => {
        try {
            // Gọi API để lấy danh sách types
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
