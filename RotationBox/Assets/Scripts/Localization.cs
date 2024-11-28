using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour
{
    public void Ua()
    {
        string language = "Ua";
        PlayerPrefs.SetString("language", language);
    }
    public void Eng()
    {
        string language = "Eng";
        PlayerPrefs.SetString("language", language);
    }
    public void Spa()
    {
        string language = "Spa";
        PlayerPrefs.SetString("language", language);
    }
    public void Ger()
    {
        string language = "Ger";
        PlayerPrefs.SetString("language", language);
    }
    public void Fra()
    {
        string language = "Fra";
        PlayerPrefs.SetString("language", language);
    }
    public void Ind()
    {
        string language = "Ind";
        PlayerPrefs.SetString("language", language);
    }

}
