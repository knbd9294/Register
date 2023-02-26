using Register;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Registre
{
    public partial class Form2 : Form
    {
        //private RegisterDbContext _regDbContext = new RegisterDbContext();

        private string cmbList1;

        private string cmbList2;

        //BindingSource bs = new BindingSource()

        private List<string> list = new List<string> { "Date", "Id", "Cni", "Nom" };

        public static Form form2 = new Form();

        public Form2()
        {
            InitializeComponent();

            //bs.DataSource = dataGridView1.DataSource;
            form2 = this;
            groupe.SelectedIndex = 0;
        }

        public enum CritereRecherche
        {
            Date,
            Id,
            Cni,
            Nom
        }

        public static void FillTextBoxesWithDGridViewColumn(DataGridView dataGridView, params Control[] controls)
        {
            int numberOfTextBoxesInTextBoxes = controls.Length;
            int dataGridViewNumberOfColumn = dataGridView.ColumnCount;
            if (numberOfTextBoxesInTextBoxes <= dataGridViewNumberOfColumn)
            {
                for (int i = 0; i <= numberOfTextBoxesInTextBoxes - 1; i++)
                {
                    if (controls[i] is TextBox)
                        controls[i].Text = dataGridView.CurrentRow.Cells[i].Value.ToString();
                    else if (controls[i] is ComboBox)
                    {
                        ComboBox ctr = controls[i] as ComboBox;
                        int a = ctr.FindStringExact(dataGridView.CurrentRow.Cells[i].Value.ToString());
                        if (a != -1)
                        {
                            ctr.SelectedIndex = a;
                        }
                    }
                    else if (controls[i] is DateTimePicker)
                    {
                        //DateTimePicker ctr = controls[i] as DateTimePicker;
                        if (dataGridView.CurrentRow.Cells[i].Value.ToString() != "" && dataGridView.CurrentRow.Cells[i].Value.ToString() != null)
                        {
                            // DateTime a = Convert.ToDateTime(dataGridView.CurrentRow.Cells[i].Value.ToString());
                            //if(a.Year.ToString()!="0000")
                            //  ctr.Value = a;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.id.Text = "";
            fingerId.Text = "";
            date.Text = "";
            name.Text = "";
            surname.Text = "";
            cni.Text = "";
            tel.Text = "";
            qualite.Text = "";
            motifVis.Text = "";
            serviceVis.Text = "";
            heureEntrer.Text = "";
            heureSortie.Text = "";
            note.Text = "";
            critere1.Text = critere1.Text.Trim();
            critere2.Text = critere2.Text.Trim();
            int crit1 = critereCmb1.SelectedIndex;
            int crit2 = critereCmb1.SelectedIndex;

            

            DateTime date1;
            bool isAValidDate = DateTime.TryParse(critere1.Text, out date1);

            int a = 0;
            bool id = int.TryParse(critere1.Text, out a);

            DateTime datI = new DateTime();
            bool isADate = DateTime.TryParse(critere1.Text, out datI);
            DateTime? isValidDate = new DateTime?();
            if (isADate)
                isValidDate = datI;
            else
                isValidDate = null;

            DateTime date2;
            bool isAValidDate2 = DateTime.TryParse(critere2.Text, out date2);
            int a2 = 0;
            bool id2 = int.TryParse(critere2.Text, out a2);
            DateTime datI2 = new DateTime();
            bool isADate2 = DateTime.TryParse(critere2.Text, out datI2);
            DateTime? isValidDate2 = new DateTime?();
            if (isADate2)
                isValidDate2 = datI2;
            else
                isValidDate2 = null;
            if (critereCmb1.SelectedIndex != -1 || critereCmb2.SelectedIndex != -1)
            {
                var data = Form1.regDbContext.infoes.Where(p => (p.Date == isValidDate || p.Id == a || p.Cni.StartsWith(critere1.Text) || p.Name.StartsWith(critere1.Text)) && (p.Date == isValidDate2 || p.Id == a2 || p.Cni.StartsWith(critere2.Text) || p.Name.StartsWith(critere2.Text))).Select(p => new
                {
                    Id = p.Id,
                    FingerPrintId = p.FingerPrint,
                    Date = p.Date,
                    Nom = p.Name,
                    Prenom = p.Surname,
                    Cni = p.Cni,
                    Qualite = p.Qualite,
                    MotifVisite = p.MotifVisite,
                    serviceVis = p.ServiceVisite,
                    HeureEntree = p.HeureEntrer,
                    HeureSortie = p.HeureSortie,
                    Note = p.Note,
                    Tel = p.Tel,
                    Nombre = p.Nombre
                });

                dataGridView1.DataSource = data.ToList();
            }
            else
            {
                Form2_Load(sender, e);
            }
        }

        private void critere1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void critereCmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = critereCmb1.SelectedIndex;
            cmbList1 = critereCmb1.Items[index].ToString();
            var result = critereCmb2.FindStringExact(cmbList1);
            if (result != -1)
            {
                critereCmb2.Items.Remove(cmbList1);
            }

            foreach (var itm in list)
            {
                if (critereCmb2.FindStringExact(itm) == -1 && cmbList1 != itm)
                {
                    critereCmb2.Items.Add(itm);
                }
            }
        }

        private void critereCmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = critereCmb2.SelectedIndex;
            cmbList2 = critereCmb2.Items[index].ToString();
            var result = critereCmb1.FindStringExact(cmbList2);
            if (result != -1)
            {
                critereCmb1.Items.Remove(cmbList2);
            }
            foreach (var itm in list)
            {
                if (critereCmb1.FindStringExact(itm) == -1 && cmbList2 != itm)
                {
                    critereCmb1.Items.Add(itm);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fingerId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            var dat = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            date.Text = Convert.ToDateTime(dat).ToShortDateString();
            name.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            surname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cni.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            qualite.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            motifVis.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[8].Value == null)
            {
                serviceVis.Text = "";
            }
            else
            {
                serviceVis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
            var hentree = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            heureEntrer.Text = Convert.ToDateTime(hentree).ToShortTimeString().ToString();
            if (dataGridView1.CurrentRow.Cells[10].Value == null)
            {
                heureSortie.Text = "";
            }
            else
            {
                heureSortie.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value).ToShortTimeString();
            }

            if (dataGridView1.CurrentRow.Cells[11].Value == null)
            {
                note.Clear();
            }
            else
            {
                note.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }

            if (dataGridView1.CurrentRow.Cells[12].Value == null)
            {
                tel.Text = "";
            }
            else
            {
                tel.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            }

            int a = int.Parse(id.Text);
            var query = Form1.regDbContext.infoes.Single(p => p.Id == a);
            groupe.SelectedIndex = query.Groupe == false ? 0 : 1;
            nombreGroupe.Text = query.Nombre.ToString();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //total.Text = dataGridView1.RowCount.ToString();
            //dataGridView1.CurrentRow.Cells[11].Value.ToString()
            int maxRow = dataGridView1.RowCount;
            int tot = 0;
            for (int i = 0; i < maxRow; i++)
            {
                byte val = Convert.ToByte(dataGridView1.Rows[i].Cells[13].Value);
                if (val == 0)
                {
                    tot += 1;
                }
                else
                {
                    tot += val;
                }
            }
            total.Text = tot.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // total.Text = dataGridView1.RowCount.ToString();
            int maxRow = dataGridView1.RowCount;
            int tot = 0;
            for (int i = 0; i < maxRow; i++)
            {
                byte val = Convert.ToByte(dataGridView1.Rows[i].Cells[13].Value);
                if (val == 0)
                {
                    tot += 1;
                }
                else
                {
                    tot += val;
                }
            }
            total.Text = tot.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            id.Text = "";
            fingerId.Text = "";
            date.Text = "";
            name.Text = "";
            surname.Text = "";
            cni.Text = "";
            tel.Text = "";
            qualite.Text = "";
            motifVis.Text = "";
            serviceVis.Text = "";
            heureEntrer.Text = "";
            heureSortie.Text = "";
            note.Text = "";

            //dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //dataGridView1.RowHeadersVisible = false;

            var data = Form1.regDbContext.infoes.Select(p => new
            {
                Id = p.Id,
                FingerPrintId = p.FingerPrint,
                Date = p.Date,
                Nom = p.Name,
                Prenom = p.Surname,
                Cni = p.Cni,
                Qualite = p.Qualite,
                MotifVisite = p.MotifVisite,
                serviceVis = p.ServiceVisite,
                HeureEntree = p.HeureEntrer,
                HeureSortie = p.HeureSortie,
                Note = p.Note,
                Tel = p.Tel,
                Nombre = p.Nombre
            }).ToList();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(243, 101, 108);
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(183, 244, 174);
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[8].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[9].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[10].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[11].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[12].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);
            dataGridView1.Columns[13].DefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214);

            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("SergioUI", 8.0f, FontStyle.Bold | FontStyle.Italic);
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            //DateTime? heureSortieResult = Convert.ToDateTime(heureSortie.Text);
            if (this.id.Text == "")
                return;
            byte a = 0;
            bool groupeVal = groupe.SelectedIndex == 1 ? true : false;
            if (groupeVal)
            {
                bool isValid = byte.TryParse(nombreGroupe.Text, out a);
                if (isValid)
                {
                    if (a == 0)
                    {
                        groupe.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Nombre is not a valid number");
                    return;
                }
            }

            DateTime heureSortieResult1 = new DateTime();
            DateTime? heureSortieResult = new DateTime();
            bool heureSortieResultIsConverted = DateTime.TryParse(heureSortie.Text, out heureSortieResult1);
            if (heureSortieResultIsConverted)
            {
                heureSortieResult1 = Convert.ToDateTime(heureSortie.Text);
                heureSortieResult = heureSortieResult1;
            }
            else
            {
                heureSortieResult = null;
            }

            int telep = 0;
            bool t = int.TryParse(tel.Text, out telep);
            DateTime? heurentr = DateTime.Parse(heureEntrer.Text);
            int id = int.Parse(this.id.Text);
            DateTime? dat = DateTime.Parse(date.Text);
            var aPersInDb = Form1.regDbContext.infoes.SingleOrDefault(p => p.Id == id);
            if (aPersInDb == null)
            {
                MessageBox.Show("Does not exist in database");
            }
            else
            {
                Form1.TrimTextBoxes(fingerId, name, surname, cni, heureEntrer, tel, qualite, motifVis, serviceVis, heureSortie);
                //aPersInDb.FingerPrint = fingerId.Text;
                aPersInDb.Date = dat;
                aPersInDb.Name = name.Text;
                aPersInDb.Surname = surname.Text;
                aPersInDb.Cni = cni.Text;
                aPersInDb.Qualite = qualite.Text;
                aPersInDb.MotifVisite = motifVis.Text;
                aPersInDb.HeureEntrer = heurentr;
                aPersInDb.HeureSortie = heureSortieResult;
                aPersInDb.Note = note.Text;
                aPersInDb.Tel = telep;
                aPersInDb.ServiceVisite = serviceVis.Text;
                aPersInDb.Groupe = groupeVal;
                aPersInDb.Nombre = a;
                Form1.regDbContext.SaveChanges();
                MessageBox.Show("Id " + aPersInDb.Id + " Modifier avec success");
            }
            Form2_Load(sender, e);
        }

        private void motifVisCmb_TextChanged(object sender, EventArgs e)
        {
            motifVis.Text = motifVisCmb.Text;
        }

        private void qualiteCmb_TextChanged(object sender, EventArgs e)
        {
            qualite.Text = qualiteCmb.Text;
        }

        private void serviceVisCmb_TextChanged(object sender, EventArgs e)
        {
            serviceVis.Text = serviceVisCmb.Text;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (this.id.Text == "")
                return;
            int id = int.Parse(this.id.Text);
            var persToRemove = Form1.regDbContext.infoes.SingleOrDefault(p => p.Id == id);
            if (persToRemove == null)
            {
                MessageBox.Show("Does not exist in database");
            }
            else
            {
                Form1.regDbContext.infoes.Remove(persToRemove);
                Form1.regDbContext.SaveChanges();
                MessageBox.Show("Id " + persToRemove.Id + " Supprimer avec success");
            }
            Form2_Load(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void dsafsfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var pers = Form1.regDbContext.infoes.SingleOrDefault(p => p.Id == index);
            if (pers != null)
            {
                Form1.regDbContext.infoes.Remove(pers);
                Form1.regDbContext.SaveChanges();
                Form2_Load(sender, e);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.id.Text == "")
                return;
            var a = Form1.form1.Controls.Find("name", false);
            a[0].Text = this.name.Text;
            a = Form1.form1.Controls.Find("surname", false);
            a[0].Text = this.surname.Text;
            a = Form1.form1.Controls.Find("cni", false);
            a[0].Text = this.cni.Text;
            a = Form1.form1.Controls.Find("tel", false);
            a[0].Text = this.tel.Text;
            a = Form1.form1.Controls.Find("qualite", false);
            a[0].Text = this.qualite.Text;
            a = Form1.form1.Controls.Find("motifVis", false);
            a[0].Text = this.motifVis.Text;
            a = Form1.form1.Controls.Find("serviceVis", false);
            a[0].Text = this.serviceVis.Text;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
            else
            {
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }

            Form1.ValidationError(id, idVal);
        }

        private void fingerId_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(fingerId, fingerIdVal);
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(date, dateVal);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(name, nameVal);
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(surname, surnameVal);
        }

        private void cni_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(cni, cniVal);
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(tel, telVal);
        }

        private void qualite_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(qualite, qualiteVal);
        }

        private void motifVis_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(motifVis, motifVisVal);
        }

        private void serviceVis_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(serviceVis, serviceVisVal);
        }

        private void heureEntrer_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(heureEntrer, heureEntVal);
        }

        private void heureSortie_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(heureSortie, heureSortieVal);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form3.form3.Show();
        }

        private void groupe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void nombreGroupe_TextChanged(object sender, EventArgs e)
        {
            Form1.ValidationError(nombreGroupe, nombreGroupeVal);
        }

        private void nombreGroupe_VisibleChanged(object sender, EventArgs e)
        {
            if (groupe.SelectedIndex == 1)
            {
                nombreGroupe.Visible = true;
                nombreGroupeVal.Visible = true;
                label18.Visible = true;
            }
            else
            {
                nombreGroupe.Text = "1";
                nombreGroupe.Visible = false;
                nombreGroupeVal.Visible = false;
                label18.Visible = false;
            }
        }
    }
}