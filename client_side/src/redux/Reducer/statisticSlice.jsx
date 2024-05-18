import { createSlice } from "@reduxjs/toolkit";
import {
  fetchCurrentMonthByDrinkType,
  fetchWeeklyStatus,
} from "../Action/statisticAction";

const initialState = {
  statusbymonth: null,
  lastMonthByType: null,
  statusbyweek: null,
  currentMonthByType: null,
  error: null,
};

const statisticSlice = createSlice({
  name: "statistic",
  initialState,
  reducers: {
    fetchMonthlyRevenueStatus(state, action) {
      // console.log(action.payload);
      state.statusbymonth = action.payload;
    },
    fetchLastMonthRevenueByDrinkType(state, action) {
      // console.log(action.payload);
      state.lastMonthByType = action.payload;
    },
    fetchWeeklyRevenueStatus(state, action) {
      // console.log(action.payload);
      state.statusbyweek = action.payload;
    },
    fetchCurrentMonthRevenueByDrinkType(state, action) {
      // console.log(action.payload);
      state.currentMonthByType = action.payload;
    },
  },
});

export const {
  fetchMonthlyRevenueStatus,
  fetchWeeklyRevenueStatus,
  fetchLastMonthRevenueByDrinkType,
  fetchCurrentMonthRevenueByDrinkType,
} = statisticSlice.actions;

export const statusbymonth = (state) => state.statistic.statusbymonth;
export const statusbyweek = (state) => state.statistic.statusbyweek;
export const lastMonthByType = (state) => state.statistic.lastMonthByType;
export const currentMonthByType = (state) => state.statistic.currentMonthByType;
export default statisticSlice.reducer;
