using Register;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Registre
{
    public partial class Form1 : Form
    {
        private List<string> richList = new List<string>();
        private int add = 0;
        private bool selecting;
        private Rectangle selection;
        public static RegisterDbContext regDbContext;
        public static Form form1 = new Form();

        public Form1()
        {
            InitializeComponent();
            regDbContext = new RegisterDbContext();
            //heureEnt.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.Date.ToShortDateString();
            form1 = this;
            groupe.SelectedIndex = 0;
        }

        public static void TrimTextBoxes(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = textBox.Text.Trim();
            }
        }

        public void ListInRichText(List<string> list)
        {
            richTextBox1.Clear();
            foreach (var elm in list)
            {
                richTextBox1.Text += elm;
                richTextBox1.Text += '\n';
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            /* Fill
                    CNI number
                    Name
                    Surname
             */
            selection.Width = 0;
            selection.Height = 0;
            pictureBoxRegions.Image = null;
            pictureBoxParagraphs.Image = null;
            pictureBoxTextLines.Image = null;
            pictureBoxWords.Image = null;
            pictureBoxComponents.Image = null;

            string path = @"M:\DCIM\Camera";
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                var myFile = directory.GetFiles()
                    .OrderByDescending(f => f.LastWriteTime)
                    .First();
                //progressBar1.Value += 1;
                //textBox8.Text = myFile.FullName;
                //var driveList = DriveInfo.GetDrives();
                pictureBox1.Load(myFile.FullName);
                /*foreach (var drive in driveList)
               {
                   if (drive.DriveType == DriveType.Removable)
                   {
                       textBox8.Text = drive.Name;
                   }
               }*/
                ocr1.PictureFileName = myFile.FullName;
                ocr1.Active = true;
                ocr1.Recognize();
                textBox8.Text = ocr1.Text;
                try
                {
                    pictureBox1.Cursor = Cursors.Cross;
                }
                catch (Exception)
                {
                    pictureBox1.Cursor = Cursors.Default;
                }

                if (!ocr1.Active)
                {
                    ocr1.DataPath = AppDomain.CurrentDomain.BaseDirectory;
                    ocr1.Active = true;
                }
                /*var drives = DriveInfo.GetDrives();
                var remos = drives.Where(c => c.DriveType == DriveType.Removable && c.DriveFormat == "FAT" && c.IsReady);
                foreach (var remo in remos)
                {
                    textBox8.Text += remo.Name;
                }*/
            }
            else
            {
                MessageBox.Show("Directory " + path + " does not exist check phone connection");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Form2.form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            string path = @"C:\Users\Public\Pictures\cardImg";
            var dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    file.Delete();
                }
            }

            //Delete All Files In C:\Users\Public\Pictures\cardImg Directory
            //Search for the latest No in Db and increment for the newcomer...
        }

        private void fingerId_TextChanged(object sender, EventArgs e)
        {
            /*Select the record of current date
                    Search for the fingerId in the List
                        if fingerId Not exist => is a new record lets continue fill our form // Take Date and Heure Entree
                        else if fingerId exist
                            if is only one record
                                Fill HeureSortie for that fingerId and Empty fingerIdTextBox and Show confirmation sms in MessageBox
                            else if is Many record
                                Show Error in MessageBox telling there are many record with that same Id on current Date

             */
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = @"C:\Users\Public\Pictures\cardImg";
            var dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    file.Delete();
                }
            }
            regDbContext.Dispose();
            Form2.form2.Dispose();
            //Override the Excel File with new record
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool groupeDb = groupe.SelectedIndex == 0 ? false : true;
            byte nGroupe = 1;
            bool IsValidNombreGroupe = byte.TryParse(nombreGroupe.Text, out nGroupe);

            if (!IsValidNombreGroupe)
            {
                MessageBox.Show("Invalid Nombre Groupe");
                return;
            }

            int number;
            int? num;
            bool isANumber = int.TryParse(tel.Text, out number);
            if (isANumber)
            {
                num = number;
            }
            else
            {
                num = null;
            }

            if (fingerId.Text != "" && name.Text != "")
            {
                TrimTextBoxes(fingerId, name, surname, cni, heureEnt, tel, qualite, motifVis, serviceVis);
                var pers = new info()
                {
                    //Id = Convert.ToInt32(num.Text),
                    FingerPrint = fingerId.Text,
                    Name = name.Text,
                    Surname = surname.Text,
                    Cni = cni.Text,
                    HeureEntrer = Convert.ToDateTime(heureEnt.Text),
                    Date = Convert.ToDateTime(date.Text),
                    Tel = num,
                    Qualite = qualite.Text,
                    MotifVisite = motifVis.Text,
                    ServiceVisite = serviceVis.Text,
                    Groupe = groupeDb,
                    Nombre = nGroupe,
                    Note = note.Text,
                };

                regDbContext.infoes.Add(pers);
                regDbContext.SaveChanges();
                MessageBox.Show("Saved Successfully");
                this.name.Text = "";
                surname.Text = "";
                tel.Text = "";
                qualite.Text = "";
                serviceVis.Text = "";
                this.cni.Text = "";
                //this.fingerId.Text = "";
                this.motifVis.Text = "";
                heureEnt.Text = "";
                note.Clear();
                //empty all textboxes
            }
            else
            {
                MessageBox.Show("FingerID or Name must be filled");
            }

            if (textBox1.Text != "")
            {
                FileInfo a = new FileInfo(@"C:\Users\Public\Pictures\cardImg" + textBox1.Text);
                a.Delete();
            }

            //FingerID and Nom must be filled
        }

        private void motifVisCmb_TextChanged(object sender, EventArgs e)
        {
            motifVis.Text = motifVisCmb.Text;
        }

        private void serviceVisCmb_TextChanged(object sender, EventArgs e)
        {
            serviceVis.Text = serviceVisCmb.Text;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                selection.Width = e.X - selection.X;
                selection.Height = e.Y - selection.Y;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                selecting = false;
                selection.Width = e.X - selection.X;
                selection.Height = e.Y - selection.Y;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Cursor == Cursors.Cross)
                if (e.Button == MouseButtons.Left)
                {
                    selecting = true;
                    selection.X = e.X;
                    selection.Y = e.Y;
                    selection.Width = 0;
                    selection.Height = 0;
                    pictureBox1.Refresh();
                }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red))
            {
                pen.DashStyle = DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, selection);
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            selection.Width = 0;
            selection.Height = 0;
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                pictureBoxRegions.Image = null;
                pictureBoxParagraphs.Image = null;
                pictureBoxTextLines.Image = null;
                pictureBoxWords.Image = null;
                pictureBoxComponents.Image = null;
                bool useSelection = selection.Width != 0 && selection.Height != 0;
                if (useSelection)
                {
                    int left, top, right, bottom;
                    PictureBoxToImage(selection.Left, selection.Top, out left, out top);
                    PictureBoxToImage(selection.Right, selection.Bottom, out right, out bottom);
                    ocr1.PictureLeft = left;
                    ocr1.PictureTop = top;
                    ocr1.PictureWidth = right - ocr1.PictureLeft;
                    ocr1.PictureHeight = bottom - ocr1.PictureTop;
                }
                else
                    selection.X = selection.Y = ocr1.PictureLeft = ocr1.PictureTop = ocr1.PictureWidth = ocr1.PictureHeight = 0;

                new Thread(Start).Start();
            }
            else
            {
                MessageBox.Show("No image loaded Check Directory");
            }
        }

        private void PictureBoxToImage(int x, int y, out int imageX, out int imageY)
        {
            var boxHeight = pictureBox1.Height;
            var boxWidth = pictureBox1.Width;
            var boxAspect = (double)boxWidth / boxHeight;

            var imageHeight = pictureBox1.Image.Height;
            var imageWidth = pictureBox1.Image.Width;
            var imageAspect = (double)imageWidth / imageHeight;

            if (boxAspect >= imageAspect)
            {
                // PictureBox is wider and shorter than image
                var zoom = (double)imageHeight / boxHeight;

                imageY = (int)(y * zoom); // zoom height

                var boxDX = x - (double)boxWidth / 2; // calc distance from PictureBox center
                var imageDX = boxDX * zoom; // zoom distance
                imageX = (int)(imageDX + (double)imageWidth / 2); // convert distance back to coordinate
            }
            else
            {
                // PictureBox is taller and thinner than image
                var zoom = (double)imageWidth / boxWidth;

                imageX = (int)(x * zoom); // zoom width

                var boxDY = y - (double)boxHeight / 2; // calc distance from PictureBox center
                var imageDY = boxDY * zoom; // zoom distance
                imageY = (int)(imageDY + (double)imageHeight / 2); // convert distance back to coordinate
            }
        }

        private void Start()
        {
            ocr1.Recognize();
            if (InvokeRequired)
            {
                var invoke = new OcrDelegate(OcrInvoke);
                this.Invoke(invoke, null);
            }
            else
                OcrInvoke();
        }

        private delegate void OcrDelegate();

        private void OcrInvoke()
        {
            textBox8.Text = ocr1.Text.Replace("\xa", "\xd\xa");
            using (var bitmap = new Bitmap(pictureBox1.Image))
            {
                pictureBoxWords.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                if (ocr1.Words != null)
                    using (var g = Graphics.FromImage(pictureBoxWords.Image))
                    {
                        var pen = new Pen(Color.FromArgb(0x00, 0x7F, 0xFF));
                        foreach (var rectangle in ocr1.Words)
                            g.DrawRectangle(pen, ocr1.PictureLeft + rectangle.Left, ocr1.PictureTop + rectangle.Top, rectangle.Width, rectangle.Height);
                    }

                /*pictureBoxRegions.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                if (ocr1.Regions != null)
                    using (var g = Graphics.FromImage(pictureBoxRegions.Image))
                    {
                        var pen = new Pen(Color.FromArgb(0x7F, 0x00, 0xFF));
                        foreach (var rectangle in ocr1.Regions)
                            g.DrawRectangle(pen, ocr1.PictureLeft + rectangle.Left, ocr1.PictureTop + rectangle.Top, rectangle.Width, rectangle.Height);
                    }

                pictureBoxTextLines.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                if (ocr1.TextLines != null)
                    using (var g = Graphics.FromImage(pictureBoxTextLines.Image))
                    {
                        var pen = new Pen(Color.FromArgb(0x00, 0xFF, 0x7F));
                        foreach (var rectangle in ocr1.TextLines)
                            g.DrawRectangle(pen, ocr1.PictureLeft + rectangle.Left, ocr1.PictureTop + rectangle.Top, rectangle.Width, rectangle.Height);
                    }

                pictureBoxComponents.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                if (ocr1.ConnectedComponents != null)
                    using (var g = Graphics.FromImage(pictureBoxComponents.Image))
                    {
                        var pen = new Pen(Color.FromArgb(0xFF, 0x7F, 0x00));
                        foreach (var rectangle in ocr1.ConnectedComponents)
                            g.DrawRectangle(pen, ocr1.PictureLeft + rectangle.Left, ocr1.PictureTop + rectangle.Top, rectangle.Width, rectangle.Height);
                    }

                pictureBoxParagraphs.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                if (ocr1.Paragraphs != null)
                    using (var g = Graphics.FromImage(pictureBoxParagraphs.Image))
                    {
                        var pen = new Pen(Color.FromArgb(0x7F, 0xFF, 0x00));
                        foreach (var paragraph in ocr1.Paragraphs)
                        {
                            var rectangle = paragraph.Location;
                            g.DrawRectangle(pen, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
                        }
                    }*/
            }
            Cursor.Current = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image loaded Check Directory");
                return;
            }

            textBox8.Text = textBox8.Text.Trim();
            int length = textBox8.Text.Length;
            string text = textBox8.Text;
            if (length > 16)
            {
                cni.Text = textBox8.Text.Substring(5, 10);
            }
            else
            {
                MessageBox.Show("No id in the image");
                return;
            }

            int nameLength = length - 30;
            if (nameLength > 0)
            {
                textBox8.Text = textBox8.Text.Substring(nameLength - 1, 31);
            }
            else
            {
                MessageBox.Show("No name in the image");
                return;
            }

            text = textBox8.Text;
            int i = textBox8.Text.IndexOf("<<");
            if (i == -1)
            {
            }
            else
            {
                if (textBox8.Text[i + 2] == '<')
                {
                    name.Text = textBox8.Text.Substring(0, i);
                    name.Text = name.Text.Replace('<', ' ');
                }
                else
                {
                    name.Text = textBox8.Text.Substring(0, i);
                    surname.Text = textBox8.Text.Substring(i + 2);
                    name.Text = name.Text.Replace('<', ' ');
                    surname.Text = surname.Text.Replace('<', ' ');
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richList.Count > 0)
            {
                name.Text = richList[0];
                richList.RemoveAt(0);
                ListInRichText(richList);
            }
            //= richTextBox1.Lines[0].ToString();
            //richTextBox1.Lines[0]=richTextBox1.Lines[0].Remove(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (add == 4)
            {
                MessageBox.Show("Click clear");
                return;
            }

            if (add == 3)
            {
                button13.Enabled = true;
            }

            if (textBox8.Text != "")
            {
                richTextBox1.Text += textBox8.Text;
                richList.Add(richTextBox1.Lines[add]);
                //richTextBox1.Text += '\n';
                ++add;
            }
            else
            {
                MessageBox.Show("TextBox Info is empty");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            add = 0;
            richTextBox1.Clear();
            richList.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (add == 4)
            {
                name.Text = richTextBox1.Lines[0].ToString();
                surname.Text = richTextBox1.Lines[1].ToString();
                cni.Text = richTextBox1.Lines[2].ToString();
                tel.Text = richTextBox1.Lines[3].ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richList.Count > 0)
            {
                tel.Text = richList[0];
                richList.RemoveAt(0);
                ListInRichText(richList);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richList.Count > 0)
            {
                cni.Text = richList[0];
                richList.RemoveAt(0);
                ListInRichText(richList);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //webBrowser1.DocumentStream.;
            if (richList.Count > 0)
            {
                surname.Text = richList[0];
                richList.RemoveAt(0);
                ListInRichText(richList);
            }
        }

        private void qualiteCmb_TextChanged(object sender, EventArgs e)
        {
            qualite.Text = qualiteCmb.Text;
        }

        private void qualiteCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            /*
                On Arduino FingerId Read

                    Select the record of current date
                    Search for the fingerId in the List
                        if fingerId Not exist => is a new record lets continue fill our form // Take Date and Heure Entree
                        else if fingerId exist
                            if is only one record
                                Fill HeureSortie if is 'Empty'' for that fingerId and Empty fingerIdTextBox and Show confirmation sms in MessageBox
                                else do nothing
                            else if is Many record
                                Show Error in MessageBox telling there are many record with that same Id on current Date

            */
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            ValidationError(name, nameVal);
            if (heureEnt.Text == "")
                heureEnt.Text = DateTime.Now.ToLongTimeString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image = RotateImage(pictureBox1.Image, 90);
            else
                MessageBox.Show("No image Loaded");
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
                return;
            string cni = textBox8.Text.Trim();
            var persInDb = regDbContext.infoes.FirstOrDefault(p => p.Cni == cni);
            if (persInDb != null)
            {
                name.Text = persInDb.Name.Trim();
                surname.Text = persInDb.Surname.Trim();
                this.cni.Text = persInDb.Cni.Trim();
                tel.Text = persInDb.Tel.ToString().Trim();
                groupe.SelectedIndex = (persInDb.Groupe == true) ? 1 : 0;
                nombreGroupe.Text = persInDb.Nombre.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            Form3.form3.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        public static void ValidationError(TextBox textBox, Label label)
        {
            if (textBox.Text == "")
            {
                label.Text = textBox.Name + " is Empty";
                label.BackColor = Color.Red;
            }
            else
            {
                label.Text = "";
                //label.BackColor = Color.Black;
            }
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {
            ValidationError(surname, surnameVal);
        }

        private void cni_TextChanged(object sender, EventArgs e)
        {
            ValidationError(cni, cniVal);
        }

        private void heureEnt_TextChanged(object sender, EventArgs e)
        {
            ValidationError(heureEnt, heureEntVal);
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            ValidationError(date, dateVal);
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            ValidationError(tel, telVal);
        }

        private void qualite_TextChanged(object sender, EventArgs e)
        {
            ValidationError(qualite, qualiteVal);
        }

        private void motifVis_TextChanged(object sender, EventArgs e)
        {
            ValidationError(motifVis, motifVisVal);
        }

        private void serviceVis_TextChanged(object sender, EventArgs e)
        {
            ValidationError(serviceVis, serviceVisVal);
        }

        private void groupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupe.SelectedIndex == 1)
            {
                nombreGroupe.Visible = true;
                nombreGroupeVal.Visible = true;
                label16.Visible = true;
            }
            else
            {
                nombreGroupe.Visible = false;
                nombreGroupeVal.Visible = false;
                label16.Visible = false;
                nombreGroupe.Text = "1";
            }
        }

        private void nombreGroupe_TextChanged(object sender, EventArgs e)
        {
            ValidationError(nombreGroupe, nombreGroupeVal);
        }

        private void nombreGroupe_VisibleChanged(object sender, EventArgs e)
        {
            ValidationError(nombreGroupe, nombreGroupeVal);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "ftp://192.168.43.1:2211/DCIM/Camera/" + textBox1.Text;
            selection.Width = 0;
            selection.Height = 0;
            pictureBoxRegions.Image = null;
            pictureBoxParagraphs.Image = null;
            pictureBoxTextLines.Image = null;
            pictureBoxWords.Image = null;
            pictureBoxComponents.Image = null;
            Uri myFile = new Uri("ftp://192.168.43.1:2211/DCIM/Camera/" + textBox1.Text.Trim());
            pictureBox1.Load(myFile.ToString());
            pictureBox1.Image.Save(@"C:\Users\Public\Pictures\cardImg\" + textBox1.Text);

            ocr1.PictureFileName = @"C:\Users\Public\Pictures\cardImg\" + textBox1.Text;
            ocr1.Active = true;
            ocr1.Recognize();
            textBox8.Text = ocr1.Text;
            try
            {
                pictureBox1.Cursor = Cursors.Cross;
            }
            catch (Exception)
            {
                pictureBox1.Cursor = Cursors.Default;
            }

            if (!ocr1.Active)
            {
                ocr1.DataPath = AppDomain.CurrentDomain.BaseDirectory;
                ocr1.Active = true;
            }
            // FileInfo a = new FileInfo(@"C:\Users\Public\Pictures\" + textBox1.Text);
            //a.Delete();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            /*Uri a = new Uri("ftp://192.168.43.1:2211/DCIM");
            webBrowser1.Url = a;
            a = new Uri("ftp://192.168.43.1:2211/DCIM/Camera");
            webBrowser1.Url = a;*/
            webBrowser1.Refresh();
        }

        /*
void ProgressInvoke(int progress)
{
progressBar1.Value = progress;
}
private void ocr_Progress(object sender, Winsoft.Ocr.ProgressEventArgs e)
{
if (progressBar1.InvokeRequired)
{
var invoke = new ProgressDelegate(ProgressInvoke);
this.Invoke(invoke, new object[] { e.Progress });
}
else
ProgressInvoke(e.Progress);
e.Cancel = cancel;
}
delegate void ProgressDelegate(int progress);*/
    }
}