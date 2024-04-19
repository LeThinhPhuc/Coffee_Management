import { useDispatch } from "react-redux";
import typeService from "../../services/typeService";
import { addType } from "../Reducer/typeSlice";

export const fetchTypes = () => {
    return async () => {
        try {
            // Gọi API để lấy danh sách types
            const response = await typeService.getAll();
            console.log("TYPES");
            console.log(response.data);

            // Dispatch action fetchTypes với dữ liệu types
            useDispatch(addType(response.data));
        } catch (error) {
            console.log(error);
        }
    };
};
