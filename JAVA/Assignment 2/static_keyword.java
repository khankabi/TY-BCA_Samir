class test
{
	static int i ;
	int j;
	static
	{
		i=10;
		System.out.println("Static block called");
	}
}
class static_keyword
{
	public static void main(String[] args)
	{
		System.out.println(test.i);
	}
}