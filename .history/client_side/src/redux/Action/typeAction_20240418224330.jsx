import typeService from "../../services/typeService";



export const fetchTypes = () => {
    return async (dispatch) => {
        try {
            // Gọi API để lấy danh sách types
            const response = await typeService.getAll();
            console.log("TYPES");
            console.log(response.data);

            // Dispatch action fetchTypes với dữ liệu types
            dispatch(fetchTypes(response.data));
        } catch (error) {
        }
    };
};