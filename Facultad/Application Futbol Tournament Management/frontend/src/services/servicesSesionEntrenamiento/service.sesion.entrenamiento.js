import axios from "axios"
const URL = "http://localhost:3001/sesiones-entrenamiento"

const getAll = async(filter) => {
    let url = URL
    if (filter && filter.fechaDesde && filter.fechaHasta)
        {url += `?fechaDesde=${filter.fechaDesde}&fechaHasta=${filter.fechaHasta}`}
    
    const res = await axios.get(url)
    return res
}

const save = async(data) => {
    let res = null
    
    if (data.sesionEntrenamiento_id !== undefined) {
        const url = URL + "/" + data.sesionEntrenamiento_id
        res = await axios.put(url, data)
    } else {
        res = await axios.post(URL, data)
        
    }

    return res
}

const remove = async(id) => {
    const URLNueva = URL + "/" + id
    const res = await axios.delete(URLNueva)

    return res
}

export default {getAll, save, remove}