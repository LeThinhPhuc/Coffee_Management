import axios from "axios";

// Get the shop ID from the first shop in the array of shops
// const { accessToken } = JSON.parse(localStorage.getItem("user"));

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

const drinkService = {
    getAll: () => {
        return axios
            .create({
                baseURL: "http://localhost:5146/",
                timeout: 5000,
                headers: {
                    "Content-Type": "application/json",
                    "Access-Control-Allow-Headers":
                        "Origin, X-Requested-With, Content-Type, Accept",
                    "Access-Control-Allow-Origin": "https://localhost:5173",
                    "Access-Control-Allow-Methods":
                        "GET,PUT,POST,DELETE,PATCH,OPTIONS",
                    Authorization: `Bearer ${accessToken}`,

                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .get("api/Drink/getallgrouped");
    },
    addDrink: (drinkData) => {
        return axios
            .create({
                baseURL: "http://localhost:5146/",
                timeout: 5000,
                headers: {
                    "Content-Type": "application/json",
                    "Access-Control-Allow-Headers":
                        "Origin, X-Requested-With, Content-Type, Accept",
                    "Access-Control-Allow-Origin": "https://localhost:5173",
                    "Access-Control-Allow-Methods":
                        "GET,PUT,POST,DELETE,PATCH,OPTIONS",
                    Authorization: `Bearer ${accessToken}`,

                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .post("api/Drink/add", drinkData);
    },
    updateDrink: (drinkData) => {
        return axios
            .create({
                baseURL: "http://localhost:5146/",
                timeout: 5000,
                headers: {
                    "Content-Type": "application/json",
                    "Access-Control-Allow-Headers":
                        "Origin, X-Requested-With, Content-Type, Accept",
                    "Access-Control-Allow-Origin": "https://localhost:5173",
                    "Access-Control-Allow-Methods":
                        "GET,PUT,POST,DELETE,PATCH,OPTIONS",
                    Authorization: `Bearer ${accessToken}`,

                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .put("api/Drink/update", drinkData);
    },
    deleteDrink: (id) => {
        return axios
            .create({
                baseURL: "http://localhost:5146/",
                timeout: 5000,
                headers: {
                    "Content-Type": "application/json",
                    "Access-Control-Allow-Headers":
                        "Origin, X-Requested-With, Content-Type, Accept",
                    "Access-Control-Allow-Origin": "https://localhost:5173",
                    "Access-Control-Allow-Methods":
                        "GET,PUT,POST,DELETE,PATCH,OPTIONS",
                    Authorization: `Bearer ${accessToken}`,

                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .delete(`api/Drink/delete/${id}`);
    },
};
export default drinkService;
