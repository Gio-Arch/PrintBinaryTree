//// See https://aka.ms/new-console-template for more information


/*

Implement the NotImplemented methods to obtain the following tree as output:

-->root (Level: 1) - Root
-->-->node0 (Level: 2) - Leaf
-->-->node1 (Level: 2) - Leaf
-->-->node2 (Level: 2)
-->-->-->[null value] (Level: 3) - Leaf
-->-->-->node21 (Level: 3)
-->-->-->-->node210 (Level: 4) - Leaf
-->-->-->-->node211 (Level: 4) - Leaf
-->-->node3 (Level: 2)
-->-->-->node30 (Level: 3) - Leaf

                           ┎────────────┒
                    _______┃    root    ┃_______
                   ╱       ┖────────────┚       ╲
                  ╱          ╱        ╲          ╲
      ┎────────────┒┎────────────┒┎────────────┒┎────────────┒
      ┃   node0    ┃┃   node1    ┃┃   node2    ┃┃   node3    ┃
      ┖────────────┚┖────────────┚┖────────────┚┖────────────┚
                                  ╱      |             |
                    ┎────────────┒┎────────────┒┎────────────┒
                    ┃[null value]┃┃   node21   ┃┃   node30   ┃
                    ┖────────────┚┖────────────┚┖────────────┚
                                     ╱        ╲
                            ┎────────────┒┎────────────┒
                            ┃  node210   ┃┃  node211   ┃
                            ┖────────────┚┖────────────┚
 */

using BinaryTree.Objects;
using Tree;

var root = new TreeNode<string?>("root", null);
{
	root.AddChild("node0");
	root.AddChild("node1");
	var node2 = root.AddChild("node2");
	{
		node2.AddChild(null);
		var node21 = node2.AddChild("node21");
		{
			node21.AddChild("node210");
			node21.AddChild("node211");
		}
	}
	var node3 = root.AddChild("node3");
	{
		node3.AddChild("node30");
	}
}

Output.PrintTree(root);