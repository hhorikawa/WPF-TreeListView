
using Aga.Controls.Tree;
using System.Collections;
using System.Collections.ObjectModel;

namespace Wpf6Sample
{

public class Person
{
    public string Name { get; set; }

    private readonly ObservableCollection<Person> _children;
    public ObservableCollection<Person> Children {
        get { return _children; }
    }

    public Person()
    {
        _children = new ObservableCollection<Person>();
    }
}


// `ITreeModel` から派生しなければならない.
internal class PersonModel : ITreeModel
{
    public static PersonModel CreateTree(int count1, int count2, int count3)
    {
		var model = new PersonModel();

		for (int i = 0; i < count1; i++) {
            var p = new Person() { Name = "Person A " + i.ToString() };
				model.Root.Children.Add(p);
				for (int n = 0; n < count2; n++)
				{
					var p2 = new Person() { Name = "Person B" + n.ToString() };
					p.Children.Add(p2);
					for (int k = 0; k < count3; k++)
						p2.Children.Add(new Person() { Name = "Person C" + k.ToString() });
				}
			}
			return model;
    }

    public Person Root { get; private set; }

    public PersonModel()
    {
        Root = new Person();
    }


    // @implements
    public IEnumerable GetChildren(object parent)
    {
        if (parent == null)
            parent = Root;
        return ((Person) parent).Children;
    }

    // @implements
    public bool HasChildren(object parent)
    {
        return ((Person) parent).Children.Count > 0;
    }
}

}