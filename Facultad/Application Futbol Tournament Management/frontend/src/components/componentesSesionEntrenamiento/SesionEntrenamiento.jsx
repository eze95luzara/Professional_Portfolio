import { useState, useEffect } from "react";
import servicesSesionEntrenamiento from "../../services/servicesSesionEntrenamiento/service.sesion.entrenamiento"
import servicesEntrenador from "../../services/servicesEntrenador/service.entrenador";
import Tabla from "./Tabla";
import Registro from "./Registro";
import Filtro from "./Filtro"
import "../styles.css"

export default function SesionEntrenamiento() {
    const [action, setAction] = useState("T")
    const [rows, setRows] = useState([])
    const [item, setItem] = useState({})
    const [entrenadores, setEntrenadores] = useState([])

    useEffect(() =>{
        loadData()
    }, [])

    const loadData = async(filter) => {
        const res = await servicesSesionEntrenamiento.getAll(filter)
        setRows(res.data)
    }

    const onSubmit = async(data) => {
        await servicesSesionEntrenamiento.save(data)
        await loadData()
        setAction("T")
    }

    const onRegistro = () => {
        onEntrenadores()
        setAction("R")
    }

    const onEliminar = async(id) => {
        await servicesSesionEntrenamiento.remove(id)
        await loadData()
    }

    const onActualizar = async(item) => {
        onEntrenadores()
        setItem(item)
        loadData()
        setAction("R")
    }

    const onVolver = () => {
        setAction("T")
    }

    const onFiltrar = async(filter) => {
        await loadData(filter)
    }

    const onEntrenadores = async() => {
        const eq = await servicesEntrenador.getNombresEntrenadores()
        setEntrenadores(eq)
    }

    return (
        <>
            <div className="container_app">
                {
                    action === "T" && (
                        <>
                            <Filtro onFiltrar={onFiltrar}></Filtro>
                            <Tabla rows={rows} onRegistro={onRegistro} onEliminar={onEliminar} onActualizar={onActualizar}></Tabla>
                        </>
                    )
                }
                {
                    action !== "T" && (
                        <Registro onVolver={onVolver} onSubmit={onSubmit} item={item} entrenadores={entrenadores}></Registro>
                    )
                }
            </div>
        </>
    )
}