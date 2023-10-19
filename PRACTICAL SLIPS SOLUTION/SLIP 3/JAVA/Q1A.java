
// write a java program to check whether a given number is armstrong or not use (static keyword)
import java.util.Scanner;

public class Q1A {
    static int temp;
        public static void main(String agrs[]) {
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int num = scan.nextInt();
        int sum = 0, rem;
        temp = num;
        while (num > 0) {
            rem = num % 10;
            sum = sum + (rem * rem * rem);
            num = num / 10;
        }
        if (sum == temp) {
            System.out.print("Number is Armstrong");
        } else {
            System.out.print("Number is not Armstrong");
        }
        scan.close();
    }
}
