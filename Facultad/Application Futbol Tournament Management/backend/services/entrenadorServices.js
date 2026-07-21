const { Op, Sequelize } = require("sequelize");
const {Entrenador} = require("../tablas/entrenador");
const {Equipos} = require("../tablas/equipo")

//Función que permite obtener todos los entrenadores
async function getAllEntrenador(filters){
    const whereQuery = {}
    if(filters){
        if(filters.nombre){
            whereQuery.nombre = {[Op.like]: `%${filters.nombre}%`}
        }
    }
    const resultado = await Entrenador.findAll({
        where: whereQuery,
        attributes: [
            "entrenador_id",
            "nombre",
            "experiencia",
            "fechaNacimiento",
            "equipo_id",
            "eliminado"
        ],
        order: [["nombre", "ASC"]],
        include: [{
            model: Equipos,
            required: true,
            attributes: ['nombre'], 
            where: { id: Sequelize.col('Entrenador.equipo_id')}
        }]
    });
    return resultado.map(p =>{
        return{
            entrenador_id: p.dataValues.entrenador_id,
            nombre: p.dataValues.nombre,
            experiencia: p.dataValues.experiencia,
            fechaNacimiento: p.dataValues.fechaNacimiento,
            eliminado: p.dataValues.eliminado,
            equipo_id: p.dataValues.equipo_id,
            equipoNombre: p.dataValues.Equipo.nombre
        }
    });
}

//Función que permite obtener un entrenador por identificador
async function getByIdEntrenador(id) {
    const entrenadorEncontrado = await Entrenador.findOne({
        where: {
            entrenador_id : id
        }
    })
    return entrenadorEncontrado
}

//Función que permite registrar un entrenador
async function postEntrenador(nombre, experiencia, fechaNacimiento, equipo_id) {
    const nuevoEntrenador = await Entrenador.create({
        nombre: nombre,
        experiencia: experiencia,
        fechaNacimiento: fechaNacimiento,
        equipo_id: equipo_id
    })
    return nuevoEntrenador
}

//Función que permite modificar un entrenador identificado por su id
async function putEntrenador(id, {nombre, experiencia, fechaNacimiento, equipo_id}) {
    const enc = await Entrenador.findOne({
        where : {
            entrenador_id: id
        }
    })

    if (enc != undefined) {
        enc.nombre = nombre,
        enc.experiencia = experiencia,
        enc.fechaNacimiento = fechaNacimiento,
        enc.equipo_id = equipo_id
    } 
    await enc.save()
    return enc }

//Función que permite borrar un entrenador
async function deleteEntrenador(id) {
    const eliminar = await Entrenador.findOne({
        where: {
            entrenador_id: id,
            eliminado: false
        }
    })

    const updateEntrenador = await Entrenador.update(
        {
            eliminado: true
        },
        {
            where: {entrenador_id: id}
        })

    return {updateEntrenador} 
}

module.exports = {getAllEntrenador, getByIdEntrenador, postEntrenador, putEntrenador, deleteEntrenador}