using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class menu : Form
    {
        private int childFormNumber = 0;

        public menu()
        {
            InitializeComponent();
           if (Utilidades.Utilidades.Acceso==1)
           MantMenu.Visible = false;
           
         }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ejemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBase obj = new FormBase();
            obj.MdiParent = this;
            obj.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MantCli obj = new MantCli();
            obj.MdiParent = this;
            obj.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantDep obj = new MantDep();
            obj.MdiParent = this;
            obj.Show();

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        MantArt obj = new MantArt();
        obj.MdiParent = this;
        obj.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsCli obj = new ConsCli();
            obj.MdiParent = this;
            obj.Show();
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsDep obj = new ConsDep();
            obj.MdiParent = this;
            obj.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsArt obj = new ConsArt();
            obj.MdiParent = this;
            obj.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsSup obj = new ConsSup();
            obj.MdiParent = this;
            obj.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantSup obj = new MantSup();
            obj.MdiParent = this;
            obj.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantUni obj = new MantUni();
            obj.MdiParent = this;
            obj.Show();
        }

        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsUni obj = new ConsUni();
            obj.MdiParent = this;
            obj.Show();
        }

        private void gupoArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            GrupMant obj = new GrupMant();
            obj.MdiParent = this;
            obj.Show();
        }

        private void gruposArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsGruArt obj = new ConsGruArt();
            obj.MdiParent = this;
            obj.Show();
        }

        private void correoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviarCorreo obj = new EnviarCorreo();
            obj.MdiParent = this;
            obj.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantUsu obj = new MantUsu();
            obj.MdiParent = this;
            obj.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsUsu obj = new ConsUsu();
            obj.MdiParent = this;
            obj.Show();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)!=DialogResult.Yes)
            {
                e.Cancel = true;        
            }
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas obj = new FormVentas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormCompras obj = new FormCompras();
            obj.MdiParent = this;
            obj.Show();

        }
    }               

 }

