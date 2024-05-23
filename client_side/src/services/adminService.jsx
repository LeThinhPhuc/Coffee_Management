// Coffee_Management/client_side/src/services/adminService.jsx
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
                    "Authorization": `Bearer ${accessToken}`,  // pass token vào đây nè !!
                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .get("api/Admin/ShopsListAdmin");
    },
    approveShop: (shopId) => {
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
                    "Authorization": `Bearer ${accessToken}`,  // pass token vào đây nè !!
                    Accept: "application/x-www-form-urlencoded, text/plain",
                },
            })
            .get(`api/Admin/ApproveShop?shopId=${shopId}`);
    },
    suspenseShop: (shopId) =>{
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
                "Authorization": `Bearer ${accessToken}`,  // pass token vào đây nè !!
                Accept: "application/x-www-form-urlencoded, text/plain",
            },
        })
        .get(`api/Admin/SuspenseShop?shopId=${shopId}`);
    }
    
};

export default adminService;
