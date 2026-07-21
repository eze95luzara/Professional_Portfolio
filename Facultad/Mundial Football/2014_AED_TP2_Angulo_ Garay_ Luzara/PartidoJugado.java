/**
 * Clase que representa un partido ya jugado del Mundial de Fútbol
 * 
 * @author Ing. Marcela Tartabini    
 * @version 2014
 */
public class PartidoJugado extends Partido
{
    private int goles1;
    private int goles2;
    
    /**
     * Constructor para objetos de la clase PartidoJugado
     * @param  eq1 equipo 1
     * @param  eq2 equipo 2
     * @param  goles1 goles anotados por el equipo 1
     * @param  goles2 goles anotados por el equipo 2
     */
    public PartidoJugado(Equipo eq1, Equipo eq2,int goles1, int goles2)
    {
        super(eq1 , eq2);
        this.goles1=goles1;
        this.goles2=goles2;
    }

    /**
     * Constructor para objetos de la clase PartidoJugado
     * @param  p datos del partido antes de jugarse
     * @param  goles1 goles anotados por el equipo 1
     * @param  goles2 goles anotados por el equipo 2
     */
    public PartidoJugado(Partido p,int goles1, int goles2)
    {
        super(p);
        this.goles1=goles1;
        this.goles2=goles2;
    }
    
    /**
     * Método para obtener al equipo ganador del partido
     * 
     * @return  equipo ganador
     */
    public Equipo getGanador()
    {
        Equipo ganador=null;
        if (goles1>goles2) {
            ganador=equipo1;
        }
        else {
            ganador=equipo2;
        }
        return ganador;
    }

    /**
     * Método para obtener al equipo perdedor del partido
     * 
     * @return  equipo perdedor
     */
    public Equipo getPerdedor()
    {
        Equipo perdedor=null;
        if (goles1>goles2){
            perdedor=equipo2;
        }
        else {
            perdedor=equipo1;
        }
        return perdedor;
    }
}
