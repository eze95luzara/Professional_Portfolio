import React from "react"
import {useForm} from "react-hook-form"
import "../styles.css"

export default function Registro({onSubmit, item, onVolver, equipos}) {

    const {register, handleSubmit, formState:{errors}} = useForm({values:item})
    
    const onClickVolver = () => {
        onVolver()
    }

    return <>
    
    <div className="container_app">
        <div className="card">
            <h6 className="card-header">{(item.entrenador_id)?"Actualizar entrenador":"Nuevo entrenador"}</h6>
            <div className="card-body">
                <form className="form" onSubmit={handleSubmit(onSubmit)}>
                    <div className="form-group">
                        <label htmlFor="nombre">Nombre:</label>
                        <input type="text" id="nombre" className="form-control" {...register("nombre", {required:"Campo obligatorio"})} />
                        {errors.nombre && <span className="error">{errors.nombre.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="experiencia">Experiencia:</label>
                        <input type="text" id="experiencia" className="form-control" {...register("experiencia", {required:"Campo obligatorio"})} />
                        {errors.experiencia && <span className="error">{errors.experiencia.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="fechaNacimiento">Fecha Nacimiento:</label>
                        <input type="date" id="fechaNacimiento" className="form-control" {...register("fechaNacimiento", {required:"Campo obligatorio"})} />
                        {errors.fechaNacimiento && <span className="error">{errors.fechaNacimiento.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="equipo_id">Equipo:</label>
                        <select className="form-control" id="equipo_id" {...register("equipo_id", {required:"Campo obligatorio"})}>
                            {equipos.map((e) => {
                                return (
                                    <option value={e.equipo_id} key={e.equipo_id}>{e.nombre}</option>
                                )
                            })}
                        </select>
                        {errors.equipo_id && <span className="error">{errors.equipo_id.message}</span>}
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
    </>

}