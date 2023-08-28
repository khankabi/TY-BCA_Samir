//program to add two dimensional array into another 2d array
import java.io.*;
public class Addition_of_2d_array
{
	public static void main(String args[]) throws IOException
	{
		int arr1[][]={{3,4,5},{1,2,9}};
		int arr2[][]={{3,4,5},{1,2,9}};
		System.out.println("Hello world");
		System.out.println("Enter the values of first array:");
		InputStreamReader in=new InputStreamReader(System.in);
		BufferedReader bin= new BufferedReader(in);		
		
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<3;j++)
			{
				//System.out.println("arr1["+i+"]"+"["+j+"] = "+arr1[i][j]);
				System.out.print("arr1["+i+"]["+j+"]"+": ");
				arr1[i][j]=Integer.parseInt(bin.readLine());
			}
			System.out.println();
		}
		System.out.println("The First Array : ");
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<3;j++)
			{
				//System.out.println("arr1["+i+"]"+"["+j+"] = "+arr1[i][j]);
				System.out.print(arr1[i][j]);
			}
			System.out.println();
		}
		System.out.println("The Second Array : ");
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<3;j++)
			{
				//System.out.println("arr1["+i+"]"+"["+j+"] = "+arr1[i][j]);
				System.out.print("arr2["+i+"]["+j+"]"+": ");
				arr2[i][j]=Integer.parseInt(bin.readLine());
			}
			System.out.println();
		}
		System.out.println("this is addition of two program");
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<3;j++)
			{
				//System.out.println("arr2["+i+"]"+"["+j+"] = "+arr1[i][j]);
				System.out.print(arr2[i][j]+arr1[i][j]+" ");
			}
			System.out.println();
		}		
	}
}