import axios from "axios"

const URL = "http://localhost:3001/estadisticas"


const getAll = async(filter) => {

    const url = (filter)?URL+"?partido_id="+filter:URL
    const res = await axios.get(url)
    return res
}

const save = async(data) => {

    let res = null
    
    if (data.estadistica_id !== undefined) {
        const url = URL + "/" + data.estadistica_id
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

// eslint-disable-next-line import/no-anonymous-default-export
export default {remove, getAll, save}