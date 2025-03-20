import axios from 'axios';

const API_URL = 'https://localhost:7226/api';

const getAllCalories = async () => {
  try {
    const response = await axios.get(`${API_URL}/calorie`);
    return response.data;
  } catch (error) {
    throw error.response.data;
  }
};

const addCalorie = async (calorieData) => {
  try {
    const response = await axios.post(`${API_URL}/calorie`, calorieData);
    return response.data;
  } catch (error) {
    throw error.response.data;
  }
};

export default {
  getAllCalories,
  addCalorie,
};
