using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterGroth : MonoBehaviour
{
    public Transform Baby;
    public Transform Kid;
    public Transform Teen;
    public Transform Adult;             //Her tager vi Transform oplysningerne på specifikke objekter
    public Transform Old;
    public Transform Cane;
    public Transform RIP;
    public Transform GamePlace;         //Her er det Transform oplysningerne for et objekt inden for spil skærmen
    public Transform AwayPlace;         //Her er det Transform oplysningerne for et objekt udenfor spil skærmen

    void Update()
    {
       if(Age.currentAge >= 5)                      //Når "currentAge" i Age.cs er over 5, så skifter den position på nogle opbjekter 
        {
            Baby.position = AwayPlace.position;
            Kid.position = GamePlace.position;
        }

        if (Age.currentAge >= 13)
        {
            Age.increasedPerSecond = 0.15f;
            Kid.position = AwayPlace.position;
            Teen.position = GamePlace.position;
        }

        if (Age.currentAge >= 19)
        {
            Age.increasedPerSecond = 0.2f;
            Teen.position = AwayPlace.position;
            Adult.position = GamePlace.position;
        }

        if (Age.currentAge >= 44)
        {
            Age.increasedPerSecond = 0.3f;
            Adult.position = AwayPlace.position;
            Old.position = GamePlace.position;
        }

        if (Age.currentAge >= 68)
        {
            Age.increasedPerSecond = 0.5f;
            Old.position = AwayPlace.position;
            Cane.position = GamePlace.position;
        }

        if (Age.currentAge >= 80)
        {
            Cane.position = AwayPlace.position;
            RIP.position = GamePlace.position;
            Age.currentAge = 83;
        }

    }
}
