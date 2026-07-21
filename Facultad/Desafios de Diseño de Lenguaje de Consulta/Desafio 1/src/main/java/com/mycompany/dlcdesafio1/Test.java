package com.mycompany.dlcdesafio1;


import java.io.File;
import java.util.Scanner;
import java.io.FileNotFoundException;

public class Test
{
    public static void main(String args[])
    {
                
        System.out.println("Ingrese la cantidad de valores para calcular la Mediana: ");
        Scanner sct = new Scanner(System.in);
        int cant =  sct.nextInt();
        
        if (cant != 0) {
                       
            
                TSBHeap <Integer> h01 = new TSBHeap<>( true);
                TSBHeap <Integer> h02 = new TSBHeap<>(h01.calularTamañoPorArchivo(), false);
                
                
                File f = new File("list[100000].txt");
                int control = 0;
                
                
            try (Scanner sc2 = new Scanner(f))  {
                
                while (sc2.hasNextInt())
                {  
                        int equi = 0;
                        boolean heap; 
                        int num = sc2.nextInt();                  
                          
                        if(control == 0 && h01.isEmpty() && h02.isEmpty()) {
                            h01.add(num);
                            control += 1;
                            continue;                            
                        } 
                                               
                        if(num > h01.get()) {                                
                            equi = (h02.size()+1) - h01.size();
                            heap = true;
                        } else {
                            equi =  h02.size() - (h01.size()+1);
                            heap = false;
                        }

                        if(Math.abs(equi) > 1) {
                            int root;

                            if (heap) {                                
                                root = h02.remove();
                                h01.add(root);
                                h02.add(num);
                                control+=1;
                            } else {                                

                                root = h01.remove();
                                h02.add(root);
                                h01.add(num);
                                control+=1;
                            }                          

                        } else {

                            if (heap) {
                                h02.add(num);
                                control+=1;
                            } else {
                                h01.add(num);
                                control+=1;
                            }
                        }

                        if (cant == control) { 
                            double mediana; 
                            
                            if((h01.size() + h02.size())%2 == 0) {
                               mediana = (h01.get() + h02.get()) / 2;
                               System.out.println("La mediana es: " + mediana);
                               break;                           
                            } else {
                                if (h01.size() < h02.size()) {
                                    mediana = h02.get();
                                    System.out.println("La mediana es: " + mediana);
                                    break;
                                } else {
                                    mediana = h01.get();
                                    System.out.println("La mediana es: " + mediana);
                                    break;
                                }
                            }
                        }
                              
             }
            }
            catch (FileNotFoundException ex) 
            {
                System.out.println("No existe el archivo...");
                ex.getMessage();
            }                
            
        } else {
            System.out.println("Por favor ingrese un valor");
        }
        
        
        
    }
}
