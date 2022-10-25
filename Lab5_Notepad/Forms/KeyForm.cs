using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentWorkers;

namespace Lab5_Notepad
{
    public partial class KeyForm : Form
    {
        readonly MainForm form;
        public KeyForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        const string proKey = "j2XXkeXcpn";
        const string expertKey = "Y7psKPbJ4G";

        private void nextButton_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case proKey:
                    form.Initialize(new ProDocumentWorker());
                    break;
                case expertKey:
                    form.Initialize(new ExpertDocumentWorker());
                    break;
                default:
                    form.Initialize(new DocumentWorker());
                    break;
            }
            Hide();
        }
    }
}
