import React, { useEffect, useState } from "react";
import './LoginSignup.css'
import LoginService from "../../services/LoginService";
import user_icon from '../../assets/person.png'
import email_icon from '../../assets/email.png'
import password_icon from '../../assets/password.png'
import address_icon from '../../assets/address.png'
import business_icon from '../../assets/business.png'
import { Link, useNavigate } from "react-router-dom";
import drinkService from "../../services/drinkService";
const LoginSignup = () => {
    const navigate = useNavigate()
    const [action, setAction] = useState("Sign Up");
    const [userNameOrEmailOrPhoneNumber, setUserNameOrEmailOrPhoneNumber] = useState("");
    const [password, setPassword] = useState("");
    const account = {
        userNameOrEmailOrPhoneNumber: userNameOrEmailOrPhoneNumber,
        password: password
    }

    const doLogin = async () => {
        console.log(account)
        const response = await LoginService.doLogin(account);
        console.log(response);
        if (response.status == 200) {
            localStorage.setItem("user", JSON.stringify(response.data));
            navigate('/home/order');
        }

    }

    useEffect(() => {
        const jwtToken = localStorage.getItem('user');
        if(jwtToken)
        {
            navigate('/home/order');
        }
    }, []);

    return (
        <div className='container'>
            <div className="header">
                <div className="text">{action}</div>
                <div className="underline"></div>
            </div>
            <div className="inputs">
                {action === "Login" ? <div></div> :
                    <div className="input">
                        <img src={user_icon} alt="" />
                        <input type="text" placeholder="Name" />
                    </div>

                }
                {action === "Login" ? <div></div> :
                    <div className="input">
                        <img src={business_icon} alt="" />
                        <input type="text" placeholder="Business" />
                    </div>
                }
                {action === "Login" ? <div></div> :
                    <div className="input">
                        <img src={address_icon} alt="" />
                        <input type="text" placeholder="Address" />
                    </div>
                }
                <div className="input">
                    <img src={email_icon} alt="" />
                    <input autoComplete="username" placeholder="Email" value={userNameOrEmailOrPhoneNumber} onChange={(e) => setUserNameOrEmailOrPhoneNumber(e.target.value)} />
                </div>
                <div className="input">
                    <img src={password_icon} alt="" />
                    <input autocomplete="current-password" type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)} />
                </div>
                {action === "Sign Up" ? <div></div> : <div className="forgot_password">Forgot Password?
                    <span>Click here</span>
                    <button className="btn_login" onClick={() => {
                        doLogin()
                        // navigate('/order')
                        //     // setCheck(true);
                        //     window.location.reload();

                    }}>Login</button>
                </div>}
            </div>


            {action === "Login" ? <div></div> : <div className="change_signup">Register already? <span onClick={() => { setAction("Login") }}>Login</span><button className="btn_signup">SignUp</button>
            </div>}

            {action === "Sign Up" ? <div></div> : <div className="text_havenot_acccout">Dont have an accouut? <span onClick={() => { setAction("Sign Up") }}>SignUp</span></div>}

        </div>
    );
};
export default LoginSignup