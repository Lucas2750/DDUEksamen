using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenario : MonoBehaviour
{
    public Transform Scenario1;
    public Transform Scenario2;
    public Transform Scenario3;
    public Transform Scenario4;
    public Transform AwayScenario;
    public Transform In;

    //Fysiske sliders:
    public Slider Lunger;
    public Slider Hjertet;
    public Slider Lever;
    public Slider Nyrer;
    public Slider Maven;
    //Psykiske sliders:
    public Slider Tørst;
    public Slider Sult;
    public Slider Depres;
    public Slider Angst;
    public Slider Stress;



    void Update()
    {
        /*
        Random rnd = new Random();
        int Chance1 = rnd.Next(1, 2);
        int Chance2 = rnd.Next(1, 2);
        int Chance3 = rnd.Next(1, 2);
        int Chance4 = rnd.Next(1, 2);

        int Age1 = rnd.Next(14, 18);
        int Age2 = rnd.Next(13, 19);
        int Age3 = rnd.Next(10, 19);
        int Age4 = rnd.Next(16, 25);
        

        Debug.Log(Age4);
        

        if(Age1 ==Age2)
        {
            Age2 = Age2 + 1;
        }

        if(Age1 ==Age3)
        {
            Age3 = Age3 + 1;
        }

        if(Age1 ==Age4)
        {
            Age4 = Age4 - 1;
        }

        if(Age2 ==Age3)
        {
            Age3 = Age3 + 1;
        }

        if(Age2 ==Age4)
        {
            Age4 = Age4 - 1;
        }

        if(Age3 ==Age4)
        {
            Age4 = Age4 - 1;
        }
        */

            if (Age.currentAge >= 18)
            {
                Scenario1.position = In.position;
                //Age.increasedPerSecond = 0.0f;
            }

            if (Age.currentAge >= 15)
            {
                Scenario2.position = In.position;
                //Age.increasedPerSecond = 0.0f;
            }

            if (Age.currentAge >= 11)
            {
                Scenario3.position = In.position;
                //Age.increasedPerSecond = 0.0f;
            }

            if (Age.currentAge >= 23)
            {
                Scenario4.position = In.position;
                //Age.increasedPerSecond = 0.0f;
            }

    }

    public void Ja1()
    {
        Destroy(Scenario1.gameObject);
        Age.increasedPerSecond = 0.1f;
        Depres.value -= Random.Range(-1, 4);
        Tørst.value -= Random.Range(1, 4);
        Stress.value += Random.Range(0, 2);
    }

    public void Nej1()
    {
        Destroy(Scenario1.gameObject);
        Age.increasedPerSecond = 0.1f;
        Depres.value -= Random.Range(-1, 2);
    }

    public void Ja2()
    {
        Destroy(Scenario2.gameObject);
        Age.increasedPerSecond = 0.1f;
        Depres.value -= Random.Range(-1, 3);
        Hjertet.value -= Random.Range(2, 4);
        Stress.value += Random.Range(-1, 2);
    }

    public void Nej2()
    {
        Destroy(Scenario2.gameObject);
        Age.increasedPerSecond = 0.1f;
        Depres.value -= Random.Range(1, 3);
        Stress.value -= Random.Range(-1, 2);
        Sult.value -= Random.Range(2, 5);
        Lever.value += Random.Range(1, 3);
        Maven.value += Random.Range(2, 4);
    }

    public void Ja3()
    {
        Destroy(Scenario3.gameObject); 
        Age.increasedPerSecond = 0.6f;
        Depres.value -= Random.Range(-1, 4);
        Angst.value -= Random.Range(-2, 2);
        Stress.value += Random.Range(2, 4);
    }

    public void Nej3()
    {
        Destroy(Scenario3.gameObject);
        Age.increasedPerSecond = 0.6f;
        Depres.value -= Random.Range(-2, 2);
        Stress.value -= Random.Range(-1, 5);
        Angst.value -= Random.Range(2, 6);
    }

    public void Ja4()
    {
        Destroy(Scenario4.gameObject);
        Age.increasedPerSecond = 0.05f;
        Lunger.value -= Random.Range(2, 5);
        Stress.value -= 1;
    }

    public void Nej4()
    {
        Destroy(Scenario4.gameObject);
        Age.increasedPerSecond = 0.05f;
        Depres.value -= 2;
    }
}
