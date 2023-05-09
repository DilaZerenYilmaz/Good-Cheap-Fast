namespace Good_Cheap_Fast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Random rnd = new Random(2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else
            {
                if (checkBox2.Checked == true && checkBox3.Checked == true)
                    checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                checkBox1.Checked = true;
                checkBox3.Checked = true;
            }
            else
            {
                if (checkBox1.Checked == true && checkBox3.Checked == true)
                    checkBox1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }
            else
            {
                if (checkBox2.Checked == true && checkBox1.Checked == true)
                    checkBox1.Checked = false;
            }
        }
    }
}