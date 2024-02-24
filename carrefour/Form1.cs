using System;
using System.Drawing;
using System.Windows.Forms;

namespace carrefour
{
    public partial class Form1 : Form
    {
        private Carrefour carrefour;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            carrefour = new Carrefour();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            carrefour.DeplacerVehicules();
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            carrefour.Dessiner(e.Graphics);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

       
    }
}
