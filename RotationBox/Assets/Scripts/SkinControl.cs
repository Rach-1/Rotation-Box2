using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinControl : MonoBehaviour
{

    public int skinNum;
    public bool isPurchased;
    public string ppname;
    public int price;
    public int purch;
    public Image iLock;
    public Image iEquip;
    public Text priceText;
    Money mon;

    public Sprite equipped;
    public Sprite equip;
    public Sprite falseLock;
    public Sprite trueLock;

    private void Start()
    {
        mon = FindObjectOfType<Money>();
        purch = PlayerPrefs.GetInt(ppname, 0);
        if(purch == 0)
        {
            priceText.text = price.ToString();
            iLock.GetComponent<Image>().sprite = trueLock;
            if(PlayerPrefs.GetInt("Selected") == skinNum)
            {
                iEquip.GetComponent<Image>().sprite = equipped;
            }
            else
            {
                iEquip.GetComponent<Image>().sprite = equip;
            }
        }
        else
        {
            iLock.GetComponent<Image>().sprite = falseLock;
            isPurchased = true;
            priceText.text = price.ToString();
            if (PlayerPrefs.GetInt("Selected") == skinNum)
            {
                iEquip.GetComponent<Image>().sprite = equipped;
            }
            else
            {
                iEquip.GetComponent<Image>().sprite = equip;
            }
        }
    }
    public void Buy()
    {
        if(mon.money >= price && isPurchased == false)
        {
            PlayerPrefs.SetInt("Money", mon.money -= price);
            mon.Buy();
            PlayerPrefs.SetInt(ppname, 1);
            iLock.GetComponent<Image>().sprite = falseLock;
            priceText.text = "0";
            price = 0;
        }
        else if(isPurchased)
        {
            PlayerPrefs.SetInt("Selected", skinNum);
            iEquip.GetComponent<Image>().sprite = equipped;
        }
    }
    public void Equip()
    {
        if (isPurchased)
        {
            PlayerPrefs.SetInt("Selected", skinNum);
            iEquip.GetComponent<Image>().sprite = equipped;
        }
    }
}
