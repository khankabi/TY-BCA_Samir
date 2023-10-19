// write a java program to display all the vowels from a given string.
import java.util.Scanner;

public class Q1A {
    public static void main(String args[]) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a String for Operation: ");
        String str = sc.nextLine();
        str = str.toLowerCase();
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == 'a' || str.charAt(i) == 'u' || str.charAt(i) == 'i' || str.charAt(i) == 'o'
                    || str.charAt(i) == 'e') {
                System.out.print(str.charAt(i));
            }
        }
        sc.close();

    }
}
