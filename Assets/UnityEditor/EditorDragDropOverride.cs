using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
static class EditorDragDropOverride
{
    static EditorDragDropOverride()
    {
        DragAndDrop.AddDropHandler(ProjectBrowserDropHandler);
        DragAndDrop.AddDropHandler(SceneDropHandler);
        DragAndDrop.AddDropHandler(HierarchyDropHandler);
        DragAndDrop.AddDropHandler(InspectorDropHandler);
    }

    static DragAndDropVisualMode ProjectBrowserDropHandler(int dragInstanceId, string dropUponPath, bool perform)
    {
        return DragAndDropVisualMode.None;
    }

    static DragAndDropVisualMode SceneDropHandler(Object dropUpon, Vector3 worldPosition, Vector2 viewportPosition, Transform parentForDraggedObjects, bool perform)
    {
        return DragAndDropVisualMode.None;
    }

    static DragAndDropVisualMode HierarchyDropHandler(int dropTargetInstanceID, HierarchyDropFlags dropMode, Transform parentForDraggedObjects, bool perform)
    {
        return DragAndDropVisualMode.None;
    }

    static DragAndDropVisualMode InspectorDropHandler(Object[] targets, bool perform)
    {
        return DragAndDropVisualMode.None;
    }
}