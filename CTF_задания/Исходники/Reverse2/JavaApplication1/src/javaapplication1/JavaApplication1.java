/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

/**
 *
 * @author KirKhal
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        char a;
        Integer[] arr = {101, 106, 94, 99, 118, 73, 110, 108, 103, 107, 105, 83, 84, 100, 99, 81, 104, 107};
        int i;
        for(i=0;i<arr.length;i++)
        {
            arr[i] = arr[i]+i+1;
        }
        System.out.print("The first piece of flag is:\n");
        int tmp;
        tmp = arr[0];
        System.out.print((char)tmp);
        tmp = arr[1];
        System.out.print((char)tmp);
        tmp = arr[2];
        System.out.print((char)tmp);
        tmp = arr[3];
        System.out.print((char)tmp);
        tmp = arr[4];
        System.out.print((char)tmp);
        // TODO code application logic here
    }
    
}
