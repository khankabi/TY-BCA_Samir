
// write a java program to copy only numeric data from one file to another file
// import java.io.*;

// class q1b {
//     public static void main(String args[]) throws IOException {
//         char ch;
//         FileReader fr = new FileReader("a.txt");
//         FileWriter fw = new FileWriter("b.txt");
//         int c;
//         while ((c = fr.read()) != -1) {
//             ch = (char) c;
//             if (Character.isDigit(ch) == false) {
//                 fw.write(c);
//             }
//         }
//         fr.close();
//         fw.close();
//     }
// }

import java.io.*;
public class q1b{
    public static void main(String args[]) throws IOException
    {
        FileReader fr = new FileReader("input.txt");
        FileWriter fw = new FileWriter("output.txt");
        char ch;
        int i;
        while((i = fr.read())!=-1)
        {
            ch  = (char) i;
            if (Character.isDigit(ch) == true)
            {
                fw.write(i);
            }
        }
        fr.close();
        fw.close();
    }
}
