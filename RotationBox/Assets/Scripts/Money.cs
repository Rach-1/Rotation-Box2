using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money = 0;
    [SerializeField] Text counter;

    void Awake()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }
        money = PlayerPrefs.GetInt("Money");
        PlayerPrefs.SetInt("Money", money);
        counter.text = money.ToString();
    }

    public void Buy()
    {
        money = PlayerPrefs.GetInt("Money");
        PlayerPrefs.SetInt("Money", money);
        counter.text = money.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        money++;
        counter.text = money.ToString();
        PlayerPrefs.SetInt("Money", money);
        Destroy(this.gameObject);
    }
}
