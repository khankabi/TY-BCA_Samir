// Write a java program to search given name into the array, if it is found then display its index otherwise display appropriate message.
import java.io.DataInputStream;
class Q1{
    public static void main(String args[]){
        String arr[] = {"Naruto", "Sasuke", "Gojo","Mike"};
        int i,n=0;
        boolean a=false;
        DataInputStream dr = new DataInputStream(System.in);
        try {
            System.out.print("Enter String : ");
            String s= dr.readLine();
            for(i = 0; i < arr.length; i++)
            {
                if(arr[i].equals(s))
                {
                    n = i;
                    a = true;
                    break;
                }
            }
            if(a){
                System.out.println("arr" + "["+ i + "]");
            }else{
                System.out.println("not Found");
            }
        } catch (Exception e) {}
    }

}