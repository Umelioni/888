using DocumentWorkers;
using Lab5_Notepad;

namespace Common
{
    internal static class WorkerInitiliazer
    {
        internal static void Initiliaze(this DocumentWorker documentWorker, MainForm form)
        {
            documentWorker.Form = form;
            string name = "Notepad";
            switch (documentWorker.LicenceType)
            {
                case LicenceType.Pro:
                    name += " // Pro version";
                    break;
                case LicenceType.Expert:
                    name += " // Expert version";
                    break;
                default:
                    name += " // Free version";
                    break;
            }
            documentWorker.Form.Text = name;
        }

    }
}
