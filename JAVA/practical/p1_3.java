// write a java program to accept a number from command prompt and generate multiplicatoin table of a number
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.*;
public class p1_3
{
	public static void main(String args[]) throws IOException
	{
		System.out.println("Hello User");
		System.out.println("Enter a number :");
		InputStreamReader in=new InputStreamReader(System.in);
		BufferedReader bin=new BufferedReader(in);
		int n=Integer.parseInt(bin.readLine());
		for(int i=1;i<=10;i++)
			System.out.println(n+" * "+i+" = "+n*i);
		
	}
}
