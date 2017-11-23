using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler  {

    public Transform parentToReturnTo = null;
    private Image backgroundImage;
    private Color32 startingColor;
    private Color32 transparentColor = new Color32 (255, 255, 255, 38);
    private Color32 enterColor = new Color32(106, 181, 67, 255);
    private CanvasGroup canvasGroup;
    public string[] dropAreaNumber;
    public int evidencePosNumber;

    void Start()
    {
        canvasGroup = this.gameObject.GetComponent<CanvasGroup>();
        backgroundImage = this.gameObject.GetComponent<Image>();
        startingColor = backgroundImage.color;
    }

    public void OnBeginDrag(PointerEventData pointerEventData) {
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData pointerEventData) {
        this.transform.position = pointerEventData.position;
        backgroundImage.color = transparentColor;
    }

    public void OnEndDrag(PointerEventData pointerEventData) {
        this.transform.SetParent(parentToReturnTo);
        backgroundImage.color = startingColor;
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        backgroundImage.color = enterColor;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        backgroundImage.color = startingColor;
    }
}
