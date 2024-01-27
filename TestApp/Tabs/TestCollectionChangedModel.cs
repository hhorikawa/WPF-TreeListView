using Aga.Controls.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Threading;

namespace TestApp
{
    public class TestCollectionChangedModel : ITreeModel
    {
        private ObservableCollection<Test> items = new ObservableCollection<Test>() { new Test() };

        public TestCollectionChangedModel()
        {
            var context = SynchronizationContext.Current;

            var task = new Task(() => {
                Thread.Sleep(1000);
                context.Post(o => items.Add(new Test()), null);
            });
            task.Start();
        }

        public IEnumerable GetChildren(object parent)
        {
            if (parent == null)
                return items;
            else return new List<Test> { new Test() };
        }

        public bool HasChildren(object parent)
        {
            return true;
        }
    }

    public class Test
    {
        public string Name { get { return "test"; } }
    }
}
