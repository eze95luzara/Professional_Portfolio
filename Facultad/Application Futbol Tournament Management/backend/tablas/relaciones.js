const { Equipos } = require("./equipo")
const { Jugadores } = require("./jugador")
const { Estadisticas } = require("./Estadistica")
const { Partidos } = require("./Partido")
const { Entrenador } = require("./entrenador")
const { SesionEntrenamiento } = require("./sesionEntrenamiento")
const { Reserva } = require("./reserva")
const { Estadio } = require("./estadio")

Equipos.hasMany(Jugadores, { foreignKey: 'equipo_id', onDelete: "CASCADE" })
Estadisticas.belongsTo(Partidos, {foreignKey: 'partido_id'})
Estadisticas.belongsTo(Jugadores, {foreignKey: 'jugador_id'})
Jugadores.belongsTo(Equipos, { foreignKey: 'equipo_id'});
Jugadores.hasOne(Estadisticas, { foreignKey: 'jugador_id', onDelete: "CASCADE" })
Partidos.hasOne(Estadisticas, { foreignKey: 'partido_id', onDelete: "CASCADE" })
Entrenador.belongsTo(Equipos, {foreignKey: "equipo_id"})
Equipos.hasOne(Entrenador, {foreignKey: "equipo_id", onDelete: "CASCADE"})
SesionEntrenamiento.belongsTo(Entrenador, {foreignKey: "entrenador_id"})
Entrenador.hasOne(SesionEntrenamiento, {foreignKey: "entrenador_id", onDelete: "CASCADE"})
Reserva.belongsTo(Estadio, {foreignKey: "estadio_id"})
Estadio.belongsTo(Equipos, {foreignKey: "equipo_id"} )
Equipos.hasOne(Estadio, {foreignKey: "equipo_id"})
Partidos.belongsTo(Equipos, { as: 'local', foreignKey: 'equipo_local' });
Partidos.belongsTo(Equipos, { as: 'visitante', foreignKey: 'equipo_visitante' });
Equipos.hasMany(Partidos, { foreignKey: 'equipo_id', onDelete: "CASCADE" })



module.exports = {Equipos, Jugadores, Estadisticas, Partidos, Entrenador, SesionEntrenamiento, Estadio, Reserva}