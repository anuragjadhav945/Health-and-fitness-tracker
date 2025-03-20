import { useState } from "react";
import { Link } from "react-router-dom";
import "../styles/Auth.css"
import userServices from "../services/userServices";

const Register = () => {
    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");

    const handleRegister = async (e) => {
        e.preventDefault();
            try{
                const response = await userServices.registerUser({
                    Name : name,
                    Email : email,
                    Password: password,
                });
                alert('User Registered Successfully');
            }   catch(err){
                setError(err);
        }
    };
    return(
        <div className="register-container">
            <h2>Register</h2>
            {error && <p className="error">{error}</p>}
            <form onSubmit={handleRegister}>
                <div className="input-group">
                    <i className="fa fa-user"></i>
                        <input
                            type="text"
                            placeholder="Full Name"
                            value={name}
                            onChange={(e) => setName(e.target.value)}
                            required
                        />
                </div>
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
                            placeholder="Passwrod"
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                            required
                        />
                </div>
                <button type="submit">Register</button>
                {error && <p>{error}</p>}
            </form>
            <p>
                Already have an account? <Link to="/">login</Link>
            </p>
        </div>
    );
};
export default Register