import statisticService from "../../services/statisticService";
import {
  fetchMonthlyRevenueStatus,
  fetchWeeklyRevenueStatus,
  fetchLastMonthRevenueByDrinkType,
  fetchCurrentMonthRevenueByDrinkType,
  fetchDailyDrinkRevenueInRange,
} from "../Reducer/statisticSlice";

export const fetchMonthlyStatus = () => {
  return async (dispatch) => {
    try {
      const response = await statisticService.getMonthlyRevenueStatus();
      // console.log("Statistic");
      // console.log(response.data);

      dispatch(fetchMonthlyRevenueStatus(response.data));
    } catch (error) {
      console.log(error);
    }
  };
};

export const fetchLastMonthByDrinkType = () => {
  return async (dispatch) => {
    try {
      const response = await statisticService.getLastMonthRevenueByDrinkType();
      // console.log("Statistic");
      // console.log(response.data);

      dispatch(fetchLastMonthRevenueByDrinkType(response.data));
    } catch (error) {
      console.log(error);
    }
  };
};

export const fetchWeeklyStatus = () => {
  return async (dispatch) => {
    try {
      const response = await statisticService.getWeeklyRevenueStatus();
      // console.log("Statistic");
      // console.log(response.data);

      dispatch(fetchWeeklyRevenueStatus(response.data));
    } catch (error) {
      console.log(error);
    }
  };
};

export const fetchCurrentMonthByDrinkType = () => {
  return async (dispatch) => {
    try {
      const response =
        await statisticService.getCurrentMonthRevenueByDrinkType();
      // console.log("Statistic");
      // console.log(response.data);

      dispatch(fetchCurrentMonthRevenueByDrinkType(response.data));
    } catch (error) {
      console.log(error);
    }
  };
};

export const fetchDailyDrinkInRange = (drinkType, startDate, endDate) => {
  return async (dispatch) => {
    try {
      const response = await statisticService.getDailyDrinkRevenueInRange(
        drinkType,
        startDate,
        endDate
      );
      // console.log("Statistic");
      // console.log(response.data);

      dispatch(fetchDailyDrinkRevenueInRange(response.data));
    } catch (error) {
      console.log(error);
    }
  };
};
