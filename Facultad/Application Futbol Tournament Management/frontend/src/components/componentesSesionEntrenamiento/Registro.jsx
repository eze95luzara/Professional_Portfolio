import React from "react"
import {useForm} from "react-hook-form"
import "../styles.css"

export default function Registro({onSubmit, item, onVolver, entrenadores}) {
    const {register, handleSubmit, formState:{errors}} = useForm({values:item})

    const onClickVolver = () => {
        onVolver()
    }

    return (
        <div className="container_app">
            <div className="card">
                <h6 className="card-header">{(item.sesionEntrenamiento_id)? "Actualizar sesión de entrenamiento": "Nueva sesión de entrenamiento"}</h6>
                <div className="card-body">
                    <form className="form" onSubmit={handleSubmit(onSubmit)}>
                        <div className="form-group">
                            <label htmlFor="fecha">Fecha:</label>
                            <input type="date" id="fecha" className="form-control" {...register("fecha", {required: "Campo obligatorio"})}/>
                            {errors.fecha && <span className="errors">{errors.fecha.message}</span>}
                        </div>
                        <div className="form-group">
                            <label htmlFor="duracion">Duración:</label>
                            <input type="number" id="duracion" className="form-control" {...register("duracion", {required: "Campo obligatorio"})}/>
                            {errors.duracion && <span className="errors">{errors.duracion.message}</span>}
                        </div>
                        <div className="form-group">
                            <label htmlFor="entrenador_id">Entrenador:</label>
                            <select className="form-control" id="entrenador_id" {...register("entrenador_id", {required:"Campo obligatorio"})}>
                                {entrenadores.map((e) => {
                                    return (
                                        <option value={e.entrenador_id} key={e.entrenador_id}>{e.nombre}</option>
                                    )
                                })}
                            </select>
                            {errors.entrenador_id && <span className="error">{errors.entrenador_id.message}</span>}
                        </div>
                        <div>
                            <button className="btn btn-primary mx-1 my-1" type="submit">Guardar</button>
                            <button className="btn btn-secondary mx-1 my-1" onClick={onClickVolver}>Volver</button>
                            <button className="btn btn-secondary mx-1 my-1" type="reset">Limpiar</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}