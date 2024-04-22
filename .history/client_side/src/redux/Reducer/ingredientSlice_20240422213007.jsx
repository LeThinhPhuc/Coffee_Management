import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    ingredients: [],
};

const ingredientSlice = createSlice({
    name: "ingredient",
    initialState,
    reducers: {
        addIngredient(state, action) {
            state.ingredients.push(action.payload);
        },
        deleteIngredient(state, action) {
            state.ingredients = state.ingredients.filter(
                (drink) => drink.id !== action.payload
            );
        },
        updateIngredient(state, action) {
            // const { id, updateddrinkData } = action.payload;
            // state.ingredients = state.ingredients.map((drink) =>
            //     drink.id === id ? { ...drink, ...updateddrinkData } : drink
            // );
        },
        fetchIngredientData(state, action) {
            console.log("Action");
            console.log(action.payload);
            state.ingredients = action.payload;
        },
    },
});

export const {
    addIngredient,
    deleteIngredient,
    updateIngredient,
    fetchIngredientData,
} = ingredientSlice.actions;

export const selectIngredients = (state) => state.ingredient.ingredients;
export default ingredientSlice.reducer;