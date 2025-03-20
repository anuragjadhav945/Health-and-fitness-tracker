import axios from 'axios';

const API_URL = 'https://localhost:7226/api';  // Backend URL

// Get all weight data for the insights chart
const getWeightData = async () => {
    try {
        const response = await axios.get(`${API_URL}/weight`);
        return response.data;
    } catch (error) {
        throw error.response.data;
    }
};

// Get all calorie data for the insights chart
const getCaloriesData = async () => {
    try {
        const response = await axios.get(`${API_URL}/calorie`);
        return response.data;
    } catch (error) {
        throw error.response.data;
    }
};

// Get all calories burned data for the insights chart
const getCaloriesBurnedData = async () => {
    try {
        const response = await axios.get(`${API_URL}/calories-burned`);
        return response.data;
    } catch (error) {
        throw error.response.data;
    }
};

// Fetch all data related to fitness insights
const getFitnessInsightsData = async () => {
    try {
        const weightData = await getWeightData();
        const caloriesData = await getCaloriesData();
        const caloriesBurnedData = await getCaloriesBurnedData();

        return { weightData, caloriesData, caloriesBurnedData };
    } catch (error) {
        throw error.response.data;
    }
};

export default {
    getFitnessInsightsData,
    getWeightData,
    getCaloriesData,
    getCaloriesBurnedData,
};