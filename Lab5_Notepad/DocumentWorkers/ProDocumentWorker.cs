using System.IO;
using System.Windows.Forms;
using Common;
using Lab5_Notepad;

namespace DocumentWorkers
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker() : base(LicenceType.Pro) { }
        public override void EditDocument(RichTextBox textBox)
        {
            base.EditDocument(textBox);
            textBox.ReadOnly = false;
        }
        public override void SaveDocument(RichTextBox textBox, string path)
        {
            base.SaveDocument(textBox, path);
            File.WriteAllText(Path.ChangeExtension(path, "old"), textBox.Text, System.Text.Encoding.ASCII);
            MessageBox.Show("Документ збережено у старому форматі!");
        }
    }
}
