import { Link } from "react-router-dom";

export default function Tabla(props) {
    const onClickEliminar = async(id) => {
        if (window.confirm("Desea eliminar la sesión de entrenamiento?"))
            props.onEliminar(id)
    }

    const onActualizarClick = async(item) => {
        props.onActualizar(item)
    }

    const tdata = props.rows.map((e) => {
        return (
            <tr key={e.sesionEntrenamiento_id}>
                <td>{e.sesionEntrenamiento_id}</td>
                <td>{e.fecha}</td>
                <td>{e.duracion}</td>
                <td>{e.entrenadorNombre}</td>
                <td>
                    <button className="btn btn-danger" disabled={e.eliminado === true} onClick={() => {onClickEliminar(e.sesionEntrenamiento_id)}}>Eliminar</button>
                </td>
                <td>
                    <button className="btn btn-warning" disabled={e.eliminado === true} onClick={() => { onActualizarClick(e) }}>Actualizar</button>
                </td>
            </tr>
        )
    })

    return (
        <>
            <div className="card">
                <div className="card-header d-flex justify-content-between align-items-center">
                    <h6>Sesiones de Entrenamiento</h6>
                    <div>
                        <button className="btn btn-success me-2" onClick={props.onRegistro}>Nueva sesión de entrenamiento</button>
                        <Link to="/" className="btn btn-primary">Menu Principal</Link>
                    </div>
                </div>
                <div className="card-body">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>ID sesión</th>
                                <th>Fecha</th>
                                <th>Duración</th>
                                <th>Entrenador</th>
                                <th>Eliminar</th>
                                <th>Actualizar</th>
                            </tr>
                        </thead>
                        <tbody>
                            {tdata}
                        </tbody>
                    </table>
                </div>
            </div>
        </>
    );
}