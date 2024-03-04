/**
Desc: Implements the leaf nodes of a B+Tree.
*/

using System.Text.Json;
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;
using NodeData;

namespace BTreeVisualization

public class BPlusLeafNode<T>(int degree, BufferBlock<(Status status,
      long id, int numKeys, int[] keys, T[] contents, long altID,
      int altNumKeys, int[] altKeys, T[] altContents)> bufferBlock)
      : BTreeNode<T>(degree, bufferBlock)
  {
    BPlusLeafNode<T>? _NextNode;
    BPlusLeafNode<T>? _PrevNode;

    _NumKeys = keys.Length;
      for (int i = 0; i < keys.Length; i++)
      {
        _Keys[i] = keys[i];
        _Contents[i] = contents[i];
      }
  }

  
