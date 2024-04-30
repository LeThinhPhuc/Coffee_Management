import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    drinks: [],
    error: null,
};

const drinkSlice = createSlice({
    name: "drink",
    initialState,
    reducers: {
        addDrinkSuccess(state, action) {
            console.log(action.payload);
            state.drinks.push(action.payload);
            state.error = null; // Reset error to null when adding drink succeeds
        },
        addDrinkFailure(state, action) {
            state.error = action.payload;
        },
        deleteDrinkSuccess(state, action) {
            // Xóa drink-item khỏi danh sách dựa trên ID
            state.drinks = state.drinks.filter(
                (drink) => drink.id !== action.payload
            );
            state.error = null; // Reset error to null when deleting drink succeeds
        },
        deleteDrinkFailure(state, action) {
            state.error = action.payload;
        },
        updateDrinkSuccess(state, action) {
            // Cập nhật drink-item trong danh sách dựa trên ID
            const { id, updateddrinkData } = action.payload;
            state.drinks = state.drinks.map((drink) =>
                drink.id === id ? { ...drink, ...updateddrinkData } : drink
            );
            state.error = null; // Reset error to null when updating drink succeeds
        },
        updateDrinkFailure(state, action) {
            state.error = action.payload;
        },
        fetchDrinksSuccess(state, action) {
            state.drinks = action.payload;
            state.error = null; // Reset error to null when fetching drinks succeeds
        },
        fetchDrinksFailure(state, action) {
            state.error = action.payload;
        },
    },
});

export const {
    addDrinkSuccess,
    addDrinkFailure,
    deleteDrinkSuccess,
    deleteDrinkFailure,
    updateDrinkSuccess,
    updateDrinkFailure,
    fetchDrinksSuccess,
    fetchDrinksFailure,
} = drinkSlice.actions;
export const selectDrinks = (state) => state.drink.drinks;
export default drinkSlice.reducer;
