using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLWriter
{
    class DatiTrasmissione
    {
        public string IdPaese;
        public string IdCodice;
        public string ProgressivoInvio;
        public string FormatoTrasmissione;
        public string CodiceDestinatario;
    }
    class CedentePrestatore
    {
        public string IdPaese;
        public string IdCodice;
        public string Denominazione;
        public string RegimeFiscale;

        public string Indirizzo;
        public string CAP;
        public string Comune;
        public string Nazione;
    }
    public class CessionarioCommittente
    {
        public string Indirizzo;
        public string CAP;
        public int Comune;
        public string Nazione;
    }
    public class DatiGenerali
    {
        public string TipoDocumento;
        public string Divisa;
        public DateTime Data;
        public int Numero;
    }
    public class DatiBeniServizi
    {
        public int NumeroLinea;
        public string Descrizione;
        public int PrezzoTotale;
        public int AliquotaIva;
        public int AliquotaIva2;
        public int ImponibileImporto;
        public int Imposta;
    }
}
