using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
static class EditorDragDropOverride
{
    static EditorDragDropOverride()
    {
        DragAndDrop.AddDropHandlerV2(ProjectBrowserDropHandler);
        DragAndDrop.AddDropHandlerV2(SceneDropHandler);
        DragAndDrop.AddDropHandlerV2(HierarchyDropHandler);
        DragAndDrop.AddDropHandlerV2(InspectorDropHandler);
    }

    static DragAndDropVisualMode ProjectBrowserDropHandler(EntityId dragEntityId, string dropUponPath, bool perform)
    {
        return DragAndDropVisualMode.None;
    }

    static DragAndDropVisualMode SceneDropHandler(Object dropUpon, Vector3 worldPosition, Vector2 viewportPosition, Transform parentForDraggedObjects, bool perform)
    {
        return DragAndDropVisualMode.None;
    }

    static DragAndDropVisualMode HierarchyDropHandler(EntityId dropTargetEntityId, HierarchyDropFlags dropMode, Transform parentForDraggedObjects, bool perform)
    {
        return DragAndDropVisualMode.None;
    }

    static DragAndDropVisualMode InspectorDropHandler(Object[] targets, bool perform)
    {
        return DragAndDropVisualMode.None;
    }
}