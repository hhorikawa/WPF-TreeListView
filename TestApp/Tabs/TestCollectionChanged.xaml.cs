using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// TestCollectionChanged.xaml 的交互逻辑
    /// </summary>
    public partial class TestCollectionChanged : UserControl
    {
        public TestCollectionChanged()
        {
            InitializeComponent();
            _tree.Model = new TestCollectionChangedModel();
        }

        private void _tree_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var a = _tree.Model;
            _tree.Model = null;
            _tree.Model = a;
        }
    }
}
