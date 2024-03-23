using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROJECT_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calculator = new Calculator();
        Filecsv filecsv = new Filecsv();
        List<Data> listdata = new List<Data>();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //รายจ่าย
        private void BTexpenses_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            DateTime dateTime = dateTimePicker1.Value;
            calculator.sumofexp(int.Parse(tbfillinprice.Text));
            data.number = calculator.addcount();
            data.day = dateTime.ToString("dd/MM/yyyy");
            data.schedule = tbNOTE.Text;
            data.expenses = (int.Parse(tbfillinprice.Text));
            data.remain = calculator.Remain();
            table.Rows.Add(data.number, dateTime.ToString("dd/MM/yyyy"), tbNOTE.Text, "", tbfillinprice.Text, calculator.Remain());
            tbfillinprice.Text = string.Empty;
            tbNOTE.Text = string.Empty;
            listdata.Add(data);

        }

        //รายรับ
        private void BTrevenue_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            DateTime dateTime = dateTimePicker1.Value;
            calculator.sumofrev(int.Parse(tbfillinprice.Text));
            data.number = calculator.addcount();
            data.day = dateTime.ToString("dd/MM/yyyy");
            data.schedule = tbNOTE.Text;
            data.revenue = (int.Parse(tbfillinprice.Text));
            data.remain = calculator.Remain();
            table.Rows.Add(data.number, dateTime.ToString("dd/MM/yyyy"), tbNOTE.Text, tbfillinprice.Text, "", calculator.Remain()); ;
            tbfillinprice.Text = string.Empty;
            tbNOTE.Text = string.Empty;
            listdata.Add(data);
        }


        private void NUM1_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "1";
        }

        private void NUM2_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "2";
        }

        private void NUM3_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "3";
        }

        private void NUM4_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "4";
        }

        private void NUM5_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "5";
        }

        private void NUM6_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "6";
        }

        private void NUM7_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "7";
        }

        private void NUM8_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "8";
        }

        private void NUM9_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "9";
        }

        private void NUM0_Click(object sender, EventArgs e)
        {
            tbfillinprice.Text = tbfillinprice.Text + "0";
        }

        private void tbmemo_Click(object sender, EventArgs e)
        {
            bool can = filecsv.wrifile(listdata);
            if (!can)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("Correctly");

            }
        }
    }
}
