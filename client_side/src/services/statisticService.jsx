import axios from "axios";

let accessToken = null;

const user = localStorage.getItem("user");
if (user) {
  try {
    const parsedUser = JSON.parse(user);
    if (parsedUser && parsedUser.accessToken) {
      accessToken = parsedUser.accessToken;
    }
  } catch (error) {
    console.error("Error parsing user from local storage:", error);
  }
}

const axiosInstance = axios.create({
  baseURL: "http://localhost:5146/",
  timeout: 5000,
  headers: {
    "Content-Type": "application/json",
    "Access-Control-Allow-Headers":
      "Origin, X-Requested-With, Content-Type, Accept",
    "Access-Control-Allow-Origin": "https://localhost:5173",
    "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
    Authorization: `Bearer ${accessToken}`,
    Accept: "application/x-www-form-urlencoded, text/plain",
  },
});

const statisticService = {
  getMonthlyRevenueStatus: () =>
    axiosInstance.get("api/Analytic/GetMonthlyRevenueStatus"),

  getLastMonthRevenueByDrinkType: () =>
    axiosInstance.get("api/Analytic/GetLastMonthRevenueByDrinkType"),

  getWeeklyRevenueStatus: () =>
    axiosInstance.get("api/Analytic/GetWeeklyRevenueStatus"),

  getCurrentMonthRevenueByDrinkType: () =>
    axiosInstance.get("api/Analytic/GetCurrentMonthRevenueByDrinkType"),

  getDailyDrinkRevenueInRange: (drinkType, startDate, endDate) =>
    axiosInstance.get("api/Analytic/GetDailyDrinkRevenueInRange", {
      params: { drinkType, startDate, endDate },
    }),

  getDailyRevenueInRange: (startDate, endDate) =>
    axiosInstance.get("api/Revenue/GetDailyRevenueInRange", {
      params: { startDate, endDate },
    }),
  getMonthlyRevenueByYear: (year) =>
    axiosInstance.get("api/Revenue/GetMonthlyRevenueByYear", {
      params: { year },
    }),
};

export default statisticService;
