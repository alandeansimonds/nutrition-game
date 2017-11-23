using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZonePhase07EducationalStrategy : MonoBehaviour, IDropHandler {

    Draggable draggable;
    public string dropAreaNumber;
    public int amountOfEducationalStrategiesNeededToComplete;
    public int amountOfEducationalStrategiesCollected;
    public bool dropZoneComplete;
    public GameObject phase07EducationalStrategyObject01;
    public GameObject phase07EducationalStrategyObject02;
    public bool phase07EducationalStrategy01Selected;
    public bool phase07EducationalStrategy02Selected;
    public MenuOptions menuOptions;
    public string educationalStrategyString01;
    public string educationalStrategyString02;

    public void OnDrop(PointerEventData pointerEventData)
    {
        draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        int pos = System.Array.IndexOf(draggable.dropAreaNumber, dropAreaNumber);
        if (pos > -1)
        {
            if (draggable.evidencePosNumber == 1)
            {
                if (!phase07EducationalStrategy01Selected)
                {
                    if (!phase07EducationalStrategy02Selected)
                    {
                        phase07EducationalStrategyObject01.SetActive(true);
                        amountOfEducationalStrategiesCollected = 1;
                        if (amountOfEducationalStrategiesNeededToComplete == amountOfEducationalStrategiesCollected)
                        {
                            dropZoneComplete = true;
                        }
                        phase07EducationalStrategy01Selected = true;
                        menuOptions.phase07EducationalStrategyStringArray.Add(educationalStrategyString01);
                    } else if (phase07EducationalStrategy02Selected) {
                        phase07EducationalStrategyObject02.SetActive(false);                        
                        phase07EducationalStrategy02Selected = false;
                        phase07EducationalStrategyObject01.SetActive(true);
                        amountOfEducationalStrategiesCollected = 1;
                        if (amountOfEducationalStrategiesNeededToComplete == amountOfEducationalStrategiesCollected)
                        {
                            dropZoneComplete = true;
                        }
                        phase07EducationalStrategy01Selected = true;
                        menuOptions.phase07EducationalStrategyStringArray.Remove(educationalStrategyString02);
                        menuOptions.phase07EducationalStrategyStringArray.Add(educationalStrategyString01);
                    }                    
                }
				menuOptions.phase07EducationalStartegiesSelectionScore = menuOptions.phase07EducationalStartegiesSelectionScore - 1;
            }
            else if (draggable.evidencePosNumber == 2)
            {
                if (!phase07EducationalStrategy02Selected)
                {
                    if (!phase07EducationalStrategy01Selected)
                    {
                        phase07EducationalStrategyObject02.SetActive(true);
                        amountOfEducationalStrategiesCollected = 1;
                        if (amountOfEducationalStrategiesNeededToComplete == amountOfEducationalStrategiesCollected)
                        {
                            dropZoneComplete = true;
                        }
                        phase07EducationalStrategy02Selected = true;                        
                        menuOptions.phase07EducationalStrategyStringArray.Add(educationalStrategyString02);
                    }
                    else if (phase07EducationalStrategy01Selected)
                    {
                        phase07EducationalStrategyObject01.SetActive(false);
                        phase07EducationalStrategy01Selected = false;
                        phase07EducationalStrategyObject02.SetActive(true);
                        amountOfEducationalStrategiesCollected = 1;
                        if (amountOfEducationalStrategiesNeededToComplete == amountOfEducationalStrategiesCollected)
                        {
                            dropZoneComplete = true;
                        }
                        phase07EducationalStrategy02Selected = true;
                        menuOptions.phase07EducationalStrategyStringArray.Remove(educationalStrategyString01);
                        menuOptions.phase07EducationalStrategyStringArray.Add(educationalStrategyString02);
                    }
					menuOptions.phase07EducationalStartegiesSelectionScore = menuOptions.phase07EducationalStartegiesSelectionScore + 1;
                }
            }
        }
        else if (pos < 0)
        {
            menuOptions.phase6part01AlertMessageText.text = "This educational strategy does not match this goal. Please try again.";
            menuOptions.Phase06Part01AlertMessageToggle();
        }
    }
}
