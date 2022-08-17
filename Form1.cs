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
        void ExportToPdf(DataTable tabel ,string path,string header)
        {
            System.IO.FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer= PdfWriter.GetInstance(doc,fs);
            doc.Open();

           

            var tahomaFontFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts),"Tahoma.ttf");
            var tahomaBaseFont = BaseFont.CreateFont(tahomaFontFile, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            var tahomaFont = new Font(tahomaBaseFont, 12);
            var table = new PdfPTable(1)
            {
                RunDirection = PdfWriter.RUN_DIRECTION_RTL
            };
           
            string[] arr = new string[name_of_dep.Items.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                string[] FirstDept = name_of_dep.Items[i].ToString().Split('_');
              
                var phrase1 = new Phrase(Environment.NewLine+"  المرسل اليه   : " + FirstDept[0] +Environment.NewLine+Environment.NewLine + "  الرمز البريدي :" + FirstDept[1] +Environment.NewLine+Environment.NewLine+"  التاريخ  :" +
                   DateTime.Now.ToString("yyyy-MM-dd")+Environment.NewLine+Environment.NewLine+"  المرسل:ديوان وزارة الداخلية /المقر العام /رام الله/الماصيون" +Environment.NewLine
                    +Environment.NewLine+" الرمز البريدي    : P 6028718 " +Environment.NewLine + Environment.NewLine , tahomaFont);

                var cell1 = new PdfPCell(phrase1);
               

                table.AddCell(cell1);
               // lol
            } 

           
            


            doc.Add(table);
            doc.Close();
            writer.Close();
            fs.Close();
            
       
       


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:/PrintDewan/TextFile1.txt");
            StringBuilder builder = new StringBuilder();
            string line = reader.ReadLine();
            while (line != null)
            {
                int first = line.IndexOf(',');
                string name = line.Substring(0, first);
                int Last = line.LastIndexOf(',');
                string id = line.Substring(Last + 1);
                //comboBoxDept.ValueMember =id;
                //comboBoxDept.DisplayMember = name;
                //comboBoxDept.Items.Add(name);


                comboBoxDept.Items.Add(name + "_" + id);
                //+"_" + modria
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
            ExportToPdf(dt, @"C:/PrintDewan/depe.pdf", "depe");

            System.Diagnostics.Process.Start(@"C:/PrintDewan/depe.pdf");
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

        private void clear_all_Click(object sender, EventArgs e)
        {
            name_of_dep.Items.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
