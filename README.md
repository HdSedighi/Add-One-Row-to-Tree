# Intuition
Given the requirement to add a row of nodes with a specified value at a given depth in a binary tree, the intuition leads to a level-order traversal approach. By traversing the tree level by level using a queue, we can efficiently reach the target depth and insert the new nodes accordingly.

# Approach
1. Check if the target depth is 1. If so, create a new root node with the specified value and set the original root as its left child.
2. Initialize a queue for the level-order traversal and enqueue the root node.
3. Iterate through the tree level by level using the queue until reaching the depth just before the target depth.
4. At each level, dequeue the nodes and enqueue their children (if any) until the depth just before the target depth is reached.
5. Once at the depth just before the target, dequeue the nodes and insert the new nodes with the specified value as their children.
6. Continue dequeuing nodes and inserting new nodes until all nodes at the target depth are processed.

# Complexity
- Time complexity:
  - Enqueuing and dequeuing nodes in the level-order traversal takes O(n) time, where n is the number of nodes in the tree.
  - Inserting new nodes at the specified depth also takes O(n) time in the worst case, as we might need to traverse all nodes at the target depth.
  - Overall, the time complexity is O(n).
  
- Space complexity:
  - The space complexity is O(n) due to the queue used for the level-order traversal. In the worst case, the queue may contain all nodes of the tree.


__________________________________________________________________________________________
# Create a new console project
dotnet new console -n SumRootToLeafNumbers

# Run the project
dotnet run

_____________________________________________________________________________________

# writing Test- installing related package
dotnet add package NUnit

# run the test
dotnet test
