namespace XMLWriter
{
    public partial class Form1 : Form
    {
        int actualPage;
        const int maxPagine = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpBxDatiTrasmissione.Hide();
            grpBxCedentePrestatore.Hide();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (actualPage < maxPagine - 1)
            {
                actualPage++;
            }
            else
            {
                MessageBox.Show("n max raggiunto");
                //slideConferma
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (actualPage > 1)
            {
                actualPage--;
            }
            else
            {
                MessageBox.Show("n min raggiunto");
                //slideConferma
            }
        }
    }
}