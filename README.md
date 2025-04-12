# Yoga-CS

Auto-generated C# bindings for [yoga](https://github.com/facebook/yoga)

## Example

```c#
using Yoga;

internal class Program
{
    public unsafe static void Main(string[] args)
    {
        YGNode* root = YG.NodeNew();
        YG.NodeStyleSetWidth(root, 130);
        YG.NodeStyleSetHeight(root, 50);
        YG.NodeStyleSetPadding(root, YGEdge.YGEdgeAll, 10);
        YG.NodeStyleSetFlexDirection(root, YGFlexDirection.YGFlexDirectionRow);
        YG.NodeStyleSetGap(root, YGGutter.YGGutterColumn, 10);

        YGNode* child1 = YG.NodeNew();
        YG.NodeInsertChild(root, child1, 0);
        YG.NodeStyleSetWidth(child1, 30);
        YG.NodeStyleSetHeight(child1, 30);

        YGNode* child2 = YG.NodeNew();
        YG.NodeInsertChild(root, child2, 0);
        YG.NodeStyleSetWidth(child2, 30);
        YG.NodeStyleSetHeight(child2, 30);

        YGNode* child3 = YG.NodeNew();
        YG.NodeInsertChild(root, child3, 0);
        YG.NodeStyleSetWidth(child3, 30);
        YG.NodeStyleSetHeight(child3, 30);

        YG.NodeCalculateLayout(root, YG.YGUndefined, YG.YGUndefined, YGDirection.YGDirectionLTR);
        for (nuint i = 0; i < YG.NodeGetChildCount(root); i++)
        {
            YGNode* node = YG.NodeGetChild(root, i);
            Console.WriteLine($"Left={YG.NodeLayoutGetLeft(node)},Top={YG.NodeLayoutGetTop(node)},Width={YG.NodeLayoutGetWidth(node)},Height={YG.NodeLayoutGetHeight(node)}");
        }
        
        YG.NodeFreeRecursive(root);
    }
}

```

Output:

```
Left=10,Top=10,Width=30,Height=30
Left=50,Top=10,Width=30,Height=30
Left=90,Top=10,Width=30,Height=30
```



## Generate Bindings

```shell
dotnet tool install --global ClangSharpPInvokeGenerator
git clone https://github.com/cubeww/Yoga-CS --recursive
cd Yoga-CS/GenerateBindings
ClangSharpPInvokeGenerator @generate.gen
```

## Build Native Library

[actions](https://github.com/cubeww/Yoga-CS/actions)
