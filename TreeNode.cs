using System.Collections;

namespace BinaryTree.Objects
{
	public class TreeNode<T> : IEnumerable<TreeNode<T>>
	{
		public T Data { get; set; }
		public TreeNode<T>? Parent { get; set; }
		public ICollection<TreeNode<T>> Children { get; set; }

		public bool IsRoot => Parent == null;
		public bool IsLeaf => !Children.Any();
		public int Level => IsRoot ? 1 : Parent!.Level +1;

		public TreeNode(T data, TreeNode<T>? parent)
		{
			Data = data;
			Parent = parent;
			Children = new LinkedList<TreeNode<T>>();
		}

		public TreeNode<T> AddChild(T childValue)
		{
			TreeNode<T> newNode = new(childValue, this);
			Children.Add(newNode);
			return newNode;
		}

		public override string ToString()
		{
			string stampadato = IsRoot ? "Root" : IsLeaf ? "Leaf" : "";
			return $"{StampaLivello(Level)}{GetData(Data)}(Level: {Level}) {stampadato}";
		}

		private string GetData(T? data)
		{
			if (Data == null) { return "[null value]"; }
			return Data.ToString()!;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<TreeNode<T>> GetEnumerator()
		{
			yield return this;
			foreach (var directChild in this.Children)
			{
				foreach (var anyChild in directChild)
					yield return anyChild;
			}
		}

		private object StampaLivello(int level)
		{
			string retVal = null;
			for (int i = 0; i < level; i++) 
			{
				retVal += "-->";
			}
			return retVal!;
		}
	}
}
