const {DataTypes, Model} = require("sequelize")
const {sequelize} = require("../data/dbInit")

class SesionEntrenamiento extends Model {}

SesionEntrenamiento.init({
    sesionEntrenamiento_id: {
        type: DataTypes.INTEGER,
        autoIncrement: true,
        primaryKey: true, 
        allowNull: false
    },
    fecha: {
      type: DataTypes.DATEONLY,
      allowNull: false  
    },
    duracion: {
        type: DataTypes.INTEGER,
        allowNull: false
    },
    entrenador_id: {
        type: DataTypes.INTEGER,
        references: {
            model: "Entrenador",
            key: "entrenador_id"
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
    modelName: "SesionEntrenamiento",
    tableName: "sesionEntrenamiento"
})


module.exports = {SesionEntrenamiento}