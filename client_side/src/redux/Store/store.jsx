// Coffee_Management/client_side/src/redux/Store/store.jsx
import { configureStore } from "@reduxjs/toolkit";
import drinkSlice from "../Reducer/drinkSlice";
import orderSlice from "../Reducer/orderSlice";
import typeSlice from "../Reducer/typeSlice";
import ingredientSlice from "../Reducer/ingredientSlice";
import voucherSlice from "../Reducer/voucherSlice";
import drinkTypesReducer from "../Reducer/drinkTypesReducer";

const store = configureStore({
    reducer: {
        drink: drinkSlice,
        order: orderSlice,
        type: typeSlice,
        ingredient: ingredientSlice,
        voucher: voucherSlice,
        drinkTypes: drinkTypesReducer,
        // Đặt các reducer khác ở đây nếu cần
    },
    // Thêm middleware khác nếu cần

    // Thêm middleware khác nếu cần
});

export default store;
