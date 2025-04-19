using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliderBehavior : MonoBehaviour
{
    public Slider Ialt;

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
    //"Gode" knapper:
    public Button Vand;
    public Button Aktiv;
    public Button Mediter;
    public Button Varieret;
    public Button Psykolog;
    //"Dårlige" knapper:
    public Button Soda;
    public Button Inaktiv;
    public Button fastFood;
    public Button Alkohol;
    public Button Ryg;

    void Update()
    {
        Lunger.value -= Random.Range(0, 0.4f) * Time.deltaTime;
        Hjertet.value -= Random.Range(0, 0.4f) * Time.deltaTime;
        Lever.value -= Random.Range(0, 0.9f) * Time.deltaTime;
        Nyrer.value -= Random.Range(0, 0.9f) * Time.deltaTime;
        Maven.value -= Random.Range(0, 0.9f) * Time.deltaTime;
        Tørst.value += Random.Range(0, 1.65f) * Time.deltaTime;
        Sult.value += Random.Range(0, 1.65f) * Time.deltaTime;
        Depres.value += Random.Range(0, 0.8f) * Time.deltaTime;
        Angst.value += Random.Range(0, 0.9f) * Time.deltaTime;
        Stress.value += Random.Range(0, 0.75f) * Time.deltaTime;

        Ialt.value = ((Lunger.value / 100 * Hjertet.value / 100 * Lever.value / 100 * Nyrer.value / 100 * Maven.value / 100) - (((Tørst.value / 100 * Sult.value / 100) / 2) * Depres.value / 100 * Angst.value / 100 * Stress.value / 100));
        //Debug.Log(Ialt.value);


        if(Lunger.value <= 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Hjertet.value <= 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Lever.value <= 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Nyrer.value <= 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Maven.value <= 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Tørst.value >= 99)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Sult.value >= 99)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Depres.value >= 99)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Angst.value >= 99)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Stress.value >= 99)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void VandClicked()
    {
        Tørst.value -= Random.Range(15, 21);
        Sult.value -= Random.Range(3, 6);
        Nyrer.value += Random.Range(3, 9);
    }

    public void AktivClicked()
    {
        Lunger.value += Random.Range(9, 18);
        Hjertet.value += Random.Range(9, 15);
        Depres.value -= Random.Range(3, 6);
        Angst.value -= Random.Range(3, 4.5f);
        Sult.value += Random.Range(6, 12);
        Tørst.value += Random.Range(6, 15);
        Stress.value += Random.Range(6, 9);
    }

    public void MediterClicked()
    {
        Stress.value -= Random.Range(6, 18);
    }

    public void VarieretClicked()
    {
        Sult.value -= Random.Range(6, 15);
        Lever.value += Random.Range(3, 9);
        Maven.value += Random.Range(6, 12);
        Stress.value += Random.Range(3, 6);
    }

    public void PsykologClicked()
    {
        Depres.value -= Random.Range(6, 15);
        Angst.value -= Random.Range(6, 15);
        Stress.value -= Random.Range(6, 12);
    }

    public void SodaClicked()
    {
        Tørst.value -= Random.Range(12, 18);
        Nyrer.value -= Random.Range(3, 6);
        Maven.value -= Random.Range(3, 6);
        Depres.value += Random.Range(0, 4.5f);
    }

    public void InaktivClicked()
    {
        Hjertet.value -= Random.Range(6, 10.5f);
        Stress.value -= Random.Range(3, 9);
        Lunger.value -= Random.Range(3, 9);
    }

    public void FastClicked()
    {
        Sult.value -= Random.Range(8, 14);
        Stress.value += Random.Range(3, 9);
        Hjertet.value -= Random.Range(6, 12);

    }

    public void AlkoClicked()
    {
        Hjertet.value -= Random.Range(3, 6);
        Lever.value -= Random.Range(6, 15);
        Nyrer.value -= Random.Range(6, 9);
        Maven.value -= Random.Range(6, 12);
        Tørst.value -= Random.Range(3, 6);
        Depres.value += Random.Range(3, 9);
        Angst.value += Random.Range(3, 6);
    }

    public void RygClicked()
    {
        Lunger.value -= Random.Range(3, 9);
        Stress.value -= 3;
    }

}
