import {useState, useEffect} from "react"
import servicesEstadistica from "../../services/servicesEstadistica/services.estadistica"
import servicesJugador from "../../services/servicesJugador/services.jug"
import servicesPartido from "../../services/servicesPartido/services.partido"
import Tabla from "./Tabla"
import Registro from "./Registro"
import "../styles.css"
import Filtro from "./Filtro"

export default function Estadisticas() {

    const [action, setAction] = useState("T") 
    const [rows, setRows] = useState([])
    const [item, setItem] = useState({})
    const [jugadores, setJugadores] = useState([])
    const [partidos, setPartidos] = useState([])

    
    useEffect(() => {
        loadData()
    }, [])

    const loadData = async(filter) => {
        const res = await servicesEstadistica.getAll(filter)
        setRows(res.data)
    }

    const onJugadores = async() => {
        const res = await servicesJugador.getNombresJugadores()
        setJugadores(res)
    }

    const onPartidos = async() => {
        const res = await servicesPartido.getFechasPartidos()
        setPartidos(res)
    }


    const onSubmit = async(data) => {
        await servicesEstadistica.save(data)
        await loadData()
        setAction("T")
    }

    const onRegistro = () => {
        onPartidos()
        onJugadores()
        setAction("R")
    }

    const onEliminar = async(id) => {
        await servicesEstadistica.remove(id)
        await loadData()
    }

    const onActualizar = async(item) => {
        onPartidos()
        onJugadores()
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

    return <>
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
                    <Registro onVolver={onVolver} onSubmit={onSubmit} item={item} jugadores={jugadores} partidos={partidos}></Registro>
                )
            }
        </div>
    </>

}