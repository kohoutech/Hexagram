/* ----------------------------------------------------------------------------
Hexagram : a hexadecimal file editor
Copyright (C) 1998-2020  George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Hexagram.UI;

namespace Hexagram
{
    public partial class HexWindow : Form
    {
        String currentPath;

        public HexWindow()
        {
            InitializeComponent();
        }

//-----------------------------------------------------------------------------

        public void openFile(String filename)
        {
            hexStatusLabel.Text = "Loading...";
            closeFile();
            hexEditor.loadSourceFile(filename);
            Text = "Hexagram [" + filename + "]";
            hexStatusLabel.Text = "";
        }

        public void closeFile()
        {
        }

        private void showOpenFileDialog()
        {
            String filename = "";
            if (currentPath != null)
            {
                hexOpenFileDialog.InitialDirectory = currentPath;
            }
            else
            {
                hexOpenFileDialog.InitialDirectory = Application.StartupPath;
            }
            hexOpenFileDialog.FileName = "";
            hexOpenFileDialog.DefaultExt = "*.*";
            hexOpenFileDialog.Filter = "All files|*.*";
            hexOpenFileDialog.ShowDialog();
            filename = hexOpenFileDialog.FileName;
            if (filename.Length != 0)
            {
                currentPath = Path.GetDirectoryName(filename);
                openFile(filename);
            }
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            showOpenFileDialog();
        }

        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

//-----------------------------------------------------------------------------

        private void aboutHelpMenuItem_Click(object sender, EventArgs e)
        {
            String msg = "Hexagram\nThe 49th Hexagram of Change\nversion 1.0.0\n\n" + "\xA9 Origami Software 1998-2020\n" + "http://origami.kohoutech.com";
            MessageBox.Show(msg, "About");
        }
    }
}
