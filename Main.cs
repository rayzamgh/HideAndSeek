using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hide_and_Seek
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Control label1 = this.Controls["label1"];
            centralize(label1, this);

            Control button1 = this.Controls["button1"];
            centralize(button1, this);
            //label1.Text = button1.Location.Y.ToString();

        }

        public void centralize(Control _control, Control _parent)
        {
            Console.Out.WriteLine(_parent.Width.ToString() + " " + _parent.Height.ToString());
            _control.Location = new Point(_parent.Location.X + (_parent.Width - _control.Width) / 2, _control.Location.Y);
            Console.Out.WriteLine(locationToString(_control));
        }

        public string locationToString(Control _control)
        {
            return _control.Location.X + " " + _control.Location.Y;
        }

    }
}
