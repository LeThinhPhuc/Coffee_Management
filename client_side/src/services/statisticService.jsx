import axios from "axios";
const statisticService = {
  getMonthlyRevenueStatus: () =>
    axios
      .create({
        baseURL: "http://localhost:5146/",
        timeout: 5000,
        headers: {
          "Content-Type": "application/json",
          "Access-Control-Allow-Headers":
            "Origin, X-Requested-With, Content-Type, Accept",
          "Access-Control-Allow-Origin": "https://localhost:5173",
          "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
          Accept: "application/x-www-form-urlencoded, text/plain",
        },
      })
      .get("api/Analytic/GetMonthlyRevenueStatus"),
  getLastMonthRevenueByDrinkType: () =>
    axios
      .create({
        baseURL: "http://localhost:5146/",
        timeout: 5000,
        headers: {
          "Content-Type": "application/json",
          "Access-Control-Allow-Headers":
            "Origin, X-Requested-With, Content-Type, Accept",
          "Access-Control-Allow-Origin": "https://localhost:5173",
          "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
          Accept: "application/x-www-form-urlencoded, text/plain",
        },
      })
      .get("api/Analytic/GetLastMonthRevenueByDrinkType"),
  getWeeklyRevenueStatus: () =>
    axios
      .create({
        baseURL: "http://localhost:5146/",
        timeout: 5000,
        headers: {
          "Content-Type": "application/json",
          "Access-Control-Allow-Headers":
            "Origin, X-Requested-With, Content-Type, Accept",
          "Access-Control-Allow-Origin": "https://localhost:5173",
          "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
          Accept: "application/x-www-form-urlencoded, text/plain",
        },
      })
      .get("api/Analytic/GetWeeklyRevenueStatus"),

  getCurrentMonthRevenueByDrinkType: () =>
    axios
      .create({
        baseURL: "http://localhost:5146/",
        timeout: 5000,
        headers: {
          "Content-Type": "application/json",
          "Access-Control-Allow-Headers":
            "Origin, X-Requested-With, Content-Type, Accept",
          "Access-Control-Allow-Origin": "https://localhost:5173",
          "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
          Accept: "application/x-www-form-urlencoded, text/plain",
        },
      })
      .get("api/Analytic/GetCurrentMonthRevenueByDrinkType"),
};
export default statisticService;
