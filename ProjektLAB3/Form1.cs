namespace ProjektLAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public DataGridViewRowCollection
            GetDataGrindViewRows()
        {
            return dataGridView1.Rows;
        }

        
    }
}
