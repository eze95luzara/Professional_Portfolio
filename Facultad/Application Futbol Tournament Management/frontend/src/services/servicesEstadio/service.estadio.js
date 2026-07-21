import axios from "axios"

const URL = "http://localhost:3001/estadios"

const getAll = async(filter) => {
    const url = (filter)?URL+"?nombre="+filter:URL
    const res = await axios.get(url)
    return await res
}

const getNombresEquipos = async() => {
    const url = "http://localhost:3001/equipos"
    const res = await axios.get(url)
    const datos = res.data 
    return datos.map(e => {
        return (
            {
                nombre: e.nombre,
                equipo_id: e.equipo_id
            }
        )
    })
}

const save = async(data) => {
    let res = null
    if (data.estadio_id !== undefined) {
        const url = URL + "/" + data.estadio_id
        res = await axios.put(url, data)
    } else {
        res = await axios.post(URL, data)
    }
    return await res
}

const remove = async(id) => {
    const url = URL + "/" + id
    const res = await axios.delete(url)
    return res
}

export const servicesEstadio = {remove, getAll, save, getNombresEquipos}