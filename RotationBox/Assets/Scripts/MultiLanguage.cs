using Assets.SimpleLocalization.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiLanguage : MonoBehaviour
{
    private void Awake()
    {
        LocalizationManager.Read();
        switch (Application.systemLanguage)
        {
            case SystemLanguage.Ukrainian:
                LocalizationManager.Language = "Ukrainian";
                break;
            case SystemLanguage.Russian:
                LocalizationManager.Language = "Ukrainian";
                break;
            case SystemLanguage.Belarusian:
                LocalizationManager.Language = "Ukrainian";
                break;
            default:
                LocalizationManager.Language = "English";
                break;
        }
    }

    public void Language(string language)
    {
        LocalizationManager.Language = language;
    }
}
