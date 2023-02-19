namespace beryl8 {
    public class BinaryTree
    {
        private BinaryTree left; 
        private BinaryTree right; 
        private String data;
        public BinaryTree( 
        BinaryTree left, 
        BinaryTree right, 
        String data)
        {
            this.left = left; 
            this.right = right; 
            this.data = data;
        }
        public BinaryTree Left
        {
            get {
                return this.left;
            }
        }
        public BinaryTree Right
        {
            get {
                return this.right;
            }
        }
        public String Data
        {
            get {
                return this.data;
            }
        }
    }

    public static class BinaryTreeNodeCounter
    {
        public static int countNodes(BinaryTree tree)
        {
            int count = 0;
            if(tree == null) {
                return count;
            }
            count++;
            
            count += countNodes(tree.Left);
            count += countNodes(tree.Right);

            return count;
        }
    }
} 