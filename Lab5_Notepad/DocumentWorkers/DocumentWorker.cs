using Common; 
using Lab5_Notepad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentWorkers
{
    internal class DocumentWorker : IDocumentWorker
    {
        public string DocumentPath { get; set; }

        public MainForm Form { get; set; }
        public LicenceType LicenceType { get; }
        public DocumentWorker(LicenceType licenceType) => LicenceType = licenceType;

        public DocumentWorker()
        {
        }
        public string OpenDocument()
        {
           return OpenDocument(Form.richTextBox1);
        }
        public virtual string OpenDocument(RichTextBox textBox)
        {
            if (textBox == null) throw new NullReferenceException("RichTextBox is null");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Оберіть файл для відкриття";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var documentPath = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(documentPath, Encoding.Default);
                MessageBox.Show("Документ відкритий");
                return DocumentPath = documentPath;
            }
            return string.Empty;
        }
        public void EditDocument()
        {
            EditDocument(Form.richTextBox1);
        }
        public virtual void EditDocument(RichTextBox textBox)
        {
            if (textBox == null) throw new NullReferenceException("RichTextBox is null");
            if (LicenceType <= LicenceType.Free)
                MessageBox.Show("Правка документа доступна з версії Про");
        }
        public void SaveDocument()
        {
            SaveDocument(Form.richTextBox1, DocumentPath);
        }
        public void SaveDocument(RichTextBox textBox)
        {
            SaveDocument(textBox, DocumentPath);
        }
        public virtual void SaveDocument(RichTextBox textBox, string path)
        {
            if (textBox == null) throw new NullReferenceException("RichTextBox is null");
            if (LicenceType <= LicenceType.Free)
                MessageBox.Show("Збереження документа доступне з версії Про");
        }
    }
}
