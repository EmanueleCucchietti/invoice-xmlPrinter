using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Text.RegularExpressions;
using XMLWriter;

namespace XMLWriter
{
    class XmlWriting
    {
        DatiTrasmissione Data1;
        CedentePrestatore Data2;
        CessionarioCommittente Data3;
        DatiGenerali Data4;
        DatiBeniServizi Data5;

        private XmlTextWriter writer;
        private string name = "fattura.xml";
        public XmlWriting(DatiTrasmissione data1, CedentePrestatore data2, CessionarioCommittente data3, DatiGenerali data4, DatiBeniServizi data5)
        {
            this.Data1 = data1;
            this.Data2 = data2;
            this.Data3 = data3;
            this.Data4 = data4;
            this.Data5 = data5;
            writer = new XmlTextWriter(name, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
        }
        public void creaFattura()
        {
            writer.WriteStartElement("p:FatturaElettronica");
            writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
            writer.WriteAttributeString("xmlns:p", "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2");
            writer.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            writer.WriteAttributeString("xsi:schemaLocation", "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2 http://www.fatturapa.gov.it/export/fatturazione/sdi/fatturapa/v1.2/Schema_del_file_xml_FatturaPA_versione_1.2.xsd");

            writeXmlInnerTags();

            writer.WriteEndElement();
            writer.Close();
        }
        private void writeXmlInnerTags()
        {
            writer.WriteStartElement("FatturaELeetronicaHeader");
            writeDatiTrasmissione();
            writeCedentePrestatore();
            writeCessionarioCommittente();
            writer.WriteEndElement();
            writer.WriteStartElement("FatturaELettronicaBody");
            writeDatiBeniServizi();
            writeDatiGenerali();
            writer.WriteEndElement();
        }

        private void writeDatiTrasmissione()
        {
            writer.WriteStartElement("DatiTrasmissione"); /*DATI TRASMISSIONE*/

            writer.WriteStartElement("IdTrasmittente"); /*ID TRASMITTENTE*/
            writer.WriteElementString("IdPaese", Data1.IdPaese);
            writer.WriteElementString("IdCodice", Data1.IdCodice);
            writer.WriteEndElement(); /*ID TRASMITTENTE*/
            writer.WriteElementString("ProgressivoInvio", Data1.ProgressivoInvio);
            writer.WriteElementString("FormatoTrasmissione", Data1.FormatoTrasmissione);
            writer.WriteElementString("CodiceDestinatario", Data1.CodiceDestinatario);

            writer.WriteEndElement(); /*DATI TRASMISSIONE*/
        }
        private void writeCedentePrestatore()
        {
            writer.WriteStartElement("CedentePrestatore");/*CEDENTE PRESTATORE*/
            writer.WriteStartElement("DatiAnagrafici");/*DATI ANAGRAFICI*/
            writer.WriteStartElement("IdFiscaleIVA");/*ID FISCALE IVA*/
            writer.WriteElementString("IdPaese",Data2.IdPaese);
            writer.WriteElementString("IdCodice",Data2.IdCodice);
            writer.WriteEndElement();/*ID FISCALE IVA*/
            writer.WriteElementString("RegimeFiscale",Data2.RegimeFiscale);
            writer.WriteEndElement();/*DATI ANAGRAFICI*/

            writer.WriteStartElement("Sede");/*SEDE*/
            writer.WriteElementString("Indirizzo", Data2.Indirizzo);
            writer.WriteElementString("CAP", Data2.CAP);
            writer.WriteElementString("Comune", Data2.Comune);
            writer.WriteElementString("Nazione", Data2.Nazione);
            writer.WriteEndElement();/*SEDE*/
            writer.WriteEndElement();/*CEDENTE PRESTATORE*/
        }
        private void writeCessionarioCommittente()
        {
            writer.WriteStartElement("CessionarioCommittente");/*CESSIONARIO COMMITTENTE*/

            writer.WriteStartElement("Sede");/*SEDE*/
            writer.WriteElementString("Indirizzo", Data3.Indirizzo);
            writer.WriteElementString("CAP", Data3.CAP);
            writer.WriteElementString("Comune", Data3.Comune);
            writer.WriteElementString("Nazione", Data3.Nazione);
            writer.WriteEndElement();/*SEDE*/

            writer.WriteEndElement();/*CESSIONARIO COMMITTENTE*/
        }
        private void writeDatiBeniServizi()
        {
            writer.WriteStartElement("DatiBeniServizi");/*DatiBeniServizi*/
            writer.WriteStartElement("DettaglioLinee");/*DettaglioLinee*/
            writer.WriteElementString("NumeroLinea", Data5.NumeroLinea);
            writer.WriteElementString("Descrizione", Data5.Descrizione);
            writer.WriteElementString("PrezzoTotale", Data5.PrezzoTotale);
            writer.WriteElementString("AliquotaIva", Data5.AliquotaIva);
            writer.WriteElementString("AliquotaIva2", Data5.AliquotaIva2);
            writer.WriteElementString("ImponibileImporto", Data5.ImponibileImporto);
            writer.WriteElementString("Imposta", Data5.Imposta);
            writer.WriteEndElement();/*DettaglioLinee*/

            writer.WriteEndElement();/*DatiBeniServizi*/
        }
        private void writeDatiGenerali()
        {
            writer.WriteStartElement("DatiGenerali");

            writer.WriteStartElement("DatiGeneraliDocumento");
            writer.WriteElementString("TipoDocumento", Data4.TipoDocumento);
            writer.WriteElementString("Divisa", Data4.Divisa);
            writer.WriteElementString("Data", Data4.Data.ToString());
            writer.WriteElementString("Numero", Data4.Numero);
            writer.WriteEndElement();//Dati generali documento

            writer.WriteEndElement();//Dati generali
        }
    }
}
