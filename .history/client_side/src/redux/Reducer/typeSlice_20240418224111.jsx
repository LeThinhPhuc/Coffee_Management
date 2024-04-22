import { createSlice } from "@reduxjs/toolkit";

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
export const selectType = (state) => state.type.types;