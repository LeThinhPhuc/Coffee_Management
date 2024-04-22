// store.js
import { configureStore } from "@reduxjs/toolkit";
import drinkSlice from "../Reducer/drinkSlice";

const store = configureStore({
    reducer: {
        drink: drinkSlice,
        // Đặt các reducer khác ở đây nếu cần
    },
    // Thêm middleware khác nếu cần
});

export default store;
