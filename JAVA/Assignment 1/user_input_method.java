import java.io.*;
import java.util.*;
public class user_input_method
{
	public static void main(String[] args) throws IOException
	{
		System.out.println("Hello User");
		//InputStreamReader in = new InputStreamReader(System.in);
		//BufferedReader bin = new BufferedReader(in);
		//System.out.println("Enter A Number : ");
		//int n = Integer.parseInt(bin.readLine());
		//System.out.println(n);
		System.out.println("Enter a Number : ");
		Scanner sc = new Scanner (System.in);
		int n2 = sc.nextInt();
		System.out.println(n2);
		
		
	}
}