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
                case SystemLanguage.French:
                    LocalizationManager.Language = "French";
                    PlayerPrefs.SetString("Localization", "French");
                    break;
                case SystemLanguage.Chinese:
                    LocalizationManager.Language = "Chinese";
                    PlayerPrefs.SetString("Localization", "Chinese");
                    break;
                case SystemLanguage.ChineseTraditional:
                    LocalizationManager.Language = "Chinese";
                    PlayerPrefs.SetString("Localization", "Chinese");
                    break;
                case SystemLanguage.ChineseSimplified:
                    LocalizationManager.Language = "Chinese";
                    PlayerPrefs.SetString("Localization", "Chinese");
                    break;
                case SystemLanguage.Arabic:
                    LocalizationManager.Language = "Arabic";
                    PlayerPrefs.SetString("Localization", "Arabic");
                    break;
                case SystemLanguage.Hindi:
                    LocalizationManager.Language = "Hindi";
                    PlayerPrefs.SetString("Localization", "Hindi");
                    break;
                default:
                    LocalizationManager.Language = "English";
                    PlayerPrefs.SetString("Localization", "English");
                    break;
            } // ��� �������� ���� � ��������� �� ��������� �����������
        }
        else
        {
            PlayerPrefs.SetString("Localization", Localization);
            Language(Localization);
        }// ��� ������������� ���� � PlayerPrefs ���� �� ��� �� ������ ������ ���
    }

    public void Language(string language)
    {
        LocalizationManager.Language = language;
        PlayerPrefs.SetString("Localization", language);
    } // �� ��� ������ ���� ����
}
