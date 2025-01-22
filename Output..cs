using BinaryTree.Objects;

namespace Tree
{
	public class Output
	{
		public static void PrintTree(TreeNode<string?> root)
		{
			foreach (var item in root)
			{
				Console.WriteLine($"{item}");
			}
		}
	}
}
