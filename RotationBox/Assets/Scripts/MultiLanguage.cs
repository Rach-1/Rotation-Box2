using Assets.SimpleLocalization.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings.Switch;

public class MultiLanguage : MonoBehaviour
{
    private void Awake()
    {
        string Localization = PlayerPrefs.GetString("Localization");
        LocalizationManager.Read();
        if (Localization == null)
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Ukrainian:
                    LocalizationManager.Language = "Ukrainian";
                    PlayerPrefs.SetString("Localization", "Ukrainian");
                    break;
                case SystemLanguage.Russian:
                    LocalizationManager.Language = "Ukrainian";
                    PlayerPrefs.SetString("Localization", "Ukrainian");
                    break;
                case SystemLanguage.Belarusian:
                    LocalizationManager.Language = "Ukrainian";
                    PlayerPrefs.SetString("Localization", "Ukrainian");
                    break;
                case SystemLanguage.Spanish:
                    LocalizationManager.Language = "Spanish";
                    PlayerPrefs.SetString("Localization", "Spanish");
                    break;
                default:
                    LocalizationManager.Language = "English";
                    PlayerPrefs.SetString("Localization", "English");
                    break;
            }
        }
        else
        {
            PlayerPrefs.SetString("Localization", Localization);
            Language(Localization);
        }
    }

    public void Language(string language)
    {
        LocalizationManager.Language = language;
        PlayerPrefs.SetString("Localization", language);
    }
}
