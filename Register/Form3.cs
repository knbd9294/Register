using Registre;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Register
{
    public partial class Form3 : Form
    {
        private Bunifu.DataViz.WinForms.DataPoint dataPoint1;
        private Bunifu.DataViz.WinForms.DataPoint dataPoint2;
        private RegisterDbContext regDbContext;
        public static Form form3 = new Form();

        public Form3()
        {
            form3 = this;
            InitializeComponent();
            regDbContext = new RegisterDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RenderColumn();
        }

        private void RenderLine()
        {
            dataPoint1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            Random random = new Random();
        }

        private void RenderColumn()
        {
            DateTime dateInit = new DateTime(dateInitial.Value.Year, dateInitial.Value.Month, dateInitial.Value.Day);
            DateTime dateFin = new DateTime(dateFinal.Value.Year, dateFinal.Value.Month, dateFinal.Value.Day);
            dataPoint1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_column);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            if (serviceVisCmb.SelectedIndex != -1 && serviceVisCmb.SelectedIndex != 11)
            {
                var groups = regDbContext.infoes
                   .Where(p => p.Date >= dateInit.Date && p.Date <= dateFin.Date &&
                               p.ServiceVisite == serviceVisCmb.Text)
                   .GroupBy(p => p.Date);

                foreach (var elm in groups)
                {
                    byte total = 0;
                    foreach (var i in elm)
                    {
                        total += i.Nombre;
                    }

                    dataPoint1.addLabely(elm.Key.Value.Date.ToString("dd/MM/yy"), total);//elm.Count()
                }
            }
            else
            {
                var groups = regDbContext.infoes
                    .Where(p => p.Date >= dateInit.Date && p.Date <= dateFin.Date)
                    .GroupBy(p => p.Date);

                foreach (var elm in groups)
                {
                    byte total = 0;
                    foreach (var i in elm)
                    {
                        total += i.Nombre;
                    }
                    dataPoint1.addLabely(elm.Key.Value.Date.ToString("dd/MM/yy"), total);
                }
            }
            canvas.addData(dataPoint1);
            string text = ((serviceVisCmb.Text == "") || (serviceVisCmb.SelectedIndex == 11))
                ? "Tout"
                : serviceVisCmb.Text;
            bunifuDataViz1.Title = "Service Visite: " + text;
            bunifuDataViz1.Render(canvas);

            // textBox1.Text = groups.Count().ToString();
        }

        private void RenderPie()
        {
            DateTime? dateInit = new DateTime(dateInitial.Value.Year, dateInitial.Value.Month, dateInitial.Value.Day);
            DateTime? dateFin = new DateTime(dateFinal.Value.Year, dateFinal.Value.Month, dateFinal.Value.Day);

            dataPoint2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_pie);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            var groups = regDbContext.infoes
                .Where(p => p.Date.Value >= dateInit.Value && p.Date.Value <= dateFin.Value)
                .GroupBy(p => p.ServiceVisite);

            int a = groups.Count();
            int total = 0;
            foreach (var elm in groups)
            {
                /*foreach (var i in elm)
                {
                    total += i.Nombre;
                }*/
                dataPoint2.addLabely(elm.Key + "(" + elm.Count().ToString() + ")", a);
                total = 0;
            }
            canvas.addData(dataPoint2);
            bunifuDataViz2.Render(canvas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RenderPie();
        }
    }
}