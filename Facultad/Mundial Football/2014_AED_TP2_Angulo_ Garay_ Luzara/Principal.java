/**
 * Clase que contiene el método main
 * 
 * @author Ing. Marcela Tartabini 
 * @version 2014
 */
public class Principal
{
    private static String LINEA_SIMPLE = "-----------------------------------------------------------------------------------";
    private static String LINEA_DOBLE = "===================================================================================";
    
    
    public static void main (String[]args)
    {
        int goles1,goles2;
        
        //Definición de los 4 ganadores de los cuartos de final
        Equipo ganadorc1, ganadorc2, ganadorc3, ganadorc4;        
        ganadorc1 = new Equipo ("Brasil",'A');
        ganadorc2 = new Equipo ("Alemania",'G');
        ganadorc3 = new Equipo ("Holanda",'B');
        ganadorc4 = new Equipo ("Argentina",'F');

        //Definición de los partidos de semifinal
        Partido psemi1, psemi2;
        psemi1 = new Partido (ganadorc1,ganadorc2);
        psemi2 = new Partido (ganadorc3,ganadorc4);        
        
        System.out.println("\tM U N D I A L   B R A S I L   2 0 1 4");                
        System.out.println(LINEA_DOBLE);    
        
        System.out.println("RESULTADOS DE SEMIFINAL");        
        PartidoJugado jsemi1, jsemi2;
        System.out.println("\t" + psemi1);
        System.out.print("\tGoles " + psemi1.getEquipo1() + ": ");
        goles1 = In.readInt();
        System.out.print("\tGoles " + psemi1.getEquipo2() + ": ");
        goles2 = In.readInt();        
        jsemi1 = new PartidoJugado(psemi1,goles1,goles2);
        System.out.println(LINEA_SIMPLE);
        System.out.println("\t" + psemi2);
        System.out.print("\tGoles " + psemi2.getEquipo1() + ": ");
        goles1 = In.readInt();
        System.out.print("\tGoles " + psemi2.getEquipo2() + ": ");
        goles2 = In.readInt();        
        jsemi2 = new PartidoJugado(psemi2,goles1,goles2);
        System.out.println(LINEA_DOBLE);
        
        System.out.println("ÚLTIMA RONDA");
        Partido ptercer, pfinal;
        //Completar
        System.out.println("\tFinal: "+jsemi1.getGanador()+"  vs.  "+jsemi2.getGanador());
        pfinal = new Partido (jsemi1.getGanador() , jsemi2.getGanador());  
        System.out.println("\tTercer puesto: "+jsemi1.getPerdedor()+"  vs.  "+jsemi2.getPerdedor());
        ptercer = new Partido (jsemi1.getPerdedor() , jsemi2.getPerdedor());
        System.out.println(LINEA_DOBLE);
        
        System.out.println("RESULTADOS DE TERCER PUESTO");        
        PartidoJugado jtercer;
        //Completar  
        System.out.println("\t"+ptercer);
        System.out.print("\tGoles  "+jsemi1.getPerdedor()+": ");
        goles1 = In.readInt();
        System.out.print("\tGoles  "+jsemi2.getPerdedor()+": ");
        goles2 = In.readInt(); 
        jtercer = new PartidoJugado ( ptercer,goles1,goles2);
        System.out.println(LINEA_DOBLE);

        System.out.println("RESULTADOS DE FINAL");        
        PartidoJugado jfinal;
        //Completar
        System.out.println("\t"+pfinal);
        System.out.print("\tGoles  "+jsemi1.getGanador()+": ");
        goles1 = In.readInt();
        System.out.print("\tGoles  "+jsemi2.getGanador()+": ");
        goles2 = In.readInt();
        jfinal = new PartidoJugado ( pfinal,goles1,goles2);
        System.out.println(LINEA_DOBLE);
        
        System.out.println("PODIO");        
        //Completar
        System.out.println("\tCAMPEON "+jfinal.getGanador().getPais().toUpperCase());
        System.out.println("\t2º "+jfinal.getPerdedor());
        System.out.println("\t3º "+jtercer.getGanador());
        System.out.println("\t4º "+jtercer.getPerdedor());
        System.out.println(LINEA_DOBLE);
    }
}
