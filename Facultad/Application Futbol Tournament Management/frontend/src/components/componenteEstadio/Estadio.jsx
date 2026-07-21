import {useState, useEffect} from "react"
import {servicesEstadio} from "../../services/servicesEstadio/service.estadio"
import Tabla from "./Tabla"
import Registro from "./Registro"
import Filtro from "./Filtro"
import "../styles.css"


export default function Estadio() {

    const [action, setAction] = useState("T") 
    const [rows, setRows] = useState([])
    const [item, setItem] = useState({})
    const [equipos, setEquipos] = useState({})

    useEffect(() => {
        loadData()
    }, [])

    const loadData = async(filter) => {
        const res = await servicesEstadio.getAll(filter)
        setRows(res.data)
    }

    const onSubmit = async(data) => {
        await servicesEstadio.save(data)
        await loadData()
        setAction("T")
    }

    const onRegistro = async () => {
        await onEquipos()
        setAction("R")
    }

    const onEliminar = async(id) => {
        await servicesEstadio.remove(id)
        await loadData()
    }

    const onActualizar = async(item) => {
        await onEquipos()
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

    const onEquipos = async () => {
        const equipos = await servicesEstadio.getNombresEquipos()
        setEquipos(equipos)
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