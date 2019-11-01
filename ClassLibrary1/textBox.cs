using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class textBox : TextBox
    {
        public textBox()
        {
            InitializeComponent();
        }

        public bool Validar { set; get; }

        public textBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                SendKeys.Send("{tab}");

        }
    }
}
