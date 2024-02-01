using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorDoor : MonoBehaviour
{
    [SerializeField] private Rotation rot;
    public GameObject Door;
    public Color colorGreen;
    public Color colorBlue;
    public Color colorRed;
    // Start is called before the first frame update
    void Start()
    {
    Door.GetComponent<Renderer>().material.color = ;
    }

    // Update is called once per frame
    void Update()
    {
        if(rot.IsRot)
        {

        }
    }
}
