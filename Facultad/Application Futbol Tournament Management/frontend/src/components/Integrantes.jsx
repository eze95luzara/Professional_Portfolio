import React from 'react';
import { Link } from 'react-router-dom';
import './Integrantes.css';

export default function Integrantes() {
    const integrantes = [
        { nombre: "Agustín", apellido: "Hillar", legajo: "95069" },
        { nombre: "Caterina", apellido: "Alvaretto", legajo: "95028" },
        { nombre: "Matías", apellido: "Moreno", legajo: "95457" },
        { nombre: "Rocío", apellido: "Alves", legajo: "94215" }
    ];

    const tdata = integrantes.map((i, index) => (
        <tr key={index}>
            <td>{i.nombre}</td>
            <td>{i.apellido}</td>
            <td>{i.legajo}</td>
        </tr>
    ));

    return (
        <>
            <div className="card" id='divdiv'>
                <div className="card-header d-flex justify-content-between align-items-center" id='segdiv'>
                    <h6>Integrantes del grupo - 3k07</h6>
                    <div>
                        <Link to="/" className="btn btn-primary">Menu Principal</Link>
                    </div>
                </div>
                <div className="card-body" id='divbody'>
                    <div className="table-container">
                        <table className="table table-striped" id='tabla'>
                            <thead>
                                <tr>
                                    <th>Nombre/s</th>
                                    <th>Apellido</th>
                                    <th>Legajo</th>
                                </tr>
                            </thead>
                            <tbody>
                                {tdata}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </>
    );
}