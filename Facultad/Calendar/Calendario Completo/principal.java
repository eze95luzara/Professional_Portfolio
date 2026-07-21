import java.util.Calendar;

public class principal{

    public static void main (String []args) {
        //inicializamos bariables: m=Meses, b=Bisiesto
        int año, diaSemana, c; 
        int m=1, b=1;
        
        /*Pedimos al usuario que indique el año que quiere ver y calculamos donde cae 
        el pimer dia del comienzo del año*/
        System.out.print("Ingrese año a imprimir: ");
        año = In.readInt();
        Calendar cal = Calendar.getInstance();
        cal.set(Calendar.YEAR,año);
        cal.set(Calendar.MONTH,Calendar.JANUARY);
        cal.set(Calendar.DATE,1);
        diaSemana = cal.get(Calendar.DAY_OF_WEEK);
       
        //mostramos la ubicacion del pimer dia del comienzo del año
        System.out.println("El año comienza en el "+diaSemana+ "° dia de la semana");
        System.out.println("      ");
       
        //proceso del calendario
        while (m<13)
        {

            switch(m)
            {   case 1:

                System.out.println("======[ENERO]=======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }

                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }

                break;

                case 2:
                cal.set(Calendar.MONTH,Calendar.FEBRUARY);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("=====[FEBRERO]======");
                System.out.println(" D  L  M  M  J  V  S");
                if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                {
                    b=30;
                }
                else
                {
                    b=29;   
                }

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }

                for (int dia=1; dia<b; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }

                break;
                case 3:
                cal.set(Calendar.MONTH,Calendar.MARCH);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);
                System.out.println("======[MARZO]=======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }

                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }

                break;

                case 4: 
                cal.set(Calendar.MONTH,Calendar.APRIL);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("======[ABRIL]=======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<31; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;

                case 5:
                cal.set(Calendar.MONTH,Calendar.MAY);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("=======[MAYO]=======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;

                case 6:
                cal.set(Calendar.MONTH,Calendar.JUNE);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("======[JUNIO]=======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<31; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
               
                case 7:
                cal.set(Calendar.MONTH,Calendar.JULY);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("======[JULIO]=======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
                
                case 8:
                cal.set(Calendar.MONTH,Calendar.AUGUST);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("======[AGOSTO]======");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
            
                case 9:
                cal.set(Calendar.MONTH,Calendar.SEPTEMBER);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("====[SEPTIEMBRE]====");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<31; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
                
                case 10:
                cal.set(Calendar.MONTH,Calendar.OCTOBER);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("======[OCTUBRE]=====");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
                
                case 11:
                cal.set(Calendar.MONTH,Calendar.NOVEMBER);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("=====[NOVIEMBRE]====");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<31; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
                case 12:
                cal.set(Calendar.MONTH,Calendar.DECEMBER);
                cal.set(Calendar.DATE,1);
                diaSemana = cal.get(Calendar.DAY_OF_WEEK);

                System.out.println("=====[DICIEMBRE]====");
                System.out.println(" D  L  M  M  J  V  S");

                for (c=1; c<diaSemana;c++){
                    System.out.print("   ");

                }
                for (int dia=1; dia<32; dia++) { 

                    if (c%7==0){

                        if(dia<10)
                        {
                            System.out.println(" " +dia+ " ");
                        }
                        else 
                        {
                            System.out.println(dia+ " ");   
                        }
                        c++;
                    }
                    else {

                        if(dia<10)
                        {
                            System.out.print(" " +dia+ " ");
                        }
                        else
                        {
                            System.out.print(dia+ " ");   
                        }
                        c++;
                    }

                }
                break;
            }
             
            System.out.println();
            m++;
        }        
        //termina el proceso 
        //ESTA PARA UN 10 EL TRABAJO JAJAJA; ESPERO QUE LE GUSTE :)
    }
}
