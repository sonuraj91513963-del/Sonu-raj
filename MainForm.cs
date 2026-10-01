using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    public MainForm()
    {
        Text = "Game UI Panel";
        Size = new Size(400, 300);
        BackColor = Color.FromArgb(25, 25, 25);

        Button button = new Button();
        button.Text = "HEADSHOT";
        button.Size = new Size(150, 50);
        button.Location = new Point(120, 100);

        button.Click += (sender, e) =>
        {
            MessageBox.Show("Button clicked!");
        };

        Controls.Add(button);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
