// See https://aka.ms/new-console-template for more information
using beryl8;

var nodes = new BinaryTree(
    new BinaryTree(
        new BinaryTree(null,
            new BinaryTree(null,null,"node4")
        ,"node3"), null
    ,"node2")
    ,new BinaryTree(null,null,"node5")
,"node1");

Console.WriteLine(BinaryTreeNodeCounter.countNodes(nodes));