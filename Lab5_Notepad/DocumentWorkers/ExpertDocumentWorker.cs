using System.IO;
using System.Windows.Forms;
using Common;

namespace DocumentWorkers
{
    internal class ExpertDocumentWorker : DocumentWorker
    {
        public ExpertDocumentWorker() : base(LicenceType.Expert) { }
        public override void EditDocument(RichTextBox textBox)
        {
            base.EditDocument(textBox);
            textBox.ReadOnly = false;
        }
        public override void SaveDocument(RichTextBox textBox, string path)
        {
            base.SaveDocument(textBox, path);
            File.WriteAllText(Path.ChangeExtension(path, "new"), textBox.Text, System.Text.Encoding.Default);
            MessageBox.Show("Документ збережено у новому форматі!");
        }
    }
}
