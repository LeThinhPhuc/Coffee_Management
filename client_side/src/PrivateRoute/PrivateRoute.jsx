import { Navigate } from "react-router-dom";
import { toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
const PrivateRoute = (props) =>{
    
    const {component: Component} = props;
    const isLoggedIn = localStorage.getItem("user");
    if(isLoggedIn&&JSON.parse(localStorage.getItem("user"))?.user?.roles[0]=="Member") return <Component/>
    else{
        toast.success('Login is required !', {
            position: "top-left",
            autoClose: 5000,
            hideProgressBar: false,
            closeOnClick: true,
            pauseOnHover: true,
            draggable: true,
            progress: undefined,
        });
        return <Navigate to="/"/>
    }
}
export default PrivateRoute;