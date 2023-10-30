import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FilenameFilter;
import java.util.List;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextField;

public class ListFiles {

  private JFrame frame;
  private JTextField textField;
  private JList<String> list;

  public ListFiles() {
    frame = new JFrame("List Files");
    frame.setSize(400, 300);

    JPanel panel = new JPanel();
    frame.getContentPane().add(panel);

    JLabel label = new JLabel("Directory:");
    panel.add(label);

    textField = new JTextField();
    panel.add(textField);

    JButton button = new JButton("List");
    button.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        File file = new File(textField.getText());
        String[] files = file.list(new FilenameFilter() {
          @Override
          public boolean accept(File dir, String name) {
            return new File(dir, name).isDirectory();
          }
        });
        list.setListData(files);
      }
    });
    panel.add(button);

    list = new JList<>();
    list.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
    JScrollPane scrollPane = new JScrollPane(list);
    panel.add(scrollPane);

    frame.setVisible(true);
  }

  public static void main(String[] args) {
    EventQueue.invokeLater(new Runnable() {
      @Override
      public void run() {
        new ListFiles();
      }
    });
  }
}