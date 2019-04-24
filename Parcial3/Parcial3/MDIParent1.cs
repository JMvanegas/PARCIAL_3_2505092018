using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 hijo = new Form2();
            hijo.Show();
        }

        private void calculoPorcentajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hijo = new Form3();
            hijo.Show();
        }
    }
}
