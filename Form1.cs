using System.Windows.Forms.Design;

namespace WinForms1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //�������� �������
        private void Exit(object sender, EventArgs e)
        {
            if ((sender as Control).Text == "�����")
            {
                (sender as Control).Text = "������";
            }
            else
            {
                (sender as Control).Text = "�����";
            }

            textBox.Text += (sender as Control).Name + Environment.NewLine;


            if (chBox.Checked == true)
            {
                (sender as Control).Text = "chBox1";
            }

        }

        private void TextChange(object sender, EventArgs e)
        {
            (sender as Button).Text = "��������";


        }

        string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
            textBox.Text += fileName + Environment.NewLine;
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                textBox.Text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
