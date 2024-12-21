
using Aga.Controls.Tree;
using Xunit;

namespace UnitTests
{
    
public class NodeTest
{
    [WpfFact]
    public void VisibleChildren()
	{
			TreeNode root = CreateTreeNode(3, 3);
			root.IsExpanded = true;
			var a = root.Children[0];
			a.IsExpanded = true;
			var b = root.Children[0].Children[2];
			b.IsExpanded = true;

		Assert.Equal(6, a.VisibleChildrenCount);
		Assert.Equal(3, b.VisibleChildrenCount);
	}

    
	private static TreeNode CreateTreeNode(int depth, int count)
    {
        TreeNode root = new TreeNode(new Aga.Controls.Tree.TreeList(), null);

        if (depth > 0) {
				for (int i = 0; i < count; i++)
				{
					root.Children.Add(CreateTreeNode(depth - 1, count));
				}
			}
			return root;
		}
	}
}
