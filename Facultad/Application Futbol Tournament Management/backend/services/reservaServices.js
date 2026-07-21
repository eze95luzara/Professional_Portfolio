const { Op, Sequelize } = require("sequelize")
const {Reserva} = require("../tablas/reserva")
const { Estadio } = require("../tablas/estadio")

//Función que permite obtener todas las reservas
async function getAllReservas(filters) {
    const whereQuery = {}
    if (filters) {
        if (filters.fechaDesde && filters.fechaHasta) {
            whereQuery.fechaReserva = {[Op.between]: [filters.fechaDesde, filters.fechaHasta]}
        }
    }

    const reservas = await Reserva.findAll({
        where: whereQuery,
        attributes: [
            "reserva_id",
            "hora",
            "fechaReserva",
            "estadio_id",
            "eliminado"
        ],
        order: [["fechaReserva", "ASC"]],
        include: [{
            model: Estadio, 
            required: true, 
            attributes: ['nombre'],
            where: { id: Sequelize.col('Reserva.estadio_id')}
        }]
    })
    
    return reservas.map(e => {
        return {
            reserva_id: e.dataValues.reserva_id,
            hora: e.dataValues.hora,
            fechaReserva: e.dataValues.fechaReserva,
            estadio_id: e.dataValues.estadio_id,
            estadioNombre: e.dataValues.Estadio.nombre,
            eliminado: e.dataValues.eliminado
        }
    })
}

//Función que permite obtener una reserva por id
async function getByIdReserva(id) {
    const reserva = await Reserva.findOne({
        where: {
            reserva_id : id
        }
    })
    return reserva
}

//Función que permite registrar una reserva
async function postReserva(hora, fechaReserva, estadio_id) {
    const nuevaReserva = await Reserva.create({
        hora: hora,
        fechaReserva: fechaReserva,
        estadio_id: estadio_id
    })

    return nuevaReserva
}

//Función que permite modificar una reserva mediante su id
async function putReserva(id, {hora, fechaReserva, estadio_id}) {
    try {
        const reserva = await Reserva.findOne({
            where: {
                reserva_id: id
            }
        })

        if (reserva) {
            reserva.hora = hora,
            reserva.fechaReserva = fechaReserva,
            reserva.estadio_id = estadio_id
            
            await reserva.save()
            return reserva
        }
        return null

    } catch (error) {
        console.error("Error al actualizar reserva: ", error)
        throw error
    }
}

//Función que permite borrar una reserva mediante su id
async function deleteReserva(id) {
    const reserva = await Reserva.findOne({
        where: {
            reserva_id: id,
            eliminado: false
        }
    })

    if (reserva) {
        const actReserva = await Reserva.update(
            {
                eliminado: true
            },
            {
                where: {reserva_id: id}
            }
        )
        return actReserva
    }   
    return null   
}

module.exports = {getAllReservas, getByIdReserva, postReserva, putReserva, deleteReserva}