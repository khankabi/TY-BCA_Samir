// Write a java program to calculate sum of digits of a given number using recursion.
import java.util.*;

public class q1 {
    int sum =0;
    public static void main(String args[]) throws Exception{
        int n;
        Scanner s = new Scanner(System.in);
        System.out.print("Enter the Number : ");
        n =s.nextInt();
        q1 obj = new q1();
        int a = obj.sum_digit(n);
        System.out.println("Sum of Digit is : "+a);
    }
    int sum_digit(int n){
        sum = n%10;
        if(n==0){
            return 0;
        }else{
            return sum +sum_digit(n/10);
        }
    } 
}