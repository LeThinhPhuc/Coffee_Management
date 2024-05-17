import axios from "axios";

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

const ingredientService = {
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
            .get("api/Ingredients");
    },
    addIngredient: (ingredientData) => {
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
            .post("api/Ingredients", ingredientData);
    },
    updateIngredient: (id, ingredientData) => {
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
            .put(`api/Ingredients/${id}`, ingredientData);
    },
    deleteIngredient: (id) => {
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
            .delete(`api/Ingredients/${id}`);
    },
};
export default ingredientService;
