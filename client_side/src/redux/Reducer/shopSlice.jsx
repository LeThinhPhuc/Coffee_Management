import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    shops: [],
    error: null,
};

const shopSlice = createSlice({
    name: "shop",
    initialState,
    reducers: {
        approveShopSuccess(state, action) {
            console.log(action.payload);
            state.shops.push(action.payload);
            state.error = null; // Reset error to null when adding drink succeeds
        },
        approveShopFailure(state, action) {
            state.error = action.payload;
        },
        updateShopSuccess(state, action) {
            const index = state.drinks.findIndex(
                (drink) => drink.id === action.payload.id
            );
            if (index !== -1) {
                state.drinks[index] = action.payload;
            }
        },
        updateShopFailure(state, action) {
            state.error = action.payload;
        },
        fetchShopsSuccess(state, action) {
            state.shops = action.payload;
            state.error = null; // Reset error to null when fetching drinks succeeds
        },
        fetchShopsFailure(state, action) {
            state.error = action.payload;
        },
    },
});

export const {
   approveShopSuccess,
   approveShopFailure,
   updateShopSuccess,
   updateShopFailure,
   fetchShopsSuccess,
   fetchShopsFailure 
} = shopSlice.actions;
export const selectShops = (state) => state.shop.shops;
export default shopSlice.reducer;
