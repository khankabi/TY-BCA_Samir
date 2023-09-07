
	class Rectangle
	{
		int length,breadth;
		void show(int length, int breadth)
		{
			this.length = length;
			this.breadth = breadth;
		}
		int calculate()
		{
			return(length*breadth);
		}		 		
		
	}
/* Main class*/
public class this_keyword
{
	public static void main(String[] args)
	{
		Rectangle  obj = new Rectangle();
		obj.show(8,6);
		int area = obj.calculate();		
		System.out.println("The area of a Rectangle is : "+area);

	}
}
