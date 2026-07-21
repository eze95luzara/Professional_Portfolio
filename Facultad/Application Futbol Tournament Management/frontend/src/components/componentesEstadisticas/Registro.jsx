import React from "react"
import {useForm} from "react-hook-form"
import "../styles.css"

export default function Registro({onSubmit, item, onVolver, jugadores, partidos}) {

    const {register, handleSubmit, formState:{errors}} = useForm({values:item})
    
    const onClickVolver = () => {
        onVolver()
    }

    return <>
    
    <div className="container_app">
        <div className="card">
            <h6 className="card-header">{(item.estadistica_id)?"Actualizar estadística":"Nueva estadística"}</h6>
            <div className="card-body">
                <form className="form" onSubmit={handleSubmit(onSubmit)}>
                    <div className="form-group">
                        <label htmlFor="cant_goles">Cantidad de goles:</label>
                        <input type="number" id="cant_goles" className="form-control" {...register("cant_goles", {required:"Campo obligatorio"})} />
                        {errors.cant_goles && <span className="error">{errors.cant_goles.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="cant_asistencias">Cantidad de asistencias:</label>
                        <input type="number" id="cant_asistencias" className="form-control" {...register("cant_asistencias", {required:"Campo obligatorio"})} />
                        {errors.cant_asistencias && <span className="error">{errors.cant_asistencias.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="jugador_id">Jugador:</label>
                        <select className="form-control" id="jugador_id" {...register("jugador_id", {required:"Campo obligatorio"})}>
                            {jugadores.map((e) => {
                                return (
                                    <option value={e.jugador_id} key={e.jugador_id}>{e.nombre}</option>
                                )
                            })}
                        </select>
                        {errors.jugador_id && <span className="error">{errors.jugador_id.message}</span>}
                    </div>
                    <div className="form-group">
                        <label htmlFor="partido_id">Partido:</label>
                        <select className="form-control" id="partido_id" {...register("partido_id", {required:"Campo obligatorio"})}>
                            {partidos.map((e) => {
                                return (
                                    <option value={e.partido_id} key={e.partido_id}>{e.fecha}</option>
                                )
                            })}
                        </select>
                        {errors.partido_id && <span className="error">{errors.partido_id.message}</span>}
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