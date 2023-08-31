//Write a Java program to accept two numbers using command line argument and calculate addition,substraction, multiplication and divison
import java.io.*;
public class p1_8
{
	public static void main(String[] args)throws IOException
	{
		System.out.println("Hello User");
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader bin = new BufferedReader(in);
		System.out.println("Enter a Number : ");
		int n1 = Integer.parseInt(bin.readLine());
		System.out.println("Enter a Number 2 : ");
		int n2 = Integer.parseInt(bin.readLine());
		int add = n1 + n2;
		int sub = n1 - n2;
		int mul = n1 * n2;	
		int div = n1 / n2;
		System.out.println("Addition : " + add);
		System.out.println("Substract : " + sub);
		System.out.println("Multilication : " + mul);
		System.out.println("Division : " + div);		

	}
}