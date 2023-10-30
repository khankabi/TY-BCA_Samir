package TYBBACA;
import java.util.*;
public class Student {
    public int rno;
    public String sname;
    public float per;
    public void setrno(int rn){
        this.rno=rn;
    }    
    public int getrno(){
        return rno;
    }
    public void setName(String name){
        this.sname=name;
    }
    public String getName(){
        return sname;
    }
    public void setPer(float pr){
        this.per=pr;
    }
    public float getPer(){
        return per;
    }
    public Student(){
        Scanner n  = new Scanner(System.in);
        System.out.print("Enter Student Roll Number: ");
        this.setrno(n.nextInt());
        System.out.print("Enter Student Name: ");
        this.setName(n.next());
        System.out.print("Enter Student percentage: ");
        this.setPer(n.nextFloat());
    }
    public void disp(){

    }
    public void finalize() {
        System.out.println("inside demo's finalize()");

        System.out.println("Calling finalize method"
                + " of the Object class");

        // Calling finalize() of Object class
    }
}
