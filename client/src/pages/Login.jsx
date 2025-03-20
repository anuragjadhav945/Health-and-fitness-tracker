import { useState } from "react";
import { Link } from "react-router-dom";
import "../styles/Auth.css"
import userServices from "../services/userServices";

const Login= () =>{
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");

    const handleLogin =async(e) =>{
        e.preventDefault();
        try{
            const response = await userServices.loginUser({email, password});
            localStorage.setItem('token',response);
            alert('Login successful');
        }catch(err){
            setError(err);
            alert('Login failed')
        }
    };

    return (
        <div className="login-container">
            <h2>Login</h2>
            {error && <p className="error">{error}</p>}
            <form onSubmit={handleLogin}>
                <div className="input-group">
                    <i className="fa-solid fa-envelope"></i>
                    <input
                        type="email"
                        placeholder="Email"
                        value={email}
                        onChange={(e) => setEmail(e.target.value)}
                        required
                    />

                </div>
                
                <div className="input-group">
                    <i className="fa fa-lock"></i>
                    <input 
                        type="password"
                        placeholder="Password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        required
                    />
                </div>
                

                <button type="submit">Login</button>
                {error && <p>{error}</p>}
            </form>
            <p>
                Don't have an account? <Link to ="/register" className="register-button">Register Here</Link>
            </p>
        </div>
    );

};
export default Login