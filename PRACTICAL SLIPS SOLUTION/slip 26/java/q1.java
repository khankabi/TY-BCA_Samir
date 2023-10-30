// Write a java program to display ASCII values of the characters from a file.
import java.io.*;
class q1{
    public static void main(String args[]) throws IOException{
        char ch;
        FileReader fr = new FileReader("input.txt");
        int c;
        while ((c=fr.read())!=-1){
            ch=(char)c;
            if(Character.isDigit(ch)==false && (Character.isSpaceChar(c)==false)){
                System.out.println("ASCII "+ch+" : "+ c);
            }
        }
        fr.close();
    }
}