import { createSlice } from "@reduxjs/toolkit";

//! Type of drink
const initialState = {
    types: [],
};

const typeSlice = createSlice({
    name: "type",
    initialState,
    reducers: {
        addType(state, action) {
            console.log(action.payload);

            state.types = action.payload;
        },
    },
});

export default typeSlice.reducer;
export const selectTypes = (state) => state.type.types;
export const { addType } = typeSlice.actions;
