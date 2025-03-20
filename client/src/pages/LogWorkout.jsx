import React, {useState} from "react";
import "../styles/LogWorkout.css";

const LogWorkout = () =>{

    const [workouts, setWorkouts] = useState([]);
    const [form, setForm] = useState({type:"",duration:"", calories: ""});
    
    const handleChange = (e) =>{
        setForm({...form, [e.target.name]: e.target.value});
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        if(form.type && form.duration && form.calories){
            const newWorkout = {
                ...form,
                timestamp: new Date().toLocaleString()
            };
           
            setWorkouts([...workouts, newWorkout]);
            setForm({type: "", duration: "", calories: ""});
        }
    };

    return (
        <div className="log-workout-container">
            <h2>Log Workout</h2>
            <form className="workout-form" onSubmit={handleSubmit}>
                <label>Workout Type:</label>
                <input 
                    type="text" 
                    name="type" 
                    value={form.type} 
                    onChange={handleChange} 
                    required
                />

                <label>
                    Duration (minutes):
                </label>
                <input
                    type="number"
                    name="duration"
                    value={form.duration}
                    onChange={handleChange}
                    required
                />

                <label>
                    calories Burned: 
                </label>
                <input
                    type="number"
                    name="calories"
                    value={form.calories}
                    onChange = {handleChange}
                    required
                />

                <button type="submit">Add Workout</button>
            </form>

            <div className="workout-list">
                <h3>logged Workouts</h3>
                {workouts.length ===0 ? (<p>No workouts logged yet.</p>):(
                    <ul>
                        {workouts.map((workout,index) =>(
                            <li key={index}>
                                <strong>{workout.type}</strong> - {workout.duration} min, {workout.calories} cal
                                <br/>
                                <small>📅 {workout.timestamp}</small>
                            </li>
                        ))}
                    </ul>
                )}
            </div>

        </div>
    )
};

export default LogWorkout