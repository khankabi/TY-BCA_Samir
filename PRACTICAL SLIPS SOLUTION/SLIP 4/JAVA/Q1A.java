
// write a java program to display alternate charcter from a given string.
import java.util.Scanner;

class Q1A {
    public static void main(String args[]) {
        Scanner scan = new Scanner(System.in);
            System.out.print("Enter String : ");
            String str = scan.nextLine();
            for (int i = 0; i < str.length(); i += 2) {
                System.out.print(" " + str.charAt(i));
            }        
        scan.close();
    }
}