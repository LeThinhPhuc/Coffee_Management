import { createSlice } from "@reduxjs/toolkit";

const initialState = {
  statusbymonth: null,
  lastMonthByType: null,
  statusbyweek: null,
  currentMonthByType: null,
  dailyDrinkInRange: null,
  dailyInRange: null,
  monthsByYear: null,
  error: null,
};

const statisticSlice = createSlice({
  name: "statistic",
  initialState,
  reducers: {
    fetchMonthlyRevenueStatus(state, action) {
      state.statusbymonth = action.payload;
    },
    fetchLastMonthRevenueByDrinkType(state, action) {
      state.lastMonthByType = action.payload;
    },
    fetchWeeklyRevenueStatus(state, action) {
      state.statusbyweek = action.payload;
    },
    fetchCurrentMonthRevenueByDrinkType(state, action) {
      state.currentMonthByType = action.payload;
    },
    fetchDailyDrinkRevenueInRange(state, action) {
      state.dailyDrinkInRange = action.payload;
    },
    fetchDailyRevenueInRange(state, action) {
      state.dailyInRange = action.payload;
    },
    fetchMonthlyRevenueByYear(state, action) {
      state.monthsByYear = action.payload;
    },
  },
});

export const {
  fetchMonthlyRevenueStatus,
  fetchWeeklyRevenueStatus,
  fetchLastMonthRevenueByDrinkType,
  fetchCurrentMonthRevenueByDrinkType,
  fetchDailyDrinkRevenueInRange,
  fetchDailyRevenueInRange,
  fetchMonthlyRevenueByYear,
} = statisticSlice.actions;

export const statusbymonth = (state) => state.statistic.statusbymonth;
export const statusbyweek = (state) => state.statistic.statusbyweek;
export const lastMonthByType = (state) => state.statistic.lastMonthByType;
export const currentMonthByType = (state) => state.statistic.currentMonthByType;
export const dailyDrinkInRange = (state) => state.statistic.dailyDrinkInRange;
export const dailyInRange = (state) => state.statistic.dailyInRange;
export const monthsByYear = (state) => state.statistic.monthsByYear;
export default statisticSlice.reducer;
