package modelo;

/** 
 * Prueba de la clase Arreglo.
 * @author Ing. Valerio Frittelli.
 * @version Agosto 2004.
 */
public class Prueba
{
    private static Arreglo v;
    private static int n, op;
    private static long t1, t2, tf;
    
    /**
     *  Punto de entrada de la aplicacion
     */
    public static void main (String[] args)
    {
    	
    	v = new Arreglo (0);
    	do
    	{
    	    System.out.println ("\nOpciones de Ordenamiento");
    	    System.out.println ("0. Generar el Arreglo");
    	    System.out.println ("1. Intercambio Directo (Burbuja)");
    	    System.out.println ("2. Seleccion Directa");
    	    System.out.println ("3. Insercion Directa");
    	    System.out.println ("4. Quick Sort");
    	    System.out.println ("5. Heap Sort");
    	    System.out.println ("6. Shell Sort");
    	    System.out.println ("7. Merge Sort");    	    
    	    System.out.println ("8. Verificar si esta ordenado");
    	    System.out.println ("9. Salir");
    	    System.out.print ("Ingrese opcion: ");
    	    op = Consola.readInt ();
    	    switch (op)
    	    {
    		case 0:  
    		         System.out.print("Se vuelve a generar el vector...");
    			             System.out.println("\nElegir con que archivo trabajar:");
                                     System.out.println("1- lote01.txt");
                                     System.out.println("2- lote02.txt");
                                     System.out.println("3- lote03.txt");
                                     System.out.println("0- salir");
                                     int txt = Consola.readInt();
                                     switch (txt) {
                                         case 1:
                                             v.setTamaño(250000);
                                             v.generar("lote01.txt");
                                         break;
                                         
                                         case 2:
                                             v.setTamaño(500000);
                                             v.generar("lote02.txt");
                                         break;
                                         
                                         case 3:
                                             v.setTamaño(1000000);
                                             v.generar("lote03.txt");
                                         break;                                                                               
                                     }
                                     
    			 System.out.print("\nVector generado...");
    			 break;   
    		
    		case 1:
    		         System.out.print("Se ordena el vector por Intercambio...");
    			 v.setOrdenador( Arreglo.BUBBLE );
                         t1 = System.currentTimeMillis();
    			 v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;
    
    		case 2:
    		         System.out.print("Se ordena el vector por Seleccion...");
    			 v.setOrdenador( Arreglo.SELECTION );
                         t1 = System.currentTimeMillis();
    			 v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;
    
    		case 3:  
    		         System.out.print("Se ordena el vector por Insercion... ");
    			 v.setOrdenador( Arreglo.INSERTION );
                         t1 = System.currentTimeMillis();
    			 v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;
    
    		case 4:  
    		         System.out.print("Se ordena el vector por Quick Sort...");
    			 v.setOrdenador( Arreglo.QUICK );
                         t1 = System.currentTimeMillis();
    			 v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;
    
    		case 5:  
    		         System.out.print("Se ordena el vector por Heap Sort...");
    			 v.setOrdenador( Arreglo.HEAP );
                         t1 = System.currentTimeMillis();
    			 v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;
    
    		case 6:  
    		         System.out.print("Se ordena el vector por Shell Sort...");
    			 v.setOrdenador( Arreglo.SHELL );
                         t1 = System.currentTimeMillis();
    			 v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;
    			 
    		case 7:  
    		         System.out.print("Se ordena el vector por Merge Sort...");
    			 v.setOrdenador( Arreglo.MERGE );
                         t1 = System.currentTimeMillis();
    			 System.out.println("\nCantidad De Inversiones: ");
                         v.ordenar();
                         t2 = System.currentTimeMillis();
                         tf = t2 - t1;
    			 System.out.print("\nVector ordenado en: " + tf + " milisegundos...");
    			 break;    			 
    
    		case 8:  
    		         System.out.println("Se verifica si esta ordenado...");
    			 if(v.verificar()) { System.out.println("Esta ordenado..."); }
    			 else { System.out.println ("No esta ordenado..."); }
    			 break;
    		
    		case 9: ;
    	    }
    	 }
    	 while (op != 9);
        } 
}
