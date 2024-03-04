/*
Author: Andreas Kramer and Emily Elzinga
Date: 03/03/2024
Desc: Describes functionality for non-leaf nodes on the B+Tree. Recursive function iteration due to children nodes.
*/

using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;
namespace BTreeVisualization

public class BTree<T>(int degree, BufferBlock<(Status status, long id, int numKeys, int[] keys, T[] contents, long altID, int altNumKeys, int[] altKeys, T[] altContents)> bufferBlock)
  {
    private BPlusTreeNode<T> _Root = new LeafNode<T>(degree, bufferBlock);

    private readonly int _Degree = degree;

    
  }