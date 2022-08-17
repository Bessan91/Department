using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dep
{
    public partial class Form1 : Form
    {
        void ExportToPdf(DataTable tabel ,string path,string header  )
        {
            System.IO.FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer= PdfWriter.GetInstance(doc,fs);
            doc.Open();

           

            var tahomaFontFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts),"Tahoma.ttf");
            var tahomaBaseFont = BaseFont.CreateFont(tahomaFontFile, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            var tahomaFont = new Font(tahomaBaseFont, 12);
            var table = new PdfPTable(2)
            {
                RunDirection = PdfWriter.RUN_DIRECTION_RTL
            };
            var phrase = new Phrase("تم إبرام هذا العقد في هذا اليوم [●] م الموافق [●] من قبل وبين .", tahomaFont);
            var cell = new PdfPCell(phrase)
            {
                RunDirection = PdfWriter.RUN_DIRECTION_RTL,
               // Border = 0,
            };
            string[] arr = new string[name_of_dep.Items.Count];
            for (int i = 0; i < arr.Length; i++)
            {

               
            } 

            table.AddCell(cell);
            


            doc.Add(table);
            doc.Close();
            writer.Close();
            fs.Close();
            
        //
       


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:/Users/Bessan/Desktop/TextFile1.txt");
            StringBuilder builder = new StringBuilder();
            string line = reader.ReadLine();
            while (line != null)
            {
                int first = line.IndexOf(',');
                string name = line.Substring(0, first);
                int Last = line.LastIndexOf(',');
                string modria = line.Substring(Last + 1);
                comboBoxDept.Items.Add(name + "_" + modria);
                line = reader.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxDept.SelectedIndex > -1)
            {
               
                    object item = comboBoxDept.SelectedItem;
                    name_of_dep.Items.Add(item);
                    comboBoxDept.Items.Remove(item);


              
              
            }
            else
            {
                string message = "الرجاء اختيار جهة المراسلة ";


                MessageBox.Show(message);

            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            ExportToPdf(dt, @"C:/Users/Bessan/Desktop/depe.pdf", "depe");

            System.Diagnostics.Process.Start(@"C:/Users/Bessan/Desktop/depe.pdf");
            this.WindowState=System.Windows.Forms.FormWindowState.Maximized;    


          
            string[] arr = new string[name_of_dep.Items.Count];

      

            if (name_of_dep.Items.Count < 1)
            {
                string message = " !!!!قم باختيار المديريات المطلوبة";
                MessageBox.Show(message);
            }
        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
