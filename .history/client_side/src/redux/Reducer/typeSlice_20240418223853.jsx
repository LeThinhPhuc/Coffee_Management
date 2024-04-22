import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    types: [],
};

const typeSlice = createSlice({
    name: "type",
    initialState,
    reducers: {},
});

export default typeSlice.reducer;
export const selectType = (state) => state.type.types;
