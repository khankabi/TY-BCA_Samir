//  Create an Applet that displays the x and y position of the cursor movement using Mouse and Keyboard. (Use appropriate listener).
import java.awt.*;
import java.awt.event.*;
import java.applet.*;

public class q2 extends Applet implements KeyListener {
String msg = " ";
int X = 10, Y = 20;
public void init() {
addKeyListener(this);
requestFocus();
}
public void keyPressed(KeyEvent ke) {
showStatus("Key Down");
}
public void keyReleased(KeyEvent ke) {
showStatus("Key Up");
}
public void keyTyped (KeyEvent ke) {
msg += ke.getKeyChar();
repaint();
}
public void paint(Graphics g) {
g.drawString(msg, X, Y);
}
}