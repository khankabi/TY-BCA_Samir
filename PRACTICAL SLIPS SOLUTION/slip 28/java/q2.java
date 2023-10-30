// Write a java Program to accept the details of 5 employees (Eno, Ename, Salary) and display it onto the JTable.
import javax.swing.*;
public class q2 {
    JFrame f;
    JTable j;
    q2(){
        f = new JFrame();
        f.setTitle("Employee Details");
        String data[][] = {
            {"1","Samir","50,000"},
            {"2","Afzal","20,000"},
            {"3","Adnan","25,000"},
            {"4","Aman","20,000"},
            
        };
        String[] columnNames = {"Eno", "Ename", "Salary" };
        j = new JTable(data, columnNames);
        j.setBounds(30,40,200,300);
        JScrollPane sp = new JScrollPane(j);
        f.add(sp);
        f.setSize(500,200);
        f.setVisible(true);
    }
    public static void main(String args[]) {
        new q2();
    }
}
