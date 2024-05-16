import { createSlice } from "@reduxjs/toolkit";
// import { HANDLE_AUTH_ERROR } from '../actions/authError'; // Import the HANDLE_AUTH_ERROR action type

const initialState = {
    types: [],
    authError: null,
};

const typeSlice = createSlice({
    name: "type",
    initialState,
    reducers: {
        fetchDrinkTypeData(state, action) {
            state.types = action.payload;
        },
        handleAuthError(state, action) {
            state.authError = action.payload.message;
        },
    },
});

export default typeSlice.reducer;
export const selectTypes = (state) => state.type.types;
export const selectAuthError = (state) => state.type.authError;
export const { fetchDrinkTypeData, handleAuthError } = typeSlice.actions;
