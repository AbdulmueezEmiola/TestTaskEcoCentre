using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace TestTaskEcoCentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select XML File to be displayed";
            openFileDialog.Filter = "XML| *.xml";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PopulateDataGridFromXml(openFileDialog.FileName);
            }
        }

        private void PopulateDataGridFromXml(string filename)
        {  
            
            DataTable dt = new DataTable();
            dt.Columns.Add("title", typeof(string));
            dt.Columns.Add("author", typeof(string));
            dt.Columns.Add("category", typeof(string));
            dt.Columns.Add("price", typeof(Decimal));
            dt.Columns.Add("year", typeof(int));
            dt.Columns.Add("lang", typeof(string));
            //In the image we were asked to design, there were no columns for year and lang, they were added to allow the user to input their values when adding new row
            XDocument doc = XDocument.Load(filename);
           
            foreach (XElement book in doc.Descendants().Where(x => x.Name.LocalName == "book"))
            {
                string authors = string.Empty;
                foreach (XElement author in book.Descendants().Where(x => x.Name.LocalName == "author"))
                {
                    authors += author.Value +";";
                }
                authors = authors.Remove(authors.Length - 1);
                dt.Rows.Add(new object[]
                {
                    (string)book.Element("title"),
                    authors,
                    book.Attribute("category").Value,
                    (string)book.Element("price"),
                    (string)book.Element("year"),
                    (string)book.Element("title").Attribute("lang").Value
                });
            }
            XmlDisplayDataGridView.DataSource = dt;
            XmlDisplayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save XML file";
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = (DataTable)XmlDisplayDataGridView.DataSource;
                    XDocument doc = GenerateXDocumentFromTable(dt);
                    doc.Save(sfd.FileName);                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private XDocument GenerateXDocumentFromTable(DataTable dt)
        {
            XElement bookstore = new XElement("bookstore");
            foreach(DataRow row in dt.Rows)
            {
                XElement book = new XElement("book");
                XAttribute category =  null;
                XAttribute lang = null;
                foreach(DataColumn column in dt.Columns)
                {
                    if(column.ColumnName == "category")
                    {
                        category = new XAttribute(column.ColumnName, row[column].ToString());
                        continue;
                    }
                    else if(column.ColumnName == "lang")
                    {
                        lang = new XAttribute(column.ColumnName, row[column].ToString());
                        continue;
                    }
                    IEnumerable<XElement> element = GetElement( row[column].ToString(), column.ColumnName);
                    book.Add(element);                    
                }
                book.Add(category);
                book.Element("title").Add(lang);
                bookstore.Add(book);
            }
            XDocument doc = new XDocument(bookstore);
            return doc;
        }

        //mainly It helps to separate the different authors  into different XELements, but was built to serve for any of the other columns
        private IEnumerable<XElement> GetElement(string value, string name)
        {
            string[] elementArray = value.Split(';');
            foreach(string singleValue in elementArray)
            {
                yield return new XElement(name, singleValue);
            }
        }

        
        private void TransformXmlDocumentToHtml(XDocument xmlFile,string xslFile, string htmlFile)
        {
            try
            {
                var xslt = new XslCompiledTransform();
                using(var writer = XmlWriter.Create(htmlFile))
                {
                    xslt.Load(xslFile);
                    xslt.Transform(xmlFile.CreateReader(ReaderOptions.None), writer);
                }
            }catch(Exception)
            {
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)XmlDisplayDataGridView.DataSource;
            dt.Rows.Add();
        }
        
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string xsl = @"C:\Users\emiol\source\repos\TestTaskEcoCentre\TestTaskEcoCentre\Style.xslt";
            DataTable dt = (DataTable)XmlDisplayDataGridView.DataSource;
            //Here, what i did was i generated the Xml file directly from the datagridview first before converting, 
            //I did these because It has the added benefit of allowing the user to generate the html from the edits they made to the table without needing to store the table first.
            XDocument doc = GenerateXDocumentFromTable(dt);
            TransformXmlDocumentToHtml(doc, xsl, "temp.Html");
            System.Diagnostics.Process.Start(@"temp.Html");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)XmlDisplayDataGridView.DataSource;
            foreach (DataGridViewRow item in XmlDisplayDataGridView.SelectedRows)
            {
                dt.Rows.RemoveAt(item.Index);
            }
        }

        private void XmlDisplayDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            //the buttons were disabled initially because the operations can only be performed on a datagrid that has been filled. 
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
            buttonConvert.Enabled = true;
            saveXmlButton.Enabled = true;
        }
    }
}
