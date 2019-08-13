﻿using System;
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

namespace DataStructures.StringSearch
{
    /// <summary>
    /// Interaction logic for StringSearchUserControl.xaml
    /// </summary>
    public partial class StringSearchUserControl : UserControl
    {
        public StringSearchUserControl()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            txtNaiveOutput.Clear();
            txtBoyerMooreOutput.Clear();

            string input = txtContent.Text;
            string find = txtFind.Text;
            string replace = txtReplace.Text;

            IStringSearchAlgorithm boyerMoore = new BoyerMoore();
            StringBuilder boyerMooreResult = PerformSearchAndReplace(boyerMoore, input, find, replace);
            txtBoyerMooreOutput.Text = boyerMooreResult.ToString();
            lblBoyerMooreComparisonsOutput.Content = ((IPerformanceTracker)(boyerMoore)).Comparisons;

            IStringSearchAlgorithm naive = new NaiveStringSearch();
            StringBuilder naiveResult = PerformSearchAndReplace(naive, input, find, replace);
            txtNaiveOutput.Text = naiveResult.ToString();
            lblNaiveComparisonsValue.Content = ((IPerformanceTracker)(naive)).Comparisons;

        }

        private static StringBuilder PerformSearchAndReplace(IStringSearchAlgorithm algorithm, string input, string find, string replace)
        {
            StringBuilder result = new StringBuilder();
            int previousStart = 0;
            foreach (var match in algorithm.Search(find, input))
            {
                result.Append(input.Substring(previousStart, match.Start - previousStart));
                result.Append(replace);
                previousStart = match.Start + match.Length;
            }

            result.Append(input.Substring(previousStart));
            return result;
        }
    }
}
