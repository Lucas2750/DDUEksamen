using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Age : MonoBehaviour
{
    public Text textBox;                                        //Her bliver der defineret et Text objekt
    public static float currentAge;                             //Her definere vi hvor gammel man er, og der står static så andre scripts kan tilgå det
    public static float increasedPerSecond;                     //Her defineres hvor hurtigt man skal stige i alder

    void Start()
    {
        currentAge = 0f;                                        //Ens alder i starten defineres som 0
        increasedPerSecond = 0.6f;                              //Ens alder stiger med 0.6 per sekund
    }


    void Update()
    {
        textBox.text = "Alder: " + (int)currentAge;             //i tekstboksen skal der stå "Alder: (ens nuverænde alder i heltal)"
        currentAge += increasedPerSecond * Time.deltaTime;      //Ens nuværende alder stiger med 0.15 per sekund 
    }
}
