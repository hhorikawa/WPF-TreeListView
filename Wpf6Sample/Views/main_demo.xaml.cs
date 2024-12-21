
using System.Windows.Controls;


namespace Wpf6Sample.Views
{
    /// <summary>
    /// main_demo.xaml の相互作用ロジック
    /// </summary>
public partial class MainDemo : UserControl
{
    public MainDemo()
    {
        InitializeComponent();

        var model = PersonModel.CreateTree(3, 5, 5);
        _treeList.Model = model; // ここが微妙にダサい。bindable でない.
    }
}
}
