import { createSlice } from "@reduxjs/toolkit";

//! Type of drink
const initialState = {
    types: [],
};

const typeSlice = createSlice({
    name: "type",
    initialState,
    reducers: {
        fetchDrinkTypeData(state, action) {
            state.types = action.payload;
        },
    },
});

export default typeSlice.reducer;
export const selectTypes = (state) => state.type.types;
export const { fetchDrinkTypeData } = typeSlice.actions;
