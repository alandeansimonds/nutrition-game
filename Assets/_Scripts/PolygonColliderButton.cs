using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(PolygonCollider2D))]
public class PolygonColliderButton : MonoBehaviour, ICanvasRaycastFilter
{
    PolygonCollider2D myCollider;
    RectTransform rectTransform;

    void Awake()
    {
        myCollider = GetComponent<PolygonCollider2D>();
        rectTransform = GetComponent<RectTransform>();
    }

    #region ICanvasRaycastFilter implementation
    public bool IsRaycastLocationValid(Vector2 screenPos, Camera eventCamera)
    {
        var worldPoint = Vector3.zero;
        var isInside = RectTransformUtility.ScreenPointToWorldPointInRectangle(
            rectTransform,
            screenPos,
            eventCamera,
            out worldPoint
        );
        if (isInside)
            isInside = myCollider.OverlapPoint(worldPoint);
        return isInside;
    }
    #endregion
}
