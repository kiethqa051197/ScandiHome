using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScandiHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            ReadWriteINIfile readWriteINIfile = new ReadWriteINIfile(Path.Combine(path, "AppConfig.INI"));

            textBox1.Text = readWriteINIfile.ReadINI("Connection", "DBConnection");
            textBox2.Text = readWriteINIfile.ReadINI("Connection", "User");
            textBox3.Text = readWriteINIfile.ReadINI("Connection", "Pass");
        }
    }
}
