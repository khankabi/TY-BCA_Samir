// Write a java program to copy the data from one file into another file, while copying change the case of characters in target file and replaces all digits by ‘*’ symbol.
import java.io.*;
class q2{
    public static void main(String args[]) throws IOException{
        FileReader fr = new FileReader("input.txt");
        FileWriter fw = new FileWriter("output.txt");
        int c;
        while ((c=fr.read())!=-1){
          if(Character.isDigit(c)==false){
              if(Character.isUpperCase(c)){
                fw.write(Character.toLowerCase(c));
              }else if(Character.isLowerCase(c)){
                fw.write(Character.toUpperCase(c));
              }
          }else{
              fw.write('*');
          }
        }
        fr.close();
        fw.close();
    }
}