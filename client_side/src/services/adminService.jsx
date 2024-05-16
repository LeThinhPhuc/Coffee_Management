// Coffee_Management/client_side/src/services/typeService.jsx
import axios from "axios";

// Get the user obj from the first shop in the array of shops
const { user } = JSON.parse(localStorage.getItem("user"));
console.log(user);


const adminService = {
    getAllShopsAsAdmin: () => {
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
                    // token hardcode
                    "Authorization": `Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySUQiOiIzMWVlMWQ1ZC1jMjYyLTRjMDktOWI1ZC1mZTA5ZTMxNmQ4ZWUiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjMxZWUxZDVkLWMyNjItNGMwOS05YjVkLWZlMDllMzE2ZDhlZSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJhZG1pbiIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwiZXhwIjoxNzQ3MjcxNzgwLCJpc3MiOiJFTlRZS0VZQVBJIn0.tPuxjCQ73p5yfPh1iLu-xYqs7cgFlFK5HlFnBV4lvpU`,  // pass token vào đây nè !!
                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .get("api/Admin/ShopsListAdmin");
    },
    approveShop: (typeData) => {
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
                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .post("api/Admin/ApproveShop", typeData);
    },
    updateDrinkType: (typeData) => {
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
                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .put("api/DrinkType/update", typeData);
    },
    deleteDrinkType: (id) => {
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
                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .delete(`api/DrinkType/delete/${id}`);
    },
};

export default adminService;
