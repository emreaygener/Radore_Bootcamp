import logo from "./logo.svg";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { Link, Routes, Route } from "react-router-dom";
import TutorialList from "./components/tutorial-list.component";
import TutorialDetail from "./components/tutorial-detail.component";
import AddTutorial from "./components/add-tutorial.component";

function App() {
  return (
    <div className="App">
      <nav className="navbar navbar-expand navbar-dark bg-dark px-3">
        <Link to={"/tutorials"} className="navbar-brand">
          Radore
        </Link>
        <div className="navbar-nav mr-auto">
          <li className="nav-item">
            <Link to={"/tutorials"} className="nav-link">
              Tutorial Listesi
            </Link>
          </li>
          <li className="nav-item">
            <Link to={"/ekle"} className="nav-link">
              Tutorial Ekle
            </Link>
          </li>
        </div>
      </nav>
      <div className="container mt-5">
        <Routes>
          <Route path="/" element={<TutorialList />} />
          <Route path="/tutorials" element={<TutorialList />} />
          <Route path="/tutorials/:id" element={<TutorialDetail />} />
          <Route path="/ekle" element={<AddTutorial />} />
        </Routes>
      </div>
    </div>
  );
}

export default App;
