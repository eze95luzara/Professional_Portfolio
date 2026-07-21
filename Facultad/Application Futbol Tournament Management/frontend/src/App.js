import React from "react"
import { BrowserRouter as Router, Routes, Route, Navigate } from "react-router-dom";
import './App.css';
import Menu from "./components/Menu";
import Equipos from "./components/componentesEquipo/Equipos"
import Jugadores from "./components/componentesJugadores/Jugadores"
import Estadios from "./components/componenteEstadio/Estadio"
import Reserva from "./components/componenteReserva/Reserva"
import Estadisticas from "./components/componentesEstadisticas/Estadisticas";
import Partidos from "./components/componentesPartidos/Partidos";
import Entrenadores from "./components/componentesEntrenador/Entrenadores"
import SesionEntrenamiento from "./components/componentesSesionEntrenamiento/SesionEntrenamiento"
import Integrantes from "./components/Integrantes";
import Navbar from "./components/Navbar";


function App() {
  return (
    <div>
      <Router>
        <Navbar/>
        <div>
          <Routes>
            <Route path='/' element={<Menu />} />
            <Route path="/equipos" element={<Equipos />}></Route>
            <Route path="/jugadores" element={<Jugadores />}></Route>
            <Route path="/estadios" element={<Estadios/>}></Route>
            <Route path="/reservas" element={<Reserva/>}></Route>
            <Route path="/estadisticas" element={<Estadisticas />}></Route> 
            <Route path="/partidos" element={<Partidos />}></Route>
            <Route path="/entrenadores" element={<Entrenadores />}></Route>
            <Route path="/sesiones-entrenamiento" element={<SesionEntrenamiento />}></Route>
            <Route path="/integrantes" element={<Integrantes />}></Route>
            <Route path="*" element={<Navigate to="/" replace/>}></Route>
          </Routes>
        </div>
      </Router>
    </div>
  );
}

export default App
