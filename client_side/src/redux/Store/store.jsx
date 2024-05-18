// store.js
import { configureStore } from "@reduxjs/toolkit";
import drinkSlice from "../Reducer/drinkSlice";
import orderSlice from "../Reducer/orderSlice";
import typeSlice from "../Reducer/typeSlice";
import ingredientSlice from "../Reducer/ingredientSlice";
import voucherSlice from "../Reducer/voucherSlice";
import statisticService from "../../services/statisticService";
import statisticSlice from "../Reducer/statisticSlice";

const store = configureStore({
  reducer: {
    drink: drinkSlice,
    order: orderSlice,
    type: typeSlice,
    ingredient: ingredientSlice,
    voucher: voucherSlice,
    statistic: statisticSlice,

    // Đặt các reducer khác ở đây nếu cần
  },
  // Thêm middleware khác nếu cần

  // Thêm middleware khác nếu cần
});

export default store;
