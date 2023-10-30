
// Create a package named Series having three different classes to print series: i. Fibonacci series ii. Cube of numbers iii. Square of numbers Write a java program to generate ‘n’ terms of the above series.
import java.util.*;
import Series.*;

public class q2 {
    public static void main(String args[]) {
        int n1, n2, n3;
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter How many fibonacci series: ");
        n1 = sc.nextInt();
        System.out.println("Enter How many Cubes series: ");
        n2 = sc.nextInt();
        System.out.println("Enter How many sqaure series: ");
        n3 = sc.nextInt();
        System.out.println("\n-----------Fibonacci series----------\n");
        Fib f = new Fib();
        f.fibSeries(n1);


        System.out.println("\n-----------Cubes series----------\n");
        Cubes cb = new Cubes();
        cb.cubeSeries(n2);


        System.out.println("\n-----------Sqaure series----------\n");
        Square sq = new Square();
        sq.squareSeries(n3);




    }
}
