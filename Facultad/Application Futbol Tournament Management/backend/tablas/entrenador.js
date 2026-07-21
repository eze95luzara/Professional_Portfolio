const {DataTypes, Model} = require("sequelize")
const {sequelize} = require("../data/dbInit")

class Entrenador extends Model {}

Entrenador.init({
    entrenador_id: {
        type: DataTypes.INTEGER,
        autoIncrement: true, 
        primaryKey: true,
        allowNull: false
    },
    nombre : {
        type: DataTypes.TEXT,
        allowNull: false
    },
    experiencia: {
        type: DataTypes.INTEGER,
        allowNull: false
    },
    fechaNacimiento: {
        type: DataTypes.DATEONLY,
        allowNull: false
    },
    equipo_id: {
        type: DataTypes.INTEGER,
        references: {
            model: "Equipos",
            key: "equipo_id"
        },
        allowNull: false
    },
    eliminado: {
        type: DataTypes.BOOLEAN,
        allowNull: false,
        defaultValue: false,
        validate: {
            notEmpty: {
                args: true,
                msg: "El estado eliminado es requerido"
            }
        }
    }
}, {
    sequelize,
    modelName: "Entrenador",
    tableName: "entrenador"
})

module.exports = {Entrenador} 