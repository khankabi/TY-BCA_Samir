// Write a java program to scroll the text from left to right and vice versa continuously.
import java.applet.Applet;

import java.awt.*;

public class Slip1A extends Applet implements Runnable {

    int x, y, z;

    Thread t;

    public void init() {

        x = 50;

        y = 50;

        z = 1;

        t = new Thread(this);

        t.start();

    }

    public void mpostion() {

        x = x + 10 * z;

        if (x > this.getWidth())

            z = -1;

        if (x < 0)

            z = 1;

    }

    public void run() {

        while (true) {

            repaint();

            mpostion();

            try {

                Thread.sleep(100);

            } catch (Exception e) {

            }

        }

    }

    public void paint(Graphics g) {

        g.drawString("SVPM", x, y);

    }

}

/*

 * <applet code="Slip1A.class" width="300" height="300">

 * </applet>

 */

