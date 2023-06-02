namespace PRA_Notifications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a Graphics object from the form's CreateGraphics method
            using (Graphics graphics = e.Graphics)
            {
                // Set the line color and thickness
                Pen pen = new Pen(Color.Black, 1);

                // Define the start and end points of the line
                Point startPoint = new Point(0, 60);
                Point endPoint = new Point(818, 60);

                // Draw the line
                graphics.DrawLine(pen, startPoint, endPoint);

                // Dispose of the Pen object
                pen.Dispose();
            }
        }

    }
}