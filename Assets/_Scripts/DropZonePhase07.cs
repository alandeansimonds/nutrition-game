using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZonePhase07 : MonoBehaviour, IDropHandler { 

    Draggable draggable;
    public string dropAreaNumber;
    public int amountOfFoodStrategiesNeededToComplete;
    public int amountOfFoodStrategiesCollected;
    public bool dropZoneComplete;
    public GameObject phase07FoodStrategyObject01;
    public GameObject phase07FoodStrategyObject02;
    public GameObject phase07FoodStrategyObject03;
    public GameObject phase07FoodStrategyObject04;
    public bool phase07FoodStrategy01Selected;
    public bool phase07FoodStrategy02Selected;
    public bool phase07FoodStrategy03Selected;
    public bool phase07FoodStrategy04Selected;
    public MenuOptions menuOptions;
    private int AmountSelected;
    public GameObject phase07FoodStrategyPanel;
    public string goalString01;
    public string foodStrategyString01;
    public string foodStrategyString02;
    public string foodStrategyString03;
    public string foodStrategyString04;

    public void OnDrop(PointerEventData pointerEventData)
    {
        draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        int pos = System.Array.IndexOf(draggable.dropAreaNumber, dropAreaNumber);
        if (pos > -1)
        {
            if (draggable.evidencePosNumber == 1)
            {
                if (!phase07FoodStrategy01Selected)
                {
                    if (AmountSelected == 0) {
                        menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString01);
						phase07FoodStrategyObject01.SetActive(true);
						phase07FoodStrategy01Selected = true;
                        phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
                        amountOfFoodStrategiesCollected++;
                        AmountSelected++;
                    } else if (AmountSelected == 1) {                        
                        menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString01);                        
						phase07FoodStrategyObject01.SetActive(true);
						phase07FoodStrategy01Selected = true;
                        phase07FoodStrategyObject01.transform.SetSiblingIndex(1);
                        amountOfFoodStrategiesCollected++;
                        AmountSelected++;
                    }
                    else if (AmountSelected > 1) {                        
						if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject02.name) {                            
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject03.name) {
                                phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
							} else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject04.name) {
                                phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
                            }
							print("Evidence Pos 1, object 2" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 1, object 2 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 1, object 2 actual gameobject" + phase07FoodStrategyObject02.name);
							phase07FoodStrategyObject02.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject02.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString02);
							phase07FoodStrategy02Selected = false;
                        }
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject03.name) {                            
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject02.name)
                            {
                                phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
                            }
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject04.name)
                            {
                                phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
                            }
							phase07FoodStrategyObject03.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject03.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString03);
							phase07FoodStrategy03Selected = false;
							print("Evidence Pos 1, object 3" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 1, object 3 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 1, object 3 actual gameobject" + phase07FoodStrategyObject03.name);
                        }
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject04.name)
                        {                            
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject02.name)
                            {
                                phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
                            }
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject03.name)
                            {
                                phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
                            }
							phase07FoodStrategyObject04.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject04.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString04);
							phase07FoodStrategy04Selected = false;
							print("Evidence Pos 1, object 4" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 1, object 4 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 1, object 4 actual gameobject" + phase07FoodStrategyObject04.name);
                        }
                        phase07FoodStrategy01Selected = true;                        
                        phase07FoodStrategyObject01.SetActive(true);
                        phase07FoodStrategyObject01.transform.SetSiblingIndex(1);
                        menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString01);
                    }                    
                }
				if (amountOfFoodStrategiesCollected >= amountOfFoodStrategiesNeededToComplete)
				{
					dropZoneComplete = true;
				}
            }
			if (draggable.evidencePosNumber == 2)
			{
				if (!phase07FoodStrategy02Selected)
				{
					if (AmountSelected == 0) {
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString02);
						phase07FoodStrategyObject02.SetActive(true);
						phase07FoodStrategy02Selected = true;
						phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
						amountOfFoodStrategiesCollected++;
						AmountSelected++;
					} else if (AmountSelected == 1) {                        
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString02);                        
						phase07FoodStrategyObject02.SetActive(true);
						phase07FoodStrategy02Selected = true;
						phase07FoodStrategyObject02.transform.SetSiblingIndex(1);
						amountOfFoodStrategiesCollected++;
						AmountSelected++;
					}
					else if (AmountSelected > 1) {                        
						if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject01.name) {                            
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject03.name) {
								phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
							} else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject04.name) {
								phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
							}
							print("Evidence Pos 2, object 1" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 2, object 1 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 2, object 1 actual gameobject" + phase07FoodStrategyObject01.name);
							phase07FoodStrategyObject01.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject01.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString01);
							phase07FoodStrategy01Selected = false;
						}
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject03.name) {							
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject01.name)
							{
								phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
							}
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject04.name)
							{
								phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
							}
							phase07FoodStrategyObject03.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject03.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString03);
							phase07FoodStrategy03Selected = false;
							print("Evidence Pos 2, object 3" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 2, object 3 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 2, object 3 actual gameobject" + phase07FoodStrategyObject03.name);
						}
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject04.name)
						{							
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject01.name)
							{
								phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
							}
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject03.name)
							{
								phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
							}
							phase07FoodStrategyObject04.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject04.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString04);
							phase07FoodStrategy04Selected = false;
							print("Evidence Pos 2, object 4" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 2, object 4 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 2, object 4 actual gameobject" + phase07FoodStrategyObject04.name);
						}
						phase07FoodStrategy02Selected = true;                        
						phase07FoodStrategyObject02.SetActive(true);
						phase07FoodStrategyObject02.transform.SetSiblingIndex(1);
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString02);
					}                    
				}
				if (amountOfFoodStrategiesCollected >= amountOfFoodStrategiesNeededToComplete)
				{
					dropZoneComplete = true;
				}
			}
			if (draggable.evidencePosNumber == 3)
			{
				if (!phase07FoodStrategy03Selected)
				{
					if (AmountSelected == 0) {
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString03);
						phase07FoodStrategyObject03.SetActive(true);
						phase07FoodStrategy03Selected = true;
						phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
						amountOfFoodStrategiesCollected++;
						AmountSelected++;
					} else if (AmountSelected == 1) {                        
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString03);                        
						phase07FoodStrategyObject03.SetActive(true);
						phase07FoodStrategy03Selected = true;
						phase07FoodStrategyObject03.transform.SetSiblingIndex(1);
						amountOfFoodStrategiesCollected++;
						AmountSelected++;
					}
					else if (AmountSelected > 1) {                        
						if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject01.name) {                            
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject02.name) {
								phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
							} else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject04.name) {
								phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
							}
							print("Evidence Pos 3, object 1" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 3, object 1 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 3, object 1 actual gameobject" + phase07FoodStrategyObject02.name);
							phase07FoodStrategyObject01.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject01.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString01);
							phase07FoodStrategy01Selected = false;
						}
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject02.name) {							
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject01.name)
							{
								phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
							}
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject04.name)
							{
								phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
							}
							phase07FoodStrategyObject02.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject02.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString02);
							phase07FoodStrategy02Selected = false;
							print("Evidence Pos 3, object 2" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 3, object 2 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 3, object 2 actual gameobject" + phase07FoodStrategyObject02.name);
						}
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject04.name)
						{							
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject01.name)
							{
								phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
							}
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject02.name)
							{
								phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
							}
							phase07FoodStrategyObject04.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject04.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString04);
							phase07FoodStrategy04Selected = false;
							print("Evidence Pos 3, object 4" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 3, object 4 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 3, object 4 actual gameobject" + phase07FoodStrategyObject04.name);
						}
						phase07FoodStrategy03Selected = true;                        
						phase07FoodStrategyObject03.SetActive(true);
						phase07FoodStrategyObject03.transform.SetSiblingIndex(1);
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString03);
					}                    
				}
				if (amountOfFoodStrategiesCollected >= amountOfFoodStrategiesNeededToComplete)
				{
					dropZoneComplete = true;
				}
			}
			if (draggable.evidencePosNumber == 4)
			{
				if (!phase07FoodStrategy04Selected)
				{
					if (AmountSelected == 0) {
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString04);
						phase07FoodStrategyObject04.SetActive(true);
						phase07FoodStrategy04Selected = true;
						phase07FoodStrategyObject04.transform.SetSiblingIndex(0);
						amountOfFoodStrategiesCollected++;
						AmountSelected++;
					} else if (AmountSelected == 1) {                        
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString04);                        
						phase07FoodStrategyObject04.SetActive(true);
						phase07FoodStrategy04Selected = true;
						phase07FoodStrategyObject04.transform.SetSiblingIndex(1);
						amountOfFoodStrategiesCollected++;
						AmountSelected++;
					}
					else if (AmountSelected > 1) {                        
						if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject01.name) {                            
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject02.name) {
								phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
							} else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject03.name) {
								phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
							}
							phase07FoodStrategyObject01.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject01.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString01);
							phase07FoodStrategy01Selected = false;
							print("Evidence Pos 4, object 1" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 4, object 1 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 4, object 1 actual gameobject" + phase07FoodStrategyObject01.name);
						}
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject02.name) {							
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject01.name)
							{
								phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
							}
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject03.name)
							{
								phase07FoodStrategyObject03.transform.SetSiblingIndex(0);
							}
							phase07FoodStrategyObject02.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject02.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString02);
							phase07FoodStrategy02Selected = false;
							print("Evidence Pos 4, object 2" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 4, object 2 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 4, object 2 actual gameobject" + phase07FoodStrategyObject02.name);
						}
						else if (phase07FoodStrategyPanel.transform.GetChild(0).name == phase07FoodStrategyObject03.name)
						{
							phase07FoodStrategyObject03.transform.SetSiblingIndex(3);
							phase07FoodStrategyObject03.SetActive(false);
							menuOptions.phase07FoodStrategyStringArray.Remove(foodStrategyString03);
							phase07FoodStrategy03Selected = false;
							if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject01.name)
							{
								phase07FoodStrategyObject01.transform.SetSiblingIndex(0);
							}
							else if (phase07FoodStrategyPanel.transform.GetChild(1).name == phase07FoodStrategyObject02.name)
							{
								phase07FoodStrategyObject02.transform.SetSiblingIndex(0);
							}
							print("Evidence Pos 4, object 3" + phase07FoodStrategyPanel.transform.GetChild(0).gameObject.activeSelf);
							print("Evidence Pos 4, object 3 name" + phase07FoodStrategyPanel.transform.GetChild(0).name);
							print ("Evidence Pos 4, object 3 actual gameobject" + phase07FoodStrategyObject04.name);
						}
						phase07FoodStrategy04Selected = true;                        
						phase07FoodStrategyObject04.SetActive(true);
						phase07FoodStrategyObject04.transform.SetSiblingIndex(1);
						menuOptions.phase07FoodStrategyStringArray.Add(foodStrategyString04);
						if (amountOfFoodStrategiesCollected >= amountOfFoodStrategiesNeededToComplete)
						{
							dropZoneComplete = true;
						}
					}                    
				}
				if (amountOfFoodStrategiesCollected >= amountOfFoodStrategiesNeededToComplete)
				{
					dropZoneComplete = true;
				}
			}
        }
        else if (pos < 0)
        {
            menuOptions.phase6part01AlertMessageText.text = "This food strategy does not match this goal. Please try again.";
            menuOptions.Phase06Part01AlertMessageToggle();
        }
    }
}