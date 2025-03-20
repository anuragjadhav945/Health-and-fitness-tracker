import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import Dashboard from "./pages/Dashboard";
import LogWorkout from "./pages/LogWorkout";
import TrackCalories from "./pages/TrackCalories";
import Insights from "./pages/Insights";
import Login from "./pages/Login";
import Register from "./pages/Register";
import '@fortawesome/fontawesome-free/css/all.min.css';

function App (){
    return (
        <Routes>
          <Route path="/" element ={<Login/>}/>
          <Route path='/dashboard' element = {<Dashboard/>}/>
          <Route path="/log-workout" element = {<LogWorkout />}/>
          <Route path="/track-calories" element = {<TrackCalories/>}/>
          <Route path="/insights" element = {<Insights/>}/>
          <Route path="/register" element = {<Register/>}/>
        </Routes>
  );
};

export default App;

// import { Routes, Route } from "react-router-dom";
// import Login from "./pages/Login";
// import Dashboard from "./pages/Dashboard";

// function App() {
//   return (
//     <Routes>
//       <Route path="/" element={<Login />} />
//       <Route path="/dashboard" element={<Dashboard />} />
//     </Routes>
//   );
// }

// export default App;
