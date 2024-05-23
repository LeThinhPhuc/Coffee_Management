import { useEffect, useState } from "react";
import "./LoginSignup.css";
import LoginService from "../../services/LoginService";
import user_icon from "../../assets/person.png";
import email_icon from "../../assets/email.png";
import password_icon from "../../assets/password.png";
import address_icon from "../../assets/address.png";
import business_icon from "../../assets/business.png";
import { useNavigate } from "react-router-dom";
import RegisterService from "../../services/RegisterService";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const LoginSignup = () => {
    const navigate = useNavigate();
    const [action, setAction] = useState("Login");
    const [userNameOrEmailOrPhoneNumber, setUserNameOrEmailOrPhoneNumber] = useState("");
    const [password, setPassword] = useState("");

    const [fullName, setFullName] = useState("");
    const [Business, setBusiness] = useState("");
    const [Address, setAddress] = useState("");

    const account = {
        userNameOrEmailOrPhoneNumber: userNameOrEmailOrPhoneNumber,
        password: password,
    };

    const infoRegister = {
        fullName: fullName,
        bussinessName: Business,
        userName: Business,
        bussinessAdress: Address,
        email: userNameOrEmailOrPhoneNumber,
        password: password
    };

    const doLogin = async () => {
        try {
            const response = await LoginService.doLogin(account);
            if (response.data.succeeded) {
                localStorage.setItem("user", JSON.stringify(response.data));
                if(response?.data?.user?.roles[0]=="Admin"){
                    navigate("/admin")
                }else if(response?.data?.user?.roles[0]=="Member"){
                    navigate("/home/order");
                }
                
            } else {
                response.data.errors.forEach(error => {
                    toast.error(error.description, {
                        position: "top-left",
                        autoClose: 5000,
                        hideProgressBar: false,
                        closeOnClick: true,
                        pauseOnHover: true,
                        draggable: true,
                        progress: undefined,
                    });
                });
            }
        } catch (error) {
            if (error.response && error.response.data && error.response.data.errors) {
                error.response.data.errors.forEach(err => {
                    toast.error(err.description, {
                        position: "top-left",
                        autoClose: 5000,
                        hideProgressBar: false,
                        closeOnClick: true,
                        pauseOnHover: true,
                        draggable: true,
                        progress: undefined,
                    });
                });
            } else {
                toast.error('An error occurred while logging in. Please try again.', {
                    position: "top-left",
                    autoClose: 5000,
                    hideProgressBar: false,
                    closeOnClick: true,
                    pauseOnHover: true,
                    draggable: true,
                    progress: undefined,
                });
            }
        }
    };

    const doRegister = async () => {
        try {
            await RegisterService.doRegister(infoRegister);
            setAction("Login");
            toast.success('Registration successful! You can now log in.', {
                position: "top-left",
                autoClose: 5000,
                hideProgressBar: false,
                closeOnClick: true,
                pauseOnHover: true,
                draggable: true,
                progress: undefined,
            });
        } catch (error) {
            toast.error('An error occurred while registering. Please try again.', {
                position: "top-left",
                autoClose: 5000,
                hideProgressBar: false,
                closeOnClick: true,
                pauseOnHover: true,
                draggable: true,
                progress: undefined,
            });
        }
    };

    useEffect(() => {
        if (JSON.parse(localStorage.getItem("user"))?.user?.roles[0]=="Admin") {
            navigate("/admin");

        }else if(JSON.parse(localStorage.getItem("user"))?.user?.roles[0]=="Member"){
            navigate("/home/order");

        }
    }, [navigate]);

    return (
        <div className="container">
            <ToastContainer />
            <div className="header">
                <div className="text">{action}</div>
                <div className="underline"></div>
            </div>
            <div className="inputs">
                {action === "Login" ? null : (
                    <>
                        <div className="input">
                            <img src={user_icon} alt="" />
                            <input
                                type="text"
                                placeholder="Full Name"
                                autoComplete="fullName"
                                value={fullName}
                                onChange={(e) => setFullName(e.target.value)}
                            />
                        </div>
                        <div className="input">
                            <img src={business_icon} alt="" />
                            <input
                                type="text"
                                placeholder="Business"
                                autoComplete="Business"
                                value={Business}
                                onChange={(e) => setBusiness(e.target.value)}
                            />
                        </div>
                        <div className="input">
                            <img src={address_icon} alt="" />
                            <input
                                type="text"
                                placeholder="Address"
                                autoComplete="Address"
                                value={Address}
                                onChange={(e) => setAddress(e.target.value)}
                            />
                        </div>
                    </>
                )}
                <div className="input">
                    <img src={email_icon} alt="" />
                    <input
                        autoComplete="username"
                        placeholder="Email"
                        value={userNameOrEmailOrPhoneNumber}
                        onChange={(e) => setUserNameOrEmailOrPhoneNumber(e.target.value)}
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
                {action === "Sign Up" ? null : (
                    <div className="forgot_password">
                        Forgot Password?
                        <span onClick={() => toast.info('Feature not implemented yet.')}>Click here</span>
                        <button
                            className="btn_login"
                            onClick={doLogin}
                        >
                            Login
                        </button>
                    </div>
                )}
            </div>
            {action === "Login" ? (
                <div className="text_havenot_acccout">
                    Don't have an account?{" "}
                    <span onClick={() => setAction("Sign Up")}>
                        SignUp
                    </span>
                </div>
            ) : (
                <div className="change_signup">
                    Register already?{" "}
                    <span onClick={() => setAction("Login")}>
                        Login
                    </span>
                    <button
                        className="btn_signup"
                        onClick={doRegister}
                    >
                        SignUp
                    </button>
                </div>
            )}
        </div>
    );
};

export default LoginSignup;
