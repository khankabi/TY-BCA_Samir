//  Write a java program to display Label with text “Dr. D Y Patil College”, background color
//   Red and font size 20 on the frame.
import java.awt.*;
 
public class Q1A extends Frame{
    public void paint(Graphics g){
        Font f = new Font("Georgia",Font.PLAIN,20);
        g.setFont(f);
        g.drawString("Dr. D Y Patil College", 50, 70);
        setBackground(Color.RED);
    }
    public static void main(String args[]){
        Q1A sl = new Q1A();
        sl.setVisible(true);
        sl.setSize(500,300);
    }
}