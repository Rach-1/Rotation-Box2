using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignSkin: MonoBehaviour
{
    public int SelectedSkin;
    public Sprite standart;
    public Sprite random;
    public Sprite math;
    public Sprite karta;
    public Sprite rim;

    public GameObject Ball;
    void Start()
    {
        if (PlayerPrefs.HasKey("Selected"))
        {
            SelectedSkin = PlayerPrefs.GetInt("Selected");
        }
        SelectedSkin = PlayerPrefs.GetInt("Selected");
        if (SelectedSkin == 1)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = math;
        }
        else if (SelectedSkin == 2)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = random;
        }
        else if (SelectedSkin == 3)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = karta;
        }
        else if (SelectedSkin == 4)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = rim;
        }
        else
        {
            Ball.GetComponent<SpriteRenderer>().sprite = standart;
        }
    }

}
