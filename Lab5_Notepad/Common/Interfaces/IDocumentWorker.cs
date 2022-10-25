using Common;
using System.Windows.Forms;

namespace DocumentWorkers
{
    public interface IDocumentWorker
    {
        LicenceType LicenceType { get; }
        string OpenDocument(RichTextBox textBox);
        void EditDocument(RichTextBox textBox);
        void SaveDocument(RichTextBox textBox, string path);
    }
}
