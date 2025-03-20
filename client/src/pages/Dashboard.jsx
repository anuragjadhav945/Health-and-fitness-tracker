import { Link } from "react-router-dom";
import "../styles/Dashboard.css";

import { FaDumbbell, FaUtensils, FaChartLine, FaBurn, FaRunning, FaHeartbeat } from "react-icons/fa";


const Dashboard = () =>{


    return (
        <div className="dashboard-container">
      {/* Sidebar */}
      <aside className="sidebar">
        <Link to = "/dashboard"><FaChartLine/>Overvidew</Link>
        <Link to = "/log-workout"><FaDumbbell/>Log Workout</Link>
        <Link to = "/track-calories"><FaUtensils/>Track Calories</Link>
        <Link t0 = "/insighths"><FaChartLine/>Insights</Link>
      </aside>

      {/* Main Content */}
      <div className="dashboard-main">
        <header className="dashboard-header">
          <h1>Welcome to Fitness Tracker</h1>
        </header>
        {/* Summary Cards */}
        <section className="summary-cards">
                    <div className="summary-card">
                        <FaRunning size={28} />
                        <p>Distance: 5km</p>
                    </div>
                    <div className="summary-card">
                        <FaBurn size={28} />
                        <p>Calories Burned: 1,200 kcal</p>
                    </div>
                    <div className="summary-card">
                        <FaHeartbeat size={28} />
                        <p>Heart Rate: 90 BPM</p>
                    </div>
                </section>
        <section className="quick-actions">
          <Link to="/log-workout" className="action-card">
            <FaDumbbell className="icon" />
            <p>Log a Workout</p>
          </Link>
          <Link to="/track-calories" className="action-card">
            <FaUtensils className="icon" />
            <p>Track Calories</p>
          </Link>
          <Link to="/insights" className="action-card">
            <FaChartLine className="icon" />
            <p>View Insights</p>
          </Link>
        </section>

        <section className="recent-activity">
          <h2>Recent Activity</h2>
          <p>No recent activity yet.</p>
        </section>

        <section className="graphs-container">
            <div className="graph-card">
                <h3>Workout Progress</h3>
                {/*Add chart component here later*/}
            </div>

            <div className="graph-card">
                <h3>Calorie intake</h3>
            </div>
        </section>
      </div>
    </div>
    );
};

export default Dashboard