using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    Draggable draggable;
    public string dropAreaNumber;
    public int amountOfEvidenceNeededToComplete;
    public int amountOfEvidenceCollected;
    public bool dropZoneComplete;
    public GameObject phase06EvidenceObject01;
    public GameObject phase06EvidenceObject02;
    public GameObject phase06EvidenceObject03;
    public GameObject phase06EvidenceObject04;
    private bool phase06Evidence01Selected;
    private bool phase06Evidence02Selected;
    private bool phase06Evidence03Selected;
    private bool phase06Evidence04Selected;
    public MenuOptions menuOptions;

    public void OnDrop(PointerEventData pointerEventData)
    {
        draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        int pos = System.Array.IndexOf(draggable.dropAreaNumber, dropAreaNumber);
        if (pos > -1)
        {
            if (draggable.evidencePosNumber == 1)
            {
                if (!phase06Evidence01Selected)
                {
                    phase06EvidenceObject01.SetActive(true);
                    amountOfEvidenceCollected++;
                    if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
                    {
                        dropZoneComplete = true;
                    }
                    phase06Evidence01Selected = true;
                }
            }
            else if (draggable.evidencePosNumber == 2)
            {
                if (!phase06Evidence02Selected)
                {
                    phase06EvidenceObject02.SetActive(true);
                    amountOfEvidenceCollected++;
                    if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
                    {
                        dropZoneComplete = true;
                    }
                    phase06Evidence02Selected = true;
                }
            }
            else if (draggable.evidencePosNumber == 3)
            {
                if (!phase06Evidence03Selected)
                {
                    phase06EvidenceObject03.SetActive(true);
                    amountOfEvidenceCollected++;
                    if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
                    {
                        dropZoneComplete = true;
                    }
                    phase06Evidence03Selected = true;
                }
            }
            else if (draggable.evidencePosNumber == 4)
            {
                if (!phase06Evidence04Selected)
                {
                    phase06EvidenceObject04.SetActive(true);
                    amountOfEvidenceCollected++;
                    if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
                    {
                        dropZoneComplete = true;
                    }
                    phase06Evidence04Selected = true;
                }
            }
        }
        else if (pos < 0) {
            menuOptions.phase6part01AlertMessageText.text = "This does not provide evidence for the particular problem.";
            menuOptions.Phase06Part01AlertMessageToggle();
        }
    }

        //if (pos == 0) {
        //    if (!phase06Evidence01Selected)
        //    {
        //        phase06EvidenceObject01.SetActive(true);
        //        amountOfEvidenceCollected++;
        //        if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected) {
        //            dropZoneComplete = true;
        //        }
        //        phase06Evidence01Selected = true;                
        //    }
        //}
        //else if (pos == 1) {
        //    if (!phase06Evidence02Selected)
        //    {
        //        phase06EvidenceObject02.SetActive(true);
        //        amountOfEvidenceCollected++;
        //        if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
        //        {
        //            dropZoneComplete = true;
        //        }
        //        phase06Evidence02Selected = true;
        //    }
        //}
        //else if (pos == 2) {
        //    if (!phase06Evidence03Selected)
        //    {
        //        phase06EvidenceObject03.SetActive(true);
        //        amountOfEvidenceCollected++;
        //        if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
        //        {
        //            dropZoneComplete = true;
        //        }
        //        phase06Evidence03Selected = true;
        //    }
        //}
        //else if (pos == 3)
        //{
        //    if (!phase06Evidence04Selected)
        //    {
        //        phase06EvidenceObject04.SetActive(true);
        //        amountOfEvidenceCollected++;
        //        if (amountOfEvidenceNeededToComplete == amountOfEvidenceCollected)
        //        {
        //            dropZoneComplete = true;
        //        }
        //        phase06Evidence04Selected = true;
        //    }
        //}
        //else {
        //    menuOptions.phase6part01AlertMessageText.text = "This does not provide evidence for the particular problem.";
        //    menuOptions.Phase06Part01AlertMessageToggle();
        //}        
    

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        
    }
}
