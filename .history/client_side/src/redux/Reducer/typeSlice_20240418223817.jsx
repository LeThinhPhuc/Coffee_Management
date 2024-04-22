import { createSlice } from "@reduxjs/toolkit";
import { useSelector } from "react-redux";

const initialState = {
    types: [],
};

const typeSlice = createSlice({
    name: "type",
    initialState,
    reducers: {},
});

export default typeSlice.reducer;
export const selectType = useSelector((state) => state.type.types);
