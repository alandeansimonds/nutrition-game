using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ComputerTime : MonoBehaviour {
    public Text clockText;
    public Text dateText;


    void Update() {
        System.DateTime time = System.DateTime.Now;
        clockText.text = time.ToString("hh:mm");
        dateText.text = time.ToString("dd/MM/yyyy");
    }
}
