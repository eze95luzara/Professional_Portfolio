import axios from "axios"

const URL = "http://localhost:3001/reservas"

const getAll = async(filter) => {
    let url = URL
    if (filter && filter.fechaDesde && filter.fechaHasta)
        {url += `?fechaDesde=${filter.fechaDesde}&fechaHasta=${filter.fechaHasta}`}
    
    const res = await axios.get(url)
    return res
}

const getNombresEstadios = async() => {
    const url = "http://localhost:3001/estadios"
    const res = await axios.get(url)
    const datos = res.data
    return datos.map(e => {
        return (
            {
                nombre: e.nombre,
                estadio_id: e.estadio_id
            }
        )
    })

}

const save = async(data) => {
    let res = null
    if (data.reserva_id !== undefined) {
        const url = URL + "/" + data.reserva_id
        res = await axios.put(url, data)
    } else {
        res = await axios.post(URL, data)
    }
    return res
}

const remove = async(id) => {
    const url = URL + "/" + id
    const res = await axios.delete(url)
    return res
}

export const servicesReserva = {remove, getAll, save, getNombresEstadios}