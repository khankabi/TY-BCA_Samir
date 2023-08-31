//Write a java program to check whether given String is palindrome or not
import java.io.*;
public class p1_1
{
	public static void main(String args[])throws IOException
	{
		InputStreamReader in=new InputStreamReader(System.in);
		BufferedReader bin=new BufferedReader(in);
		System.out.println("Enter a String : ");
		String str=bin.readLine();
		//String str="madam";
		String ctr="";
		char ch;
		System.out.println("Hello User");
		for(int i=0;i<str.length();i++)
		{
			ch=str.charAt(i);
			ctr=ch+ctr;
		}
		if(ctr.toLowerCase().equals(str.toLowerCase()))
		{
			System.out.println("it is palindrom");
		}
		else
		{
			System.out.println("it is not");
		}
	}
}