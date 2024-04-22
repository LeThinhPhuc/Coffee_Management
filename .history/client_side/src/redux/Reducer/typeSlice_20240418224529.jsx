import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    types: [],
};

const typeSlice = createSlice({
    //! Type of drink
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
