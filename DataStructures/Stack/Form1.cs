using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures.Stack
{
    public partial class Form1 : Form
    {

        Stack<Undo> _undoOps = new Stack<Undo>();

        Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private Color GetRandomColor()
        {
            byte[] rgb = new byte[3];
            _random.NextBytes(rgb);
            return Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _undoOps.Push(new Undo(button1));
            button1.BackColor = GetRandomColor();
            UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _undoOps.Push(new Undo(button2));
            button2.BackColor = GetRandomColor();
            UpdateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _undoOps.Push(new Undo(button3));
            button3.BackColor = GetRandomColor();
            UpdateList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(_undoOps.Count>0)
            {
                _undoOps.Pop().Execute();
                UpdateList();
            }

        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (Undo undo in _undoOps)
            {
                listBox1.Items.Add(undo.ToString());
            }

        }
    }
}
