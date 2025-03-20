import axios from 'axios';

const API_URL = 'https://localhost:7226/api'; // Change this if needed

// Register user
const registerUser = async (userData) => {
  try {
    const response = await axios.post(`${API_URL}/user/senddata`, userData);
    return response.data;
  } catch (error) {
    throw error.response.data;
  }
};

// Login user and return JWT token
const loginUser = async (userData) => {
  try {
    const response = await axios.post(`${API_URL}/jwtToken`, userData);
    return response.data;  // Should be the JWT token
  } catch (error) {
    throw error.response.data;
  }
};

export default {
  registerUser,
  loginUser,
};
