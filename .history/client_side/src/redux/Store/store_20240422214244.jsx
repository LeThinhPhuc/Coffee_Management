// store.js
import { configureStore } from "@reduxjs/toolkit";
import drinkSlice from "../Reducer/drinkSlice";
import orderSlice from "../Reducer/orderSlice";
import typeSlice from "../Reducer/typeSlice";
import ingredientService from "../../services/ingredientService";
import ingredientSlice from "../Reducer/ingredientSlice";

const store = configureStore({
    reducer: {
        drink: drinkSlice,
        order: orderSlice,
        type: typeSlice,
        ingredient: ingredientSlice,
        // Đặt các reducer khác ở đây nếu cần
    },
    // Thêm middleware khác nếu cần

    // Thêm middleware khác nếu cần
});

export default store;
