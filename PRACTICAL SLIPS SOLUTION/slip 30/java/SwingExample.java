import javax.swing.*;

public class SwingExample extends JFrame {

  public SwingExample() {
    super("Swing Example");

    // Create a panel to contain the components.
    JPanel panel = new JPanel();

    // Create a label.
    JLabel label = new JLabel("This is a label.");

    // Create a text field.
    JTextField textField = new JTextField();

    // Create a button.
    JButton button = new JButton("Click me!");

    // Add the components to the panel.
    panel.add(label);
    panel.add(textField);
    panel.add(button);

    // Set the size of the frame.
    setSize(300, 200);

    // Add the panel to the frame.
    getContentPane().add(panel);

    // Display the frame.
    setVisible(true);
  }

  public static void main(String[] args) {
    // Create a new instance of the SwingExample class.
    SwingExample example = new SwingExample();
  }
}