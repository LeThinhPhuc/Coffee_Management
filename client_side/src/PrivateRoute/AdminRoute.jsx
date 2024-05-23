import { Navigate } from "react-router-dom";
import { toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
const AdminRoute = (props) =>{
    const {component : Component} = props;
    if(JSON.parse(localStorage.getItem("user"))?.user?.roles[0]=="Admin") return <Component/>
   
    return <Navigate to="/"/>
}
export default AdminRoute;