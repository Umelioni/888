using DocumentWorkers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Lab5_Notepad
{
    public partial class MainForm : Form
    {
        private DocumentWorker worker;
        public MainForm()
        {
            Hide();
        }

        internal void Initialize(DocumentWorker documentWorker)
        {
            InitializeComponent();
           
            Enabled = true;
            Opacity = 100;
            (worker = documentWorker).Initiliaze(this);
            Show();
            

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            worker.DocumentPath = worker.OpenDocument();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            worker.EditDocument();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            worker.SaveDocument();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
