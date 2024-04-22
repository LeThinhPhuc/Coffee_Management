import axios from 'axios'
const drinkService = {
    getAll: ()=> axios.create({
        baseURL: "http://localhost:5146/",
        timeout: 5000,
        headers: {
            "Content-Type": "application/json",
            "Access-Control-Allow-Headers": "Origin, X-Requested-With, Content-Type, Accept",
            "Access-Control-Allow-Origin":"https://localhost:5173",
            "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
            Accept: "application/x-www-form-urlencoded, text/plain",
          },
    }).get('api/Drink/getall')

}
export default drinkService;