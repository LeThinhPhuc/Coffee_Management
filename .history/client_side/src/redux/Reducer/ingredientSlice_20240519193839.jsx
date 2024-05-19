import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    // ingredients: [
    //     {
    //         name: "Sugar",
    //         amount: 10,
    //         expiryDate: "2024-06-15T16:04:26.2186773",
    //         id: "11f0dc32-65ca-497c-ab1e-233a2e26a7a0",
    //         dateCreated: "2024-04-15T16:04:26.2186768",
    //         dateModified: "2024-04-15T16:04:26.2186771",
    //     },
    //     {
    //         name: "Milk",
    //         amount: 5,
    //         expiryDate: "2024-05-15T16:04:26.218675",
    //         id: "2d9abae1-09d1-491e-bae3-6f51e219c89c",
    //         dateCreated: "2024-04-15T16:04:26.2186739",
    //         dateModified: "2024-04-15T16:04:26.2186747",
    //     },

    // ],
    ingredients: [],
    error: null,
};
const ingredientSlice = createSlice({
    name: "ingredient",
    initialState,
    reducers: {
        fetchIngredientData(state, action) {
            state.error = null;
            state.ingredients = action.payload;
        },
        addIngredientData(state, action) {
            state.error = null;
            state.ingredients.push(action.payload);
        },
        updateIngredientData(state, action) {
            state.error = null;
            const { id, ingredientData } = action.payload;
            state.ingredients = state.ingredients.map((item) =>
                item.id === id ? { ...item, ...ingredientData } : item
            );
        },
        deleteIngredientData(state, action) {
            state.error = null;
            state.ingredients = state.ingredients.filter(
                (item) => item.id !== action.payload
            );
        },
        deleteIngredientDataFail(state, action) {
            state.error = action.payload;
        },
        resetError(state) {
            state.error = null;
        },
    },
});

export const {
    addIngredientData,
    deleteIngredientData,
    updateIngredientData,
    fetchIngredientData,
    deleteIngredientDataFail,
    resetError,
} = ingredientSlice.actions;

export const selectIngredients = (state) => state.ingredient.ingredients;
export const selectIngredientsError = (state) => state.ingredient.error;
export default ingredientSlice.reducer;
