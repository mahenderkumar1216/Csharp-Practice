using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures.Stack
{
    class Undo
    {

        public Undo(Button button)
        {
            _button = button;
            _color = button.BackColor;
        }

        public void Execute()
        {
            _button.BackColor = _color;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}", _button.Text, _color.ToArgb().ToString());
        }
        Button _button;
        Color _color;
    }
}
