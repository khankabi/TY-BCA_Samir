// Write a java program to display each word from a file in reverse order.
import java.io.*;
import java.util.Scanner;

class q1{
    public static void main(String args[]) throws IOException{
        FileReader fr = new FileReader("input.txt");
        FileWriter fw = new FileWriter("output.txt");

        try (Scanner dr = new Scanner(fr)) {
            while(dr.hasNextLine()){
                String s=dr.nextLine();
                StringBuffer buffer = new StringBuffer(s);
                buffer=buffer.reverse();
                String ans = buffer.toString();
                fw.write(ans);
            }
        }catch(Exception e){
            System.out.print("Error...!");
        }

        fr.close();
        fw.close();
    }
}