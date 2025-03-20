import React, { useState } from "react";
import { Line } from 'react-chartjs-2'
import { Chart as ChartJS, CategoryScale, LinearScale, PointElement,LineElement, Title, Tooltip, Legend } from "chart.js";
import '../styles/Insights.css'

ChartJS.register(CategoryScale, LinearScale, PointElement, LineElement, Title, Tooltip, Legend);


const Insights = ({ weightData=[], caloriesData=[], caloriesBurned =[], goalCalories= 0}) =>{

    const [weight, setWeight] = useState('');
    const [height, setHeight] = useState('');
    const [caloriesConsumed, setCaloriesConsumed] = useState('');
    const [caloriesBurnedData, setCaloriesBurnedData] = useState('');

    const calculateBMI = (weight, height) => {
        if(!weight || !height) return 0;

        return (weight / Math.pow(height/100,2)).toFixed(2);
    };

    const bmi = calculateBMI(weight,height);

    const weightChartData = {
        lables: weightData.map((entry) => entry.date),
        dataset:[
            {
                lable: 'weight (kg)',
                data: weightData.map((entry) => entry.weight),
                fill: false,
                borderColor: 'rgba(75, 192, 192,1)',
                tension: 0.1,
            },

            {
                lable: 'BMI',
                data: weightData.map((entry) => calculateBMI(entry.weight, height)),
                fill: false,
                borderColor: 'rgba(255,99,132,1)',
                tension: 0.1,
            },
        ],
    };

    const caloriesChartData = {
        lables : caloriesData.map((entry) => entry.date),
        datasets : [
            {
                label: 'Calories Consumed',
                data: caloriesData.map((entry) => entry.calories),
                fill: false,
                borderColor : 'rgba (75, 192, 192, 1)',
                tension: 0.1,
            },
            {
                lable: 'Calories Burned',
                data: caloriesBurnedData.map((entry) => entry.caloriesBurned),
                fill: false,
                borderColor: 'rgba(255, 99, 132, 1)',
                tension: 0.1,
            },
        ],
    };

    const isGoalMet = caloriesConsumed >= goalCalories? 'Goal met' : 'Goal Not Met';
    return (
        <div className="fitness-insights">
            <h2>Fitness Trends</h2>

            <div className="div bmi-section">
                <h3>your Current BMI: {bmi}</h3>
                <div className="input-fields">
                    <input
                        type="number"
                        placeholder="Enter your weight (kg)"
                        value={weight}
                        onChange={(e) => setWeight(e.target.value)}
                    />

                    <input
                        type="number"
                        placeholder="Enter your height in (cm)"
                        value={height}
                        onChange={(e) => setHeight(e.target.value)}
                    />
                </div>
            </div>

            <div className="weight-bmi-trends">
                <h3>Weight & BMI Trends</h3>
                <Line data = {weightChartData} options={{responsive: true}}/>
            </div>

            <div className="div calories-vs-burned">
                <h3>
                    Calories vs. Burned Calories
                </h3>
                <Line data = {caloriesChartData} options = {{responsive: true}}/>
            </div>
            <div className="goal-status">
                <h3>{isGoalMet}</h3>
            </div>
        </div>
    )
};

export default Insights