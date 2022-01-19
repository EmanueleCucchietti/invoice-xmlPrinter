using XMLWriter;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XMLWriter
{
    public partial class Form1 : Form
    {
        int actualPage=0;
        const int maxPagine = 5;
        int correctPages = 0;
        GroupBox[] groups = new GroupBox[maxPagine];

        DatiTrasmissione data1 = new DatiTrasmissione();
        CedentePrestatore data2 = new CedentePrestatore();
        CessionarioCommittente data3 = new CessionarioCommittente();
        DatiGenerali data4 = new DatiGenerali();
        DatiBeniServizi data5 = new DatiBeniServizi();

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
            pg1cmbFormatoTrasmissione.SelectedIndex = 0;
            pg2cmbRegimeFiscale.SelectedIndex = 0;
            pg5cmbDivisa.SelectedIndex = 0;
            pg5cmbTipoDocumento.SelectedIndex = 0;
            setTextboxRedForecolor();
            assignTextChanged();
        }

        private void setTextboxRedForecolor()
        {
            foreach(Control groupBoxes in this.Controls.OfType<GroupBox>())
            {
                foreach(Control textboxes in groupBoxes.Controls.OfType<TextBox>())
                {
                    textboxes.ForeColor = Color.Red;
                }
            }
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
                MessageBox.Show("test");
                //stampa
                if (controlloRegex())
                {
                    saveDatas();
                    XmlWriting writer = new XmlWriting(data1, data2, data3, data4, data5);
                    writer.creaFattura();
                    MessageBox.Show("stampato");
                }
                else
                {
                    MessageBox.Show("Sono presenti degli errori nei campi inseriti");
                }
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

        private bool controlloRegex()
        {
            correctPages = 0;
            Parallel.Invoke(
                verifyDatiTrasmissione,
                verifyCedentePrestatore,
                verifyCessionarioCommitente,
                verifyDatiBeniServizi,
                verifyDatiGenerali
                );
            if(correctPages == 5)
                return true;
            return false;
        }

        private void verifyDatiTrasmissione()
        {
            bool correctRegex = true;
            foreach(Control textbox in groups[0].Controls)
            {
                if (textbox.ForeColor == Color.Red)
                {
                    correctRegex = false;
                    break;
                }
            }
            if(correctRegex)
                correctPages++;
        }

        private void verifyCedentePrestatore()
        {
            bool correctRegex = true;
            foreach (Control textbox in groups[1].Controls)
            {
                if (textbox.ForeColor == Color.Red)
                {
                    correctRegex = false;
                    break;
                }
            }
            if (correctRegex)
                correctPages++;
        }
        private void verifyCessionarioCommitente()
        {
            bool correctRegex = true;
            foreach (Control textbox in groups[2].Controls)
            {
                if (textbox.ForeColor == Color.Red)
                {
                    correctRegex = false;
                    break;
                }
            }
            if (correctRegex)
                correctPages++;
        }
        private void verifyDatiBeniServizi()
        {
            bool correctRegex = true;
            foreach (Control textbox in groups[3].Controls)
            {
                if (textbox.ForeColor == Color.Red)
                {
                    correctRegex = false;
                    break;
                }
            }
            if (correctRegex)
                correctPages++;
        }
        private void verifyDatiGenerali()
        {
            bool correctRegex = true;
            foreach (Control textbox in groups[4].Controls)
            {
                if (textbox.ForeColor == Color.Red)
                {
                    correctRegex = false;
                    break;
                }
            }
            if (correctRegex)
                correctPages++;
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
            data5.NumeroLinea =pg4txtNumeroLinea.Text;
            data5.Descrizione = pg4txtDescrizione.Text;
            data5.PrezzoTotale = pg4txtPrezzoTotale.Text;
            data5.AliquotaIva = pg4txtAliquotaIva.Text;
            data5.AliquotaIva2 = pg4txtAliquotaIva2.Text;
            data5.ImponibileImporto = pg4txtImponibileImporto.Text;
            data5.Imposta = pg4txtImposta.Text;
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
            data2.RegimeFiscale = pg2cmbRegimeFiscale.Text;
            data2.Indirizzo = pg2txtIndirizzo.Text;
            data2.CAP = pg2txtCAP.Text;
            data2.Comune = pg2txtComune.Text;
            data2.Nazione = pg2txtNazione.Text;
        }
        private void saveCessionarioCommittente()
        {
            data3.Indirizzo = pg3txtIndirizzo.Text;
            data3.CAP = pg3txtCAP.Text;
            data3.Comune = pg3txtComune.Text;
            data3.Nazione = pg3txtNazione.Text;
        }
        private void saveDatiGenerali()
        {
            data4.TipoDocumento = pg5cmbTipoDocumento.Text;
            data4.Divisa = pg5cmbDivisa.Text;
            data4.Data = pg5dtpData.Value;
            data4.Numero = pg5txtNumero.Text;
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
        private void assignTextChanged()
        {
            this.pg1txtIdPaese.TextChanged += regex2CharAA_TextChanged;
            this.pg2txtIdPaese.TextChanged += regex2CharAA_TextChanged;
            this.pg2txtNazione.TextChanged += regex2CharAA_TextChanged;
            this.pg3txtNazione.TextChanged += regex2CharAA_TextChanged;

            this.pg4txtNumeroLinea.TextChanged += regexNumericFloat_TextChanged;
            this.pg4txtPrezzoTotale.TextChanged += regexNumericFloat_TextChanged;
            this.pg4txtAliquotaIva.TextChanged += regexNumericFloat_TextChanged;
            this.pg4txtAliquotaIva2.TextChanged += regexNumericFloat_TextChanged;
            this.pg4txtImponibileImporto.TextChanged += regexNumericFloat_TextChanged;
            this.pg4txtImposta.TextChanged += regexNumericFloat_TextChanged;

            this.pg4txtDescrizione.TextChanged += regexNumericChar_TextChanged;
            this.pg1txtProgressivoInvio.TextChanged += regexNumericChar_TextChanged;
            this.pg1txtIdCodice.TextChanged += regexNumericChar_TextChanged;
            this.pg2txtIdCodice.TextChanged += regexNumericChar_TextChanged;
            this.pg2txtIndirizzo.TextChanged += regexNumericChar_TextChanged;
            this.pg3txtIndirizzo.TextChanged += regexNumericChar_TextChanged;
            this.pg2txtComune.TextChanged += regexNumericChar_TextChanged;
            this.pg3txtComune.TextChanged += regexNumericChar_TextChanged;
            this.pg1txtCodiceDestinatario.TextChanged += regexNumericChar_TextChanged;

            this.pg2txtCAP.TextChanged += regexCap_TextChanged;
            this.pg3txtCAP.TextChanged += regexCap_TextChanged;

            this.pg5txtNumero.TextChanged += regexNumeric20;
        }

        private void regexNumeric20(object? sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{1,20}$");
            TextBox txt = (TextBox)sender;
            if (!regex.IsMatch(txt.Text) || txt.Text == "")
                txt.ForeColor = Color.Red;
            else
                txt.ForeColor = Color.Black;
        }

        private void regexCap_TextChanged(object? sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{5}$");
            TextBox txt = (TextBox)sender;
            if (!regex.IsMatch(txt.Text) || txt.Text == "")
                txt.ForeColor = Color.Red;
            else
                txt.ForeColor = Color.Black;
        }

        private void regexNumericChar_TextChanged(object? sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9a-z-A-Z]+$");
            TextBox txt = (TextBox)sender;
            if (!regex.IsMatch(txt.Text) || txt.Text == "")
                txt.ForeColor = Color.Red;
            else
                txt.ForeColor = Color.Black;
        }

        private void regex2CharAA_TextChanged(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            Regex regex = new Regex(@"^[A-Za-z]{2}$");
            if (regex.IsMatch(txt.Text) || txt.Text == "")
                txt.ForeColor = Color.Black;
            else
                txt.ForeColor = Color.Red;
        }
        private void regexNumericFloat_TextChanged(object? sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+(\.*[0-9]+)*$");
            TextBox txt = (TextBox)sender;
            if (!regex.IsMatch(txt.Text) || txt.TextLength < 4 || txt.Text == "")
                txt.ForeColor = Color.Red;
            else
                txt.ForeColor = Color.Black;
        }
        private void pg1txtProgressivoInvio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}