//program to demonstate two dimensional array
public class demo_2d_array
{
	public static void main(String args[])
	{
		int arr[][]={{1,2,3,4,5,6,7,8,9},{11,12,13,14,15,16,17,18,19}};
		System.out.println("Hello world");
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<9;j++)
			{
				System.out.println("arr["+i+"]"+"["+j+"] = "+arr[i][j]);
			}
		}
		
	}

}