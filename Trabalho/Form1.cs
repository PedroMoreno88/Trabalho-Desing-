using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            MakePictureBoxRound(pictureBox2, 15);
            textBox1.Region = RoundCorners(textBox1.ClientRectangle, 10);
            textBox2.Region = RoundCorners(textBox2.ClientRectangle, 10);
            //RoundGroup(groupBox1, 10);
        }


        private void MakePictureBoxRound(PictureBox pictureBox, int radius)
        {
            Rectangle rectangle = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rectangle);
            pictureBox.Region = new Region(path);
        }
        private Region RoundCorners(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }
        private void RoundGroup(Control control, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);

            // Canto superior esquerdo
            Rectangle arcRect = new Rectangle(bounds.Location, size);
            path.AddArc(arcRect, 180, 90);

            // Canto superior direito
            arcRect.X = bounds.Right - diameter;
            path.AddArc(arcRect, 270, 0);

            // Canto inferior direito
            arcRect.Y = bounds.Bottom - diameter;
            path.AddArc(arcRect, 0, 0);

            // Canto inferior esquerdo
            arcRect.X = bounds.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string codigoHexadecimal = "#27E9F7";
            string codigoHexadecimal2 = "#3550DC";
            Color corInicial = ColorTranslator.FromHtml(codigoHexadecimal2);
            Color corFinal = ColorTranslator.FromHtml(codigoHexadecimal);

            // Criação do gradiente linear horizontal
            Rectangle retangulo = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush gradiente = new LinearGradientBrush(retangulo, corInicial, corFinal, LinearGradientMode.Horizontal);

            // Preenche o retângulo do formulário com o gradiente
            e.Graphics.FillRectangle(gradiente, retangulo);

        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            i += 1;

            if (i == 0)
            {
                lbl_Dis1.Text = "Matematica";
                lbl_Dis2.Text = "Quimica";
                lbl_Dis3.Text = "Fisica";
                lbl_Dis4.Text = "Desenho";
            }
            if (i == 1)
            {
                lbl_Dis1.Text = "filosofia";
                lbl_Dis2.Text = "Historia";
                lbl_Dis3.Text = "Geografia";
                lbl_Dis3.Location = new Point(165, 28);
                lbl_Dis4.Text = "Português";
            }
            if (i == 2)
            {
                lbl_Dis1.Text = "Sociologia";
                lbl_Dis2.Text = "Biologia";
                lbl_Dis3.Text = "Ed.Fisica";
                lbl_Dis4.Text = "Redação";
            }
            if (i == 3)
            {
                lbl_Dis1.Text = "LP4";
                lbl_Dis2.Text = "ICC";
                lbl_Dis3.Text = "BD";
                lbl_Dis4.Text = "Eng.Software";
            }
            if (i == 4)
            {
                lbl_Dis1.Text = "Literatura";
                lbl_Dis2.Text = "";
                lbl_Dis3.Text = "";
                lbl_Dis4.Text = "";

            }
            if (i == 5) i = 0;
        }
    }
}