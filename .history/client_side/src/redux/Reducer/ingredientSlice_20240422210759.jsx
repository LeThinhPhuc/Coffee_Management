import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    ingredients: [],
};

const ingredientSlice = createSlice({
    name: "ingredient",
    initialState,
    reducers: {
        addIngredient(state, action) {
            state.drinks.push(action.payload);
        },
        deleteIngredient(state, action) {
            state.drinks = state.drinks.filter(
                (drink) => drink.id !== action.payload
            );
        },
        updateIngredient(state, action) {
            const { id, updateddrinkData } = action.payload;
            state.drinks = state.drinks.map((drink) =>
                drink.id === id ? { ...drink, ...updateddrinkData } : drink
            );
        },
        fetchIngredient(state, action) {
            state.drinks = action.payload;
        },
    },
});

export const {
    addIngredient,
    deleteIngredient,
    updateIngredient,
    fetchIngredient,
} = ingredientSlice.actions;
export const selectIngredients = (state) => state.ingredient.ingredients;
export default ingredientSlice.reducer;
