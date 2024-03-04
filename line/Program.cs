using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class DrawingForm : Form
{
    private Bitmap canvas;
    private int x1, y1, x2, y2;

    public DrawingForm(int X1, int X2, int Y1, int Y2)
    {
        this.canvas = new Bitmap(800, 600);
        this.ClientSize = new Size(800, 600);
        this.Text = "Bresenham Line Drawing Algorithm";
        this.Paint += DrawingForm_Paint;


        this.x1 = X1;
        this.y1 = Y1;
        this.x2 = X2;
        this.y2 = Y2;
    }

    private void DrawingForm_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);
        int sx = x1 < x2 ? 1 : -1;
        int sy = y1 < y2 ? 1 : -1;
        int err = dx - dy;

        int x = x1;
        int y = y1;

        while (true)
        {
            canvas.SetPixel(x, y, Color.Black);

            if (x == x2 && y == y2)
                break;

            int e2 = 2 * err;

            if (e2 > -dy)
            {
                err = err - dy;
                x = x + sx;
            }

            if (e2 < dx)
            {
                err = err + dx;
                y = y + sy;
            }
        }

        g.DrawImage(canvas, 0, 0);
    }
}


public class DDAAlgorithm : Form
{
    private Bitmap bitmap;
    private PictureBox pictureBox;

    public DDAAlgorithm(int X1, int X2, int Y1, int Y2)
    {
        Text = "DDA Algorithm - Line Drawing";
        ClientSize = new Size(800, 600);

        bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
        pictureBox = new PictureBox();
        pictureBox.Dock = DockStyle.Fill;
        Controls.Add(pictureBox);

        DrawLineDDA(X1, X2, Y1, Y2);

        pictureBox.Image = bitmap;
    }

    private void DrawLineDDA(int X1, int X2, int Y1, int Y2)
    {
        double dx = X2 - X1;
        double dy = Y2 - Y1;
        double steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
        double xIncrement = dx / steps;
        double yIncrement = dy / steps;

        double x = X1;
        double y = Y1;

        for (int i = 0; i < steps; i++)
        {
            bitmap.SetPixel((int)x, (int)y, Color.Black);
            x += xIncrement;
            y += yIncrement;
        }
    }

 
}


namespace line
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Application.Run(new DrawingForm());
        }
    }
}

