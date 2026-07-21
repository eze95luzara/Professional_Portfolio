/**
 * Clase que representa la selección de fútbol de un país.
 * 
 * @author Ing. Marcela Tartabini    
 * @version 2014
 */

public class Equipo
{
    private String pais;
    private char grupo;

    /**
     * Constructor con parámetros de la clase Equipo
     */
    public Equipo(String pais, char grupo)
    {
        this.pais=pais;
        this.grupo=grupo;
    }

    /**
     * Constructor copia de la clase Equipo
     */
    public Equipo(Equipo eq)
    {
        pais=eq.getPais();
        grupo=eq.getGrupo();
    }

    /**
     * Método para obtener el atributo
     * @return     valor del atributo 
     */
    public String getPais()
    {
        return pais;
    }
    
    /**
     * Método para obtener el atributo
     * @return     valor del atributo 
     */
    public char getGrupo()
    {
        return grupo;
    }    

    /**
     * Método para mostrar el objeto en modo texto
     * @return     texto descriptivo 
     */
    public String toString()
    {
       return pais + " ("+grupo+")";
    }    
}