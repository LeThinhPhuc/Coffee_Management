import React, { useState } from "react" ;
import './LoginSignup.css'

import user_icon from '../../assets/person.png'
import email_icon from '../../assets/email.png'
import password_icon from '../../assets/password.png'
import address_icon from '../../assets/address.png'
import business_icon from '../../assets/business.png'
import { Link, useNavigate } from "react-router-dom";

const LoginSignup = () => {
    const navigate=useNavigate()
    const[action,setAction] = useState("Sign Up");
    const[username,setUsername] = useState("");
    const[password,setPassword] = useState("");
    const account = {
        'email' : "admin@gmail.com",
        "password" : "123455"
    }

    const doLogin = () => {

        const axios = require('axios');
        axios.get("")
        if(username === account.email && password === account.password)
        {
            console.log("dang nhap thanh cong");
        }
        else console.log("that bai");

    }
     
    return (
      <div className='container'>
        <div className="header">
            <div className="text">{action}</div>
            <div className="underline"></div>
        </div>
        <div className="inputs">
            {action==="Login"?<div></div>:
                <div className="input">
                <img src={user_icon} alt="" />
                <input type="text" placeholder="Name" />
            </div>
               
            }
             {action==="Login"?<div></div>:
             <div className="input">
                <img src={business_icon} alt="" />
                <input type="text" placeholder="Business" />
            </div>
            }   
             {action==="Login"?<div></div>:
             <div className="input">
                <img src={address_icon} alt="" />
                <input type="text" placeholder="Address" />
            </div>
            }       
            <div className="input">
                <img src={email_icon} alt="" />
                <input type="email" placeholder="Email" value={username} onChange={(e) => setUsername(e.target.value)}/>
            </div>
            <div className="input">
                <img src={password_icon} alt="" />
                <input type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)}/>
            </div>
        </div>
        {action==="Sign Up"?<div></div>: <div className="forgot_password">Forgot Password? 
        <span>Click here</span>  
        <button className="btn_login" onClick={() => {
            doLogin()
            navigate('/order')
                // setCheck(true);
                window.location.reload();

        }}>Login</button> 
        </div>}
        {action==="Login"?<div></div>: <div className="change_signup">Register already? <span onClick={()=>{setAction("Login")}}>Login</span><button className="btn_signup">SignUp</button>
</div>}

        {action==="Sign Up"?<div></div>: <div className="text_havenot_acccout">Dont have an accouut? <span  onClick={()=>{setAction("Sign Up")}}>SignUp</span></div>}
        
        </div>
    );
};
export default LoginSignup