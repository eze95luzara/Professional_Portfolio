/**
 * Clase que representa un partido aún no jugado del Mundial de Fútbol
 * 
 * @author Ing. Marcela Tartabini    
 * @version 2014
 */
public class Partido
{
    protected Equipo equipo1;
    protected Equipo equipo2;
    
    /**
     * Constructor para objetos de la clase Partido*/
    public Partido(Equipo eq1, Equipo eq2)
    {
       equipo1=eq1;
       equipo2=eq2;
    }

    /**
     * Constructor copia de la clase Partido
     */
    public Partido(Partido p)
    {
        equipo1=p.getEquipo1();
        equipo2=p.getEquipo2();
    }
    
    /**
     * Método para obtener el atributo
     * @return     valor del atributo 
     */
    public Equipo getEquipo1()
    {
        return equipo1;
    }

    /**
     * Método para obtener el atributo
     * @return     valor del atributo 
     */
    public Equipo getEquipo2()
    {
        return equipo2;
    }

    /**
     * Método para mostrar el objeto en modo texto
     * @return     texto descriptivo 
     */
    public String toString()
    {
        return equipo1+"  vs.  "+equipo2;
    }
}
