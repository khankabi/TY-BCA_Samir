//Write a java program to check given year is leap or not

import java.io.*;
public class p1_6{
	public static void main(String[] args)throws IOException
	{
		System.out.println("hello User");
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader bin = new BufferedReader(in);		
		System.out.print("Enter a Year Must be in 4 digit : ");
		int n = Integer.parseInt(bin.readLine());
		System.out.println(n);
		if(n%4==0 || n%400==0 || n%100==0)
		{
			System.out.println("This is leap Year");
		} 
		else
		{
			System.out.println("This is not leap Year");
		}

		
	}
}