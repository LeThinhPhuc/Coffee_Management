import React, { useEffect, useState } from "react";
import "./LoginSignup.css";
import LoginService from "../../services/LoginService";
import user_icon from "../../assets/person.png";
import email_icon from "../../assets/email.png";
import password_icon from "../../assets/password.png";
import address_icon from "../../assets/address.png";
import business_icon from "../../assets/business.png";
import { Link, useNavigate } from "react-router-dom";
import drinkService from "../../services/drinkService";
import RegisterService from "../../services/RegisterService";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

// toast.configure({
//     autoClose: 2000,
//     draggable: false,
//     position: toast.POSITION.TOP_LEFT
//   })
  const notify = () => {
    toast.success('🦄 Wow so easy!', {
        position: "top-left",
        autoClose: 5000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: undefined,
    });
  }
const LoginSignup = () => {
    const navigate = useNavigate();
    const [action, setAction] = useState("Sign Up");
    const [userNameOrEmailOrPhoneNumber, setUserNameOrEmailOrPhoneNumber] = useState("");
    const [password, setPassword] = useState("");

    const [userName,setUserName] = useState("");
    const [fullName,setfullName] = useState("");
    const [Business,setBusiness] = useState("");
    const [Address,setAddress] = useState("");
 

    const account = {
        userNameOrEmailOrPhoneNumber: userNameOrEmailOrPhoneNumber,
        password: password,
    };

    const infoRegister = {
        fullName : fullName,
        bussinessName:Business,
        userName:Business,
        bussinessAdress:Address,
        email: userNameOrEmailOrPhoneNumber,
        password:password
    }

    const doLogin = async () => {
        const response = await LoginService.doLogin(account);
        
        if (response.status == 200) {
            localStorage.setItem("user", JSON.stringify(response.data));
            navigate("/home/order");
        }
    };

    const doRegister = async() => {
       
        try{
            console.log(infoRegister)
            await RegisterService.doRegister(infoRegister);
            setAction("Login");

                // const res = await LoginService.doLogin(account);
                //     localStorage.setItem("user", JSON.stringify(res.data));
                //     navigate("/home/order");
        }catch(error){
            console.log(error)
        }
    }

    useEffect(() => {
        const jwtToken = localStorage.getItem("user");
        if (jwtToken) {

            navigate("/home/order");
        }
    }, []);

    return (
        <div className="container">

            <div className="header">
                <div className="text">{action}</div>
                <div className="underline"></div>
            </div>
            <div className="inputs">
                {action === "Login" ? (
                    <div></div>
                ) : (
                    <div className="input">
                        <img src={user_icon} alt="" />
                        <input type="text" 
                        placeholder="Full Name" 
                        autoComplete="fullName"
                        value ={fullName}
                        onChange={(e) =>
                            setfullName(e.target.value)
                        }
                        />
                    </div>
                )}
                {action === "Login" ? (
                    <div></div>
                ) : (
                    <div className="input">
                        <img src={business_icon} alt="" />
                        <input type="text" 
                        placeholder="Business"  
                        autoComplete="Business"
                        value ={Business}
                        onChange={(e) =>
                            setBusiness(e.target.value)
                        }
                        />
                    </div>
                )}
                {action === "Login" ? (
                    <div></div>
                ) : (
                    <div className="input">
                        <img src={address_icon} alt="" />
                        <input type="text" 
                        placeholder="Address" 
                        autoComplete="Address"
                        value ={Address}
                        onChange={(e) =>
                            setAddress(e.target.value)
                        }
                        />
                    </div>
                )}
                <div className="input">
                    <img src={email_icon} alt="" />
                    <input
                        autoComplete="username"
                        placeholder="Email"
                        value={userNameOrEmailOrPhoneNumber}
                        onChange={(e) =>
                            setUserNameOrEmailOrPhoneNumber(e.target.value)
                        }
                    />
                </div>
                <div className="input">
                    <img src={password_icon} alt="" />
                    <input
                        autoComplete="current-password"
                        type="password"
                        placeholder="Password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                    />
                </div>
                {action === "Sign Up" ? (
                    <div></div>
                ) : (
                    <div className="forgot_password">
                        Forgot Password?
                        <span onClick={notify}>Click here</span>
                        <button
                            className="btn_login"
                            onClick={() => {
                                doLogin();

                                // navigate('/order')
                                //     // setCheck(true);
                                //     window.location.reload();
                            }}
                        >
                            Login
                        </button>
                    </div>
                )}
            </div>

            {action === "Login" ? (
                <div></div>
            ) : (
                <div className="change_signup">
                    Register already?{" "}
                    <span
                        onClick={() => {
                            setAction("Login");
                        }}
                    >
                        Login
                    </span>
                    <button 
                    className="btn_signup"
                    onClick={()=>{
                        doRegister();
                    }}
                    >SignUp</button>
                </div>
            )}

            {action === "Sign Up" ? (
                <div></div>
            ) : (
                <div className="text_havenot_acccout">
                    Dont have an accouut?{" "}
                    <span
                        onClick={() => {
                            setAction("Sign Up");
                        }}
                    >
                        SignUp
                    </span>
                </div>
            )}
        </div>
    );
};
export default LoginSignup;
