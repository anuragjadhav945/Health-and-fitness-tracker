import axios from "axios";

const API_URL = "https://localhost:7226/api/user/senddata";

export const register =async(name, email, password) =>{
    return axios.post('${API_URL}', {name , email, password});
};

export const login = async(email,password) => {
    return axios.post('${API_URL}',{ email, password});
};

export const logout = () =>{
    localStorage.removeItem("token");
}