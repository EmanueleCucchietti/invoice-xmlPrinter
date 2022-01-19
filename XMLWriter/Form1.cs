using XMLWriter;

namespace XMLWriter
{
    public partial class Form1 : Form
    {
        int actualPage=0;
        const int maxPagine = 5;
        GroupBox[] groups = new GroupBox[maxPagine];

        DatiTrasmissione data1 = new DatiTrasmissione();
        CedentePrestatore data2 = new CedentePrestatore();
        CessionarioCommittente data3 = new CessionarioCommittente();
        DatiGenerali data4 = new DatiGenerali();
        DatiBeniServizi data5 = new DatiBeniServizi();

        int nLinee=0;
        int nRiepilogo=0;

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
            groups[3] = grpBxDatiGenerali;
            groups[4] = grpBxDatiBeniServizi;
        }

        private void setZeroPositionGrpBx()
        {
            grpBxDatiGenerali.Location = new System.Drawing.Point(12, 32);
            grpBxDatiTrasmissione.Location = new System.Drawing.Point(12, 32);
            grpBxCedentePrestatore.Location = new System.Drawing.Point(12, 32);
            grpBxCessionarioCommittente.Location = new System.Drawing.Point(12, 32);
            grpBxDatiGenerali.Location = new System.Drawing.Point(12, 32);
            grpBxDatiBeniServizi.Location = new System.Drawing.Point(12, 32);
        }

        private void hideAllGrpBx()
        {
            grpBxDatiTrasmissione.Hide();
            grpBxCedentePrestatore.Hide();
            grpBxCessionarioCommittente.Hide();
            grpBxDatiGenerali.Hide();
            grpBxDatiBeniServizi.Hide();
            
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (actualPage == 4)
            {
                //stampa
                saveDatas();
                XmlWriting writer = new XmlWriting(data1,data2,data3,data4,data5);
                writer.creaFattura();
                MessageBox.Show("stampato");
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

        private void saveDatas()
        {
            saveDatiTrasmissione();
            saveCedentePrestatore();
            saveCessionarioCommittente();
            saveDatibeniservizi();
            saveDatiGenerali();
        }

        private void saveDatibeniservizi()
        {
            data5.NumeroLinea = Convert.ToInt32(pg4txtNumeroLinea.Text);
            data5.Descrizione = pg4txtDescrizione.Text;
            data5.PrezzoTotale = Convert.ToInt32(pg4txtPrezzoTotale.Text);
            data5.AliquotaIva = Convert.ToInt32(pg4txtAliquotaIva.Text);
            data5.AliquotaIva2 = Convert.ToInt32(pg4txtAliquotaIva2.Text);
            data5.ImponibileImporto = Convert.ToInt32(pg4txtImponibileImporto.Text);
            data5.Imposta = Convert.ToInt32(pg4txtImposta.Text);
        }

        private void saveDatiTrasmissione()
        {   
            data1.IdPaese = pg1txtIdPaese.Text;
            data1.IdCodice = pg1txtIdCodice.Text;
            data1.ProgressivoInvio = pg1txtProgressivoInvio.Text;
            data1.FormatoTrasmissione = pg1cmbFormatoTrasmissione.Text;
            data1.CodiceDestinatario = pg1txtCodiceDestinatario.Text;
        }
        private void saveCedentePrestatore()
        {
            data2.IdPaese = pg2txtIdPaese.Text;
            data2.IdCodice = pg2txtIdCodice.Text;
            data2.Denominazione = pg2txtDenominazione.Text;
            data2.RegimeFiscale = pg2txtRegimeFiscale.Text;
            data2.Indirizzo = pg2txtIndirizzo.Text;
            data2.CAP = pg2txtCAP.Text;
            data2.Comune = pg2txtComune.Text;
            data2.Nazione = pg2txtNazione.Text;
        }
        private void saveCessionarioCommittente()
        {
            data3.Indirizzo = pg3txtIndirizzo.Text;
            data3.CAP = pg3txtCAP.Text;
            data3.Comune = Convert.ToInt32(pg3txtComune.Text);
            data3.Nazione = pg3txtNazione.Text;
        }
        private void saveDatiGenerali()
        {
            data4.TipoDocumento = pg5txtTipoDocumento.Text;
            data4.Divisa = pg5cmbDivisa.Text;
            data4.Data = pg5dtpData.Value;
            data4.Numero = Convert.ToInt32(pg5txtNumero.Text);
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