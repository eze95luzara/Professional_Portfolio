const {SesionEntrenamiento} = require("../tablas/sesionEntrenamiento")
const {Entrenador} = require("../tablas/entrenador")
const {Op, Sequelize} = require("sequelize")

//Función que permite obtener todas las sesiones de entrenamiento
async function getAllSesionEntrenamiento(filters){
    const whereQuery = {}
    if(filters){
        if(filters.fechaDesde && filters.fechaHasta){
            whereQuery.fecha = {[Op.between]: [filters.fechaDesde, filters.fechaHasta]}
        }
    }
    const resultado = await SesionEntrenamiento.findAll({
        where: whereQuery,
        attributes: [
            "sesionEntrenamiento_id",
            "fecha",
            "duracion",
            "eliminado",
            "entrenador_id"
        ],
        order: [["fecha", "ASC"]],
        include: [{
            model: Entrenador,
            required: true,
            attributes: ["nombre"],
            where: {id: Sequelize.col("SesionEntrenamiento.entrenador_id")}
        }]
    });
    return resultado.map(p =>{
        return{
            sesionEntrenamiento_id: p.dataValues.sesionEntrenamiento_id,
            fecha: p.dataValues.fecha,
            duracion: p.dataValues.duracion,
            eliminado: p.dataValues.eliminado,
            entrenador_id: p.dataValues.entrenador_id,
            entrenadorNombre: p.dataValues.Entrenador.nombre
        }
    });
}

//Función que permite obtener una sesión de entrenamiento por identificador
async function getByIdSesionEntrenamiento(id) {
    const sesionEncontrada = await SesionEntrenamiento.findOne({
        where: {
            sesionEntrenamiento_id: id
        }
    })

    return sesionEncontrada
}

//Función que permite registrar una sesión de entrenamiento
async function postSesionEntrenamiento(fecha, duracion, entrenador_id) {
    const nuevaSesion = await SesionEntrenamiento.create({
    fecha: fecha,
    duracion: duracion,
    entrenador_id: entrenador_id
    })

    return nuevaSesion
}

//Función que permite modificar una sesión de entrenamiento identificada con su id
async function putSesionEntrenamiento(id, {fecha, duracion, entrenador_id}) {
    const sesionEnc = await SesionEntrenamiento.findOne({
        where : {
            sesionEntrenamiento_id : id
        }
    })

    if (sesionEnc != undefined) {
        sesionEnc.fecha = fecha, 
        sesionEnc.duracion = duracion, 
        sesionEnc.entrenador_id = entrenador_id
    }
    await sesionEnc.save()
    return sesionEnc
}

//Función que permite eliminar una sesión de entrenamiento 
async function deleteSesionEntrenamiento(id) {
    const eliminar = await SesionEntrenamiento.findOne({
        where: {
            sesionEntrenamiento_id: id
        }
    })

    const updateSesion = await SesionEntrenamiento.update(
        {
            eliminado: true
        },
        {
            where: {sesionEntrenamiento_id: id}
        })
        return {updateSesion}
}

module.exports = {getAllSesionEntrenamiento, getByIdSesionEntrenamiento, postSesionEntrenamiento, putSesionEntrenamiento, deleteSesionEntrenamiento}
