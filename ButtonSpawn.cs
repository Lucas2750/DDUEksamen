using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour
{
    public Transform U_b1;
    public Transform U_b2;
    public Transform U_b3;
    public Transform U_b4;
    public Transform U_b5;
    public Transform S_b1;
    public Transform S_b2;
    public Transform S_b3;
    public Transform S_b4;
    public Transform S_b5;
    public Transform U_b1_place;
    public Transform U_b2_place;
    public Transform U_b3_place;
    public Transform U_b4_place;
    public Transform U_b5_place;
    public Transform S_b1_place;
    public Transform S_b2_place;
    public Transform S_b3_place;
    public Transform S_b4_place;
    public Transform S_b5_place;


    void Update()
    {
        if(Age.currentAge >= 6)
        {
            U_b1.position = U_b1_place.position;
            U_b2.position = U_b2_place.position;
            S_b1.position = S_b1_place.position;
            S_b2.position = S_b2_place.position;

        }  

        if(Age.currentAge >= 13)
        {
            U_b3.position = U_b3_place.position;
            S_b4.position = S_b4_place.position;
            S_b5.position = S_b5_place.position;
        }

        if(Age.currentAge >= 15)
        {
            S_b3.position = S_b3_place.position;
            U_b4.position = U_b4_place.position;
        }

        if(Age.currentAge >= 18)
        {
            U_b5.position = U_b5_place.position;
        }
    }
}
