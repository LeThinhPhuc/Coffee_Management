// store.js
import { configureStore } from "@reduxjs/toolkit";
import drinkSlice from "../Reducer/drinkSlice";
import typeSlice from "../Reducer/typeSlice";

const store = configureStore({
    reducer: {
        drink: drinkSlice,
        type: typeSlice,
        // Đặt các reducer khác ở đây nếu cần
    },
    // Thêm middleware khác nếu cần
});

export default store;
