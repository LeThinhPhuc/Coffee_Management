// Coffee_Management/client_side/src/services/VoucherService.jsx
import axios from "axios";

// Get the accessToken from the user item in local storage
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

const VoucherService = {
  getAll: () =>
    axios
      .create({
        baseURL: import.meta.env.VITE_API_URL,
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
      })
      .get("api/VoucherCode/getall"),

  addVoucherCode: (data) => {
    return axios
      .create({
        baseURL: import.meta.env.VITE_API_URL,
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
      })
      .post("api/VoucherCode/add", data);
  },

  updateVoucherCode: (data) => {
    return axios
      .create({
        baseURL: import.meta.env.VITE_API_URL,
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
      })
      .put("api/VoucherCode/update", data);
  },

  deleteVoucherCode: (id) => {
    return axios
      .create({
        baseURL: import.meta.env.VITE_API_URL,
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
      })
      .delete(`api/VoucherCode/delete/${id}`);
  },
};
export default VoucherService;
