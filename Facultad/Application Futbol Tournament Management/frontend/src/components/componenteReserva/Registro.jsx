import React from "react"
import {useForm} from "react-hook-form"
import "../styles.css"

export default function Registro({onSubmit, item, onVolver, estadios}) {

    const {register, handleSubmit, formState:{errors}} = useForm({values:item})
    
    const onClickVolver = () => {
        onVolver()
    }

    return(     
        <div className="container_app">
            <div className="card">
                <h6 className="card-header">{(item.reserva_id)?"Actualizar reserva":"Nueva reserva"}</h6>
                <div className="card-body">
                    <form className="form" onSubmit={handleSubmit(onSubmit)}>
                        <div className="form-group">
                            <label htmlFor="hora">Hora:</label>
                            <input type="time" id="hora" className="form-control" {...register("hora", {required:"Campo obligatorio"})} />
                            {errors.hora && <span className="error">{errors.hora.message}</span>}
                        </div>
                        
                        <div className="form-group">
                            <label htmlFor="fechaReserva">Fecha de reserva:</label>
                            <input type="date" id="fechaReserva" className="form-control" 
                                   {...register("fechaReserva", {required:"Campo obligatorio"})} />
                            {errors.fechaReserva && <span className="error">{errors.fechaReserva.message}</span>}
                        </div>
                        
                        <div className="form-group">
                            <label htmlFor="estadio_id">Estadio:</label>
                            <select className="form-control" id="estadio_id" {...register("estadio_id", {required:"Campo obligatorio"})}>
                                {estadios.map(e => {
                                    return (
                                        <option value={e.estadio_id} key={e.estadio_id}>{e.nombre}</option>
                                    )
                                })}    
                            </select>
                            {errors.estadio_id && <span className="error">{errors.estadio_id.message}</span>}
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