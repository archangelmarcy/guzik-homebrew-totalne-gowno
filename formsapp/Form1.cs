namespace formsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Escape()
        {

        }

        private void MoveButton(object sender, EventArgs e)
        {



        }

        private void przycisk_MouseEnter(object sender, EventArgs e)
        {
            //Wez przycisk ktory zostal klikniety
            Button b = (Button)sender;


            //Wez rozmiar okna w zmienne
            int maxX = this.Size.Width;
            maxX -= b.Size.Width;
            int maxY = this.Size.Width;
            maxY -= b.Size.Height;



            Random r = new Random();

            int x = r.Next(maxX);
            int y = r.Next(maxY);

            Point p = new Point(x, y);

            b.Location = p;






        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
