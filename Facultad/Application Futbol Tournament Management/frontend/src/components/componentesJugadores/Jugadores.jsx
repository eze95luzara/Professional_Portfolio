import {useEffect, useState} from "react"
import servicesJugador from "../../services/servicesJugador/services.jug"
import servicesEquipo from "../../services/servicesEquipo/services.equipo"
import Tabla from "./Tabla"
import Registro from "./Registro"
import "../styles.css"
import Filtro from "./Filtro"

export default function Jugadores() {

    const [action, setAction] = useState("T") 
    const [rows, setRows] = useState([])
    const [item, setItem] = useState({})
    const [equipos, setEquipos] = useState([])

    useEffect(() => {
        loadData()
    }, [])

    const loadData = async (filter = "") => {
        const res = await servicesJugador.getAll(filter);
        setRows(res.data);
    };
    const onSubmit = async(data) => {
        await servicesJugador.save(data)
        await loadData()
        setAction("T")
    }

    const onRegistro = () => {
        onEquipos()
        setAction("R")
    }

    const onEliminar = async(id) => {
        await servicesJugador.remove(id)
        await loadData()
    }

    const onActualizar = async(item) => {
        onEquipos()
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

    const onEquipos = async() => {
        const eq = await servicesEquipo.getNombresEquipos()
        setEquipos(eq)
        
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
                    <Registro onVolver={onVolver} onSubmit={onSubmit} item={item} equipos={equipos}></Registro>
                )
            }
        </div>
    </>

}