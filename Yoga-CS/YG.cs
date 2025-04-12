using System;
using System.Runtime.InteropServices;
using static Yoga.YGUnit;

namespace Yoga
{
    public static unsafe partial class YG
    {
        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigNew", ExactSpelling = true)]
        [return: NativeTypeName("YGConfigRef")]
        public static extern YGConfig* ConfigNew();

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigFree", ExactSpelling = true)]
        public static extern void ConfigFree([NativeTypeName("YGConfigRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigGetDefault", ExactSpelling = true)]
        [return: NativeTypeName("YGConfigConstRef")]
        public static extern YGConfig* ConfigGetDefault();

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetUseWebDefaults", ExactSpelling = true)]
        public static extern void ConfigSetUseWebDefaults([NativeTypeName("YGConfigRef")] YGConfig* config, [NativeTypeName("bool")] byte enabled);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigGetUseWebDefaults", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ConfigGetUseWebDefaults([NativeTypeName("YGConfigConstRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetPointScaleFactor", ExactSpelling = true)]
        public static extern void ConfigSetPointScaleFactor([NativeTypeName("YGConfigRef")] YGConfig* config, float pixelsInPoint);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigGetPointScaleFactor", ExactSpelling = true)]
        public static extern float ConfigGetPointScaleFactor([NativeTypeName("YGConfigConstRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetErrata", ExactSpelling = true)]
        public static extern void ConfigSetErrata([NativeTypeName("YGConfigRef")] YGConfig* config, YGErrata errata);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigGetErrata", ExactSpelling = true)]
        public static extern YGErrata ConfigGetErrata([NativeTypeName("YGConfigConstRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetLogger", ExactSpelling = true)]
        public static extern void ConfigSetLogger([NativeTypeName("YGConfigRef")] YGConfig* config, [NativeTypeName("YGLogger")] delegate* unmanaged[Cdecl]<YGConfig*, YGNode*, YGLogLevel, sbyte*, sbyte*, int> logger);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetContext", ExactSpelling = true)]
        public static extern void ConfigSetContext([NativeTypeName("YGConfigRef")] YGConfig* config, void* context);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigGetContext", ExactSpelling = true)]
        public static extern void* ConfigGetContext([NativeTypeName("YGConfigConstRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetExperimentalFeatureEnabled", ExactSpelling = true)]
        public static extern void ConfigSetExperimentalFeatureEnabled([NativeTypeName("YGConfigRef")] YGConfig* config, YGExperimentalFeature feature, [NativeTypeName("bool")] byte enabled);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigIsExperimentalFeatureEnabled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ConfigIsExperimentalFeatureEnabled([NativeTypeName("YGConfigConstRef")] YGConfig* config, YGExperimentalFeature feature);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGConfigSetCloneNodeFunc", ExactSpelling = true)]
        public static extern void ConfigSetCloneNodeFunc([NativeTypeName("YGConfigRef")] YGConfig* config, [NativeTypeName("YGCloneNodeFunc")] delegate* unmanaged[Cdecl]<YGNode*, YGNode*, nuint, YGNode*> callback);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGAlignToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* AlignToString(YGAlign param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGBoxSizingToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* BoxSizingToString(YGBoxSizing param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGDimensionToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* DimensionToString(YGDimension param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGDirectionToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* DirectionToString(YGDirection param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGDisplayToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* DisplayToString(YGDisplay param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGEdgeToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* EdgeToString(YGEdge param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGErrataToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ErrataToString(YGErrata param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGExperimentalFeatureToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ExperimentalFeatureToString(YGExperimentalFeature param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGFlexDirectionToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* FlexDirectionToString(YGFlexDirection param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGGutterToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GutterToString(YGGutter param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGJustifyToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JustifyToString(YGJustify param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGLogLevelToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* LogLevelToString(YGLogLevel param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGMeasureModeToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* MeasureModeToString(YGMeasureMode param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeTypeToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* NodeTypeToString(YGNodeType param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGOverflowToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* OverflowToString(YGOverflow param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGPositionTypeToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* PositionTypeToString(YGPositionType param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGUnitToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* UnitToString(YGUnit param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGWrapToString", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* WrapToString(YGWrap param0);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeNew", ExactSpelling = true)]
        [return: NativeTypeName("YGNodeRef")]
        public static extern YGNode* NodeNew();

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeNewWithConfig", ExactSpelling = true)]
        [return: NativeTypeName("YGNodeRef")]
        public static extern YGNode* NodeNewWithConfig([NativeTypeName("YGConfigConstRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeClone", ExactSpelling = true)]
        [return: NativeTypeName("YGNodeRef")]
        public static extern YGNode* NodeClone([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeFree", ExactSpelling = true)]
        public static extern void NodeFree([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeFreeRecursive", ExactSpelling = true)]
        public static extern void NodeFreeRecursive([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeFinalize", ExactSpelling = true)]
        public static extern void NodeFinalize([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeReset", ExactSpelling = true)]
        public static extern void NodeReset([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeCalculateLayout", ExactSpelling = true)]
        public static extern void NodeCalculateLayout([NativeTypeName("YGNodeRef")] YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetHasNewLayout", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeGetHasNewLayout([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetHasNewLayout", ExactSpelling = true)]
        public static extern void NodeSetHasNewLayout([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("bool")] byte hasNewLayout);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeIsDirty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeIsDirty([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeMarkDirty", ExactSpelling = true)]
        public static extern void NodeMarkDirty([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetDirtiedFunc", ExactSpelling = true)]
        public static extern void NodeSetDirtiedFunc([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGDirtiedFunc")] delegate* unmanaged[Cdecl]<YGNode*, void> dirtiedFunc);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetDirtiedFunc", ExactSpelling = true)]
        [return: NativeTypeName("YGDirtiedFunc")]
        public static extern delegate* unmanaged[Cdecl]<YGNode*, void> NodeGetDirtiedFunc([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeInsertChild", ExactSpelling = true)]
        public static extern void NodeInsertChild([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGNodeRef")] YGNode* child, [NativeTypeName("size_t")] nuint index);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSwapChild", ExactSpelling = true)]
        public static extern void NodeSwapChild([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGNodeRef")] YGNode* child, [NativeTypeName("size_t")] nuint index);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeRemoveChild", ExactSpelling = true)]
        public static extern void NodeRemoveChild([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGNodeRef")] YGNode* child);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeRemoveAllChildren", ExactSpelling = true)]
        public static extern void NodeRemoveAllChildren([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetChildren", ExactSpelling = true)]
        public static extern void NodeSetChildren([NativeTypeName("YGNodeRef")] YGNode* owner, [NativeTypeName("const YGNodeRef *")] YGNode** children, [NativeTypeName("size_t")] nuint count);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetChild", ExactSpelling = true)]
        [return: NativeTypeName("YGNodeRef")]
        public static extern YGNode* NodeGetChild([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("size_t")] nuint index);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetChildCount", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint NodeGetChildCount([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetOwner", ExactSpelling = true)]
        [return: NativeTypeName("YGNodeRef")]
        public static extern YGNode* NodeGetOwner([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetParent", ExactSpelling = true)]
        [return: NativeTypeName("YGNodeRef")]
        public static extern YGNode* NodeGetParent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetConfig", ExactSpelling = true)]
        public static extern void NodeSetConfig([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGConfigRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetConfig", ExactSpelling = true)]
        [return: NativeTypeName("YGConfigConstRef")]
        public static extern YGConfig* NodeGetConfig([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetContext", ExactSpelling = true)]
        public static extern void NodeSetContext([NativeTypeName("YGNodeRef")] YGNode* node, void* context);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetContext", ExactSpelling = true)]
        public static extern void* NodeGetContext([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetMeasureFunc", ExactSpelling = true)]
        public static extern void NodeSetMeasureFunc([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGMeasureFunc")] delegate* unmanaged[Cdecl]<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> measureFunc);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeHasMeasureFunc", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeHasMeasureFunc([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetBaselineFunc", ExactSpelling = true)]
        public static extern void NodeSetBaselineFunc([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("YGBaselineFunc")] delegate* unmanaged[Cdecl]<YGNode*, float, float, float> baselineFunc);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeHasBaselineFunc", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeHasBaselineFunc([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetIsReferenceBaseline", ExactSpelling = true)]
        public static extern void NodeSetIsReferenceBaseline([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("bool")] byte isReferenceBaseline);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeIsReferenceBaseline", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeIsReferenceBaseline([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetNodeType", ExactSpelling = true)]
        public static extern void NodeSetNodeType([NativeTypeName("YGNodeRef")] YGNode* node, YGNodeType nodeType);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetNodeType", ExactSpelling = true)]
        public static extern YGNodeType NodeGetNodeType([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeSetAlwaysFormsContainingBlock", ExactSpelling = true)]
        public static extern void NodeSetAlwaysFormsContainingBlock([NativeTypeName("YGNodeRef")] YGNode* node, [NativeTypeName("bool")] byte alwaysFormsContainingBlock);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeGetAlwaysFormsContainingBlock", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeGetAlwaysFormsContainingBlock([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeCanUseCachedMeasurement", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        [Obsolete("YGNodeCanUseCachedMeasurement may be removed in a future version of Yoga")]
        public static extern byte NodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, [NativeTypeName("YGConfigRef")] YGConfig* config);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetLeft", ExactSpelling = true)]
        public static extern float NodeLayoutGetLeft([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetTop", ExactSpelling = true)]
        public static extern float NodeLayoutGetTop([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetRight", ExactSpelling = true)]
        public static extern float NodeLayoutGetRight([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetBottom", ExactSpelling = true)]
        public static extern float NodeLayoutGetBottom([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetWidth", ExactSpelling = true)]
        public static extern float NodeLayoutGetWidth([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetHeight", ExactSpelling = true)]
        public static extern float NodeLayoutGetHeight([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetDirection", ExactSpelling = true)]
        public static extern YGDirection NodeLayoutGetDirection([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetHadOverflow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte NodeLayoutGetHadOverflow([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetMargin", ExactSpelling = true)]
        public static extern float NodeLayoutGetMargin([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetBorder", ExactSpelling = true)]
        public static extern float NodeLayoutGetBorder([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeLayoutGetPadding", ExactSpelling = true)]
        public static extern float NodeLayoutGetPadding([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeCopyStyle", ExactSpelling = true)]
        public static extern void NodeCopyStyle([NativeTypeName("YGNodeRef")] YGNode* dstNode, [NativeTypeName("YGNodeConstRef")] YGNode* srcNode);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetDirection", ExactSpelling = true)]
        public static extern void NodeStyleSetDirection([NativeTypeName("YGNodeRef")] YGNode* node, YGDirection direction);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetDirection", ExactSpelling = true)]
        public static extern YGDirection NodeStyleGetDirection([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexDirection", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexDirection([NativeTypeName("YGNodeRef")] YGNode* node, YGFlexDirection flexDirection);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetFlexDirection", ExactSpelling = true)]
        public static extern YGFlexDirection NodeStyleGetFlexDirection([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetJustifyContent", ExactSpelling = true)]
        public static extern void NodeStyleSetJustifyContent([NativeTypeName("YGNodeRef")] YGNode* node, YGJustify justifyContent);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetJustifyContent", ExactSpelling = true)]
        public static extern YGJustify NodeStyleGetJustifyContent([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetAlignContent", ExactSpelling = true)]
        public static extern void NodeStyleSetAlignContent([NativeTypeName("YGNodeRef")] YGNode* node, YGAlign alignContent);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetAlignContent", ExactSpelling = true)]
        public static extern YGAlign NodeStyleGetAlignContent([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetAlignItems", ExactSpelling = true)]
        public static extern void NodeStyleSetAlignItems([NativeTypeName("YGNodeRef")] YGNode* node, YGAlign alignItems);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetAlignItems", ExactSpelling = true)]
        public static extern YGAlign NodeStyleGetAlignItems([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetAlignSelf", ExactSpelling = true)]
        public static extern void NodeStyleSetAlignSelf([NativeTypeName("YGNodeRef")] YGNode* node, YGAlign alignSelf);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetAlignSelf", ExactSpelling = true)]
        public static extern YGAlign NodeStyleGetAlignSelf([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetPositionType", ExactSpelling = true)]
        public static extern void NodeStyleSetPositionType([NativeTypeName("YGNodeRef")] YGNode* node, YGPositionType positionType);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetPositionType", ExactSpelling = true)]
        public static extern YGPositionType NodeStyleGetPositionType([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexWrap", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexWrap([NativeTypeName("YGNodeRef")] YGNode* node, YGWrap flexWrap);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetFlexWrap", ExactSpelling = true)]
        public static extern YGWrap NodeStyleGetFlexWrap([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetOverflow", ExactSpelling = true)]
        public static extern void NodeStyleSetOverflow([NativeTypeName("YGNodeRef")] YGNode* node, YGOverflow overflow);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetOverflow", ExactSpelling = true)]
        public static extern YGOverflow NodeStyleGetOverflow([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetDisplay", ExactSpelling = true)]
        public static extern void NodeStyleSetDisplay([NativeTypeName("YGNodeRef")] YGNode* node, YGDisplay display);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetDisplay", ExactSpelling = true)]
        public static extern YGDisplay NodeStyleGetDisplay([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlex", ExactSpelling = true)]
        public static extern void NodeStyleSetFlex([NativeTypeName("YGNodeRef")] YGNode* node, float flex);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetFlex", ExactSpelling = true)]
        public static extern float NodeStyleGetFlex([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexGrow", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexGrow([NativeTypeName("YGNodeRef")] YGNode* node, float flexGrow);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetFlexGrow", ExactSpelling = true)]
        public static extern float NodeStyleGetFlexGrow([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexShrink", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexShrink([NativeTypeName("YGNodeRef")] YGNode* node, float flexShrink);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetFlexShrink", ExactSpelling = true)]
        public static extern float NodeStyleGetFlexShrink([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexBasis", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexBasis([NativeTypeName("YGNodeRef")] YGNode* node, float flexBasis);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexBasisPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexBasisPercent([NativeTypeName("YGNodeRef")] YGNode* node, float flexBasis);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexBasisAuto", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexBasisAuto([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexBasisMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexBasisMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexBasisFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexBasisFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetFlexBasisStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetFlexBasisStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetFlexBasis", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetFlexBasis([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetPosition", ExactSpelling = true)]
        public static extern void NodeStyleSetPosition([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float position);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetPositionPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetPositionPercent([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float position);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetPosition", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetPosition([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetPositionAuto", ExactSpelling = true)]
        public static extern void NodeStyleSetPositionAuto([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMargin", ExactSpelling = true)]
        public static extern void NodeStyleSetMargin([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float margin);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMarginPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetMarginPercent([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float margin);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMarginAuto", ExactSpelling = true)]
        public static extern void NodeStyleSetMarginAuto([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetMargin", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetMargin([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetPadding", ExactSpelling = true)]
        public static extern void NodeStyleSetPadding([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float padding);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetPaddingPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetPaddingPercent([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float padding);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetPadding", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetPadding([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetBorder", ExactSpelling = true)]
        public static extern void NodeStyleSetBorder([NativeTypeName("YGNodeRef")] YGNode* node, YGEdge edge, float border);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetBorder", ExactSpelling = true)]
        public static extern float NodeStyleGetBorder([NativeTypeName("YGNodeConstRef")] YGNode* node, YGEdge edge);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetGap", ExactSpelling = true)]
        public static extern void NodeStyleSetGap([NativeTypeName("YGNodeRef")] YGNode* node, YGGutter gutter, float gapLength);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetGapPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetGapPercent([NativeTypeName("YGNodeRef")] YGNode* node, YGGutter gutter, float gapLength);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetGap", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetGap([NativeTypeName("YGNodeConstRef")] YGNode* node, YGGutter gutter);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetBoxSizing", ExactSpelling = true)]
        public static extern void NodeStyleSetBoxSizing([NativeTypeName("YGNodeRef")] YGNode* node, YGBoxSizing boxSizing);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetBoxSizing", ExactSpelling = true)]
        public static extern YGBoxSizing NodeStyleGetBoxSizing([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetWidth", ExactSpelling = true)]
        public static extern void NodeStyleSetWidth([NativeTypeName("YGNodeRef")] YGNode* node, float width);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetWidthPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetWidthPercent([NativeTypeName("YGNodeRef")] YGNode* node, float width);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetWidthAuto", ExactSpelling = true)]
        public static extern void NodeStyleSetWidthAuto([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetWidthMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetWidthMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetWidthFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetWidthFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetWidthStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetWidthStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetWidth", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetWidth([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetHeight", ExactSpelling = true)]
        public static extern void NodeStyleSetHeight([NativeTypeName("YGNodeRef")] YGNode* node, float height);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetHeightPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetHeightPercent([NativeTypeName("YGNodeRef")] YGNode* node, float height);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetHeightAuto", ExactSpelling = true)]
        public static extern void NodeStyleSetHeightAuto([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetHeightMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetHeightMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetHeightFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetHeightFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetHeightStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetHeightStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetHeight", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetHeight([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinWidth", ExactSpelling = true)]
        public static extern void NodeStyleSetMinWidth([NativeTypeName("YGNodeRef")] YGNode* node, float minWidth);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinWidthPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetMinWidthPercent([NativeTypeName("YGNodeRef")] YGNode* node, float minWidth);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinWidthMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMinWidthMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinWidthFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMinWidthFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinWidthStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetMinWidthStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetMinWidth", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetMinWidth([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinHeight", ExactSpelling = true)]
        public static extern void NodeStyleSetMinHeight([NativeTypeName("YGNodeRef")] YGNode* node, float minHeight);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinHeightPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetMinHeightPercent([NativeTypeName("YGNodeRef")] YGNode* node, float minHeight);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinHeightMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMinHeightMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinHeightFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMinHeightFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMinHeightStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetMinHeightStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetMinHeight", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetMinHeight([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxWidth", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxWidth([NativeTypeName("YGNodeRef")] YGNode* node, float maxWidth);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxWidthPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxWidthPercent([NativeTypeName("YGNodeRef")] YGNode* node, float maxWidth);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxWidthMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxWidthMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxWidthFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxWidthFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxWidthStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxWidthStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetMaxWidth", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetMaxWidth([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxHeight", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxHeight([NativeTypeName("YGNodeRef")] YGNode* node, float maxHeight);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxHeightPercent", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxHeightPercent([NativeTypeName("YGNodeRef")] YGNode* node, float maxHeight);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxHeightMaxContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxHeightMaxContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxHeightFitContent", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxHeightFitContent([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetMaxHeightStretch", ExactSpelling = true)]
        public static extern void NodeStyleSetMaxHeightStretch([NativeTypeName("YGNodeRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetMaxHeight", ExactSpelling = true)]
        public static extern YGValue NodeStyleGetMaxHeight([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleSetAspectRatio", ExactSpelling = true)]
        public static extern void NodeStyleSetAspectRatio([NativeTypeName("YGNodeRef")] YGNode* node, float aspectRatio);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGNodeStyleGetAspectRatio", ExactSpelling = true)]
        public static extern float NodeStyleGetAspectRatio([NativeTypeName("YGNodeConstRef")] YGNode* node);

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGRoundValueToPixelGrid", ExactSpelling = true)]
        public static extern float RoundValueToPixelGrid(double value, double pointScaleFactor, [NativeTypeName("bool")] byte forceCeil, [NativeTypeName("bool")] byte forceFloor);

        [NativeTypeName("const float")]
        public const float YGUndefined = float.NaN;

        [DllImport("yoga", CallingConvention = CallingConvention.Cdecl, EntryPoint = "YGFloatIsUndefined", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte FloatIsUndefined(float value);

        public static bool Equals([NativeTypeName("const YGValue &")] YGValue* lhs, [NativeTypeName("const YGValue &")] YGValue* rhs)
        {
            if (lhs->unit != rhs->unit)
            {
                return false;
            }

            switch (lhs->unit)
            {
                case YGUnitUndefined:
                case YGUnitAuto:
                case YGUnitFitContent:
                case YGUnitMaxContent:
                case YGUnitStretch:
                {
                    return true;
                }

                case YGUnitPoint:
                case YGUnitPercent:
                {
                    return lhs->value == rhs->value;
                }
            }

            return false;
        }

        public static bool NotEquals([NativeTypeName("const YGValue &")] YGValue* lhs, [NativeTypeName("const YGValue &")] YGValue* rhs)
        {
            return !(Equals(lhs, rhs));
        }

        public static YGValue Subtract([NativeTypeName("const YGValue &")] YGValue* value)
        {
            return new YGValue
            {
                value = -value->value,
                unit = value->unit,
            };
        }
    }
}
