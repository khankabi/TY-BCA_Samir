public class new_keyword
{
	public static void main(String[] args)
	{
		//double[] obj = new double[] {1.2,2.3,3.5,4.6,5.7,6.5,7.0,8.0,9.0};
		int[] obj = new int[]{4,56,48,8,9,1,5,6,4,76,4657,89,456,4,8,7,8,1,6,3,41,6};
		System.out.println("You hacked YEWS Website");
		for(int i = 0; i<obj.length;i++)
		{
			System.out.println(obj[i]+" ");		
		}
		int total = 0;
		for(int i=0;i<obj.length;i++)
		{
			total+=obj[i];
		}
		System.out.println("total is :"+total);
		double max = obj[0];
		for (int i = 1; i<obj.length;i++)
		{
			if(obj[i]>max) max = obj[i];
		}
		System.out.println("Max is :"+max);
	}
}