namespace XMLWriter
{
    public partial class Form1 : Form
    {
        int actualPage=0;
        const int maxPagine = 5;
        GroupBox[] groups = new GroupBox[maxPagine];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideAllGrpBx();
            setZeroPositionGrpBx();
            setGroupBoxArray();
            init();
        }

        private void init()
        {
            groups[0].Show();
            btnBack.Hide();
            this.Size = new System.Drawing.Size(820, 572);
        }

        private void setGroupBoxArray()
        {
            groups[0] = grpBxDatiTrasmissione;
            groups[1] = grpBxCedentePrestatore;
            groups[2] = grpBxCessionarioCommittente;
            groups[3] = grpBxDatiBeniServizi;
            groups[4] = grpBxDatiGenerali;
        }

        private void setZeroPositionGrpBx()
        {
            grpBxDatiGenerali.Location = new System.Drawing.Point(12, 32);
            grpBxDatiTrasmissione.Location = new System.Drawing.Point(12, 32);
            grpBxCedentePrestatore.Location = new System.Drawing.Point(12, 32);
            grpBxCessionarioCommittente.Location = new System.Drawing.Point(12, 32);
            grpBxDatiBeniServizi.Location = new System.Drawing.Point(12, 32);
            grpBxDatiGenerali.Location = new System.Drawing.Point(12, 32);
        }

        private void hideAllGrpBx()
        {
            grpBxDatiTrasmissione.Hide();
            grpBxCedentePrestatore.Hide();
            grpBxCessionarioCommittente.Hide();
            grpBxDatiBeniServizi.Hide();
            grpBxDatiGenerali.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (actualPage == 4)
            {
                //stampa
            }
            else
            {
                btnBack.Show();actualPage++;
                if (actualPage == 4)
                    btnNext.Text = "Stampa";
                if (actualPage < maxPagine)
                {
                    groups[actualPage - 1].Hide();
                    groups[actualPage].Show();
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNext.Text = "Avanti";
            actualPage--;
            if (actualPage == 0)
                btnBack.Hide();
            if (actualPage > -1)
            {
                groups[actualPage + 1].Hide();
                groups[actualPage].Show();
            }
        }

    }
}