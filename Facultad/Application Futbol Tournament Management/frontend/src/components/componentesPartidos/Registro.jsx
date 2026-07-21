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
            <h6 className="card-header">{(item.partido_id)?"Actualizar partido":"Nuevo partido"}</h6>
            <div className="card-body">
                <form className="form" onSubmit={handleSubmit(onSubmit)}>
                    <div className="form-group">
                        <label htmlFor="fecha">Fecha:</label>
                        <input type="date" id="fecha" className="form-control" {...register("fecha", {required:"Campo obligatorio"})} />
                        {errors.fecha && <span className="error">{errors.fecha.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="resultado">Resultado:</label>
                        <input type="text" id="resultado" className="form-control" {...register("resultado", {required:"Campo obligatorio"})} />
                        {errors.resultado && <span className="error">{errors.resultado.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="equipo_local">Equipo local:</label>
                        <select className="form-control" id="equipo_local" {...register("equipo_local", {required:"Campo obligatorio"})}>
                            {equipos.map((e) => {
                                return (
                                    <option value={e.equipo_id} key={e.equipo_id}>{e.nombre}</option>
                                )
                            })}
                        </select>
                        {errors.equipo_id && <span className="error">{errors.equipo_id.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="equipo_visitante">Equipo visitante:</label>
                        <select className="form-control" id="equipo_visitante" {...register("equipo_visitante", {required:"Campo obligatorio"})}>
                            {equipos.map((e) => {
                                return (
                                    <option value={e.equipo_id} key={e.equipo_id}>{e.nombre}</option>
                                )
                            })}
                        </select>
                        {errors.equipo_visitante && <span className="error">{errors.equipo_visitante.message}</span>}
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