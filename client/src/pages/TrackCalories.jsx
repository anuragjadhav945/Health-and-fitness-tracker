import React, { useState } from "react";
import '../styles/TrackCalories.css'
const TrackCalories = () =>{

    const [mealName, setMealName] = useState('');
    const [calories, setCalories] = useState('');
    const [mealList, setMealList] = useState([]);

    const handleMealNameChange = (e) => setMealName(e.target.value);
    const handleCaloriesChange = (e) => setCalories(e.target.value);

    const handleAddMeal = () =>{
        if(!mealName || !calories){
            alert('Please enter both meal name and calories');
            return;
        }

        const newMeal = {name:mealName, calories:parseInt(calories)};
        setMealList([...mealList,newMeal]);
        setMealName('');
        setCalories('');
    };

    const totalCalories = mealList.reduce((acc,meal) => acc + meal.calories,0);
    const currentDateTime = new Date().toLocaleDateString();
    return (
        <div className="track-calories">
            <h2>Track Your Calories</h2>
            <div className="meal-input">
                <input
                    type="text"
                    placeholder="Enter Meal Name"
                    value={mealName}
                    onChange={handleMealNameChange}
                />

                <input
                    type="number"
                    placeholder="Calories"
                    value={calories}
                    onChange={handleCaloriesChange}
                />
                <button onClick={handleAddMeal}>Add Meal</button>
            </div>

            <div className="meal-list">
                <h3>Meal List</h3>
                <ul>
                    {mealList.map((meal,index) =>(
                        <li key ={index}>
                            {meal.name}: {meal.calories} kcal
                            <br/>
                            <small>{currentDateTime}</small>
                        </li>
                    ))}
                </ul>
            </div>

            <div className="total-calories">
                <h3>Total Calories: {totalCalories} kcal</h3>
                
            </div>
        </div>
    )
};

export default TrackCalories