namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        Brush? brush;
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            brush = Brushes.Yellow;
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(brush, 0, 0, 10, 20);
            graphics.Dispose();

            brush = Brushes.Red;
            graphics = CreateGraphics();
            graphics.FillEllipse(brush, 20, 50, 100, 100);
            graphics.Dispose();
        }
    }
}