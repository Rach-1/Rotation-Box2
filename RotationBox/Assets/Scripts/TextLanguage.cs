using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLanguage : MonoBehaviour
{
    public string language;

    private Text text;

    [SerializeField] string TextUa;
    [SerializeField] string TextEng;
    [SerializeField] string TextSpa;
    [SerializeField] string TextGer;
    [SerializeField] string TextFra;
    [SerializeField] string TextInd;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        language = PlayerPrefs.GetString("language");

        if (language == "" || language == "Eng")
        {
            text.text = TextEng;
        }
        else if (language == "Ua")
        {
            text.text = TextUa;
        }
        else if (language == "Spa")
        {
            text.text = TextSpa;
        }
        else if (language == "Ger")
        {
            text.text = TextGer;
        }
        else if (language == "Fra")
        {
            text.text = TextFra;
        }
        else if (language == "Ind")
        {
            text.text = TextInd;
        }
    }
}
