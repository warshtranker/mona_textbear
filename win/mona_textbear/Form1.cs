using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mona_textbear {
    public partial class mtxtbr:Form {
        public mtxtbr() {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender,KeyEventArgs e) {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text=currentContainer.Text.ToUpper();
            currentContainer.SelectionStart=caretPosition++;
        }
    }
}
