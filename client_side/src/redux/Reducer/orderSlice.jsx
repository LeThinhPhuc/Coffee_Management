import { createSlice } from "@reduxjs/toolkit";
import drinkService from "../../services/drinkService";
import drinkSlice from "./drinkSlice";
const initialState = {
    orders: [],
    error: null
}

const orderSlice = createSlice({
    name: 'order',
    initialState,
    reducers: {
        addOrderSuccess(state, action) {
            state.orders.push(action.payload);
            console.log("order da co: ", state.orders)
            state.error = null;
        },
        addOrderFailure(state, action) {
            state.error = action.payload;
        },
        fetchOrderSuccess(state, action) {
            state.orders = action.payload;
            state.error = null;
        }
        
    }
})


export const {
    addOrderSuccess,
    addOrderFailure,
    fetchOrderSuccess
} = orderSlice.actions;
export const selectOrders = state => state.order.orders;
export const orderError = state => state.order.error;
export default orderSlice.reducer;