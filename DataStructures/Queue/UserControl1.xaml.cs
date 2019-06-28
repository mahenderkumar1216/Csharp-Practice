using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataStructures.Queue
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        Queue<int> _queue = new Queue<int>();
        Random _random = new Random();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, RoutedEventArgs e)
        {
            _queue.Enqueue(_random.Next(1, 255));
            UpdateGrid();

        }

        private void button_Process_Click(object sender, RoutedEventArgs e)
        {
            if (_queue.Count > 0)
            {
                listBox1.Items.Add(_queue.Dequeue());
                UpdateGrid();
            }
        }

        public void UpdateGrid()
        {
            queue_label_1.Content = string.Empty;
            queue_label_2.Content = string.Empty;
            queue_label_3.Content = string.Empty;
            queue_label_4.Content = string.Empty;
            queue_label_5.Content = string.Empty;
            queue_label_6.Content = string.Empty;

            int index = 0;

            foreach (int token in _queue)
            {
                switch (index)
                {
                    case 0:
                        queue_label_1.Content = token.ToString();
                        break;
                    case 1:
                        queue_label_2.Content = token.ToString();
                        break;
                    case 2:
                        queue_label_3.Content = token.ToString();
                        break;
                    case 3:
                        queue_label_4.Content = token.ToString();
                        break;
                    case 4:
                        queue_label_5.Content = token.ToString();
                        break;
                    case 5:
                        queue_label_6.Content = token.ToString();
                        break;
                    default:
                        break;
                }
                index++;

                if (index > 5)
                {
                    break;
                }
            }
        }
    }
}
