using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Rotation : MonoBehaviour
{
    public int Money;

    [SerializeField] AudioClip rote;

    private Transform trans;
    public Box box;
    public Box box1;
    public Box box2;
    public Box box3;
    public Box box4;
    private int Grad = 0;
    public float rotationSpeed = 90f; // Швидкість обертання в градусах за секунду
    private bool isRotating = false;

    public ChangeColorDoor door;

    void Awake()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            Money = PlayerPrefs.GetInt("Money");
        }
        PlayerPrefs.SetInt("Money", Money);
    }
    public void PlaySound()
    {
        GetComponent<AudioSource>().PlayOneShot(rote);
        //door.ColorSwitch();
    }
    //public void Right()
    //{
    //    if (box.isStopped && box1.isStopped && box2.isStopped && box3.isStopped && box4.isStopped)
    //    {
    //        Grad -= 90;
    //        transform.rotation = Quaternion.Euler(0, 0, Grad);
    //        PlaySound();
    //    }
    //}
    //public void Left()
    //{
    //    if (box.isStopped && box1.isStopped && box2.isStopped && box3.isStopped && box4.isStopped)
    //    {
    //        Grad += 90;
    //        transform.rotation = Quaternion.Euler(0, 0, Grad);
    //        PlaySound();
    //    }
    //}
    public void Right()
    {
        if (!isRotating)
        {
            StartCoroutine(RotateR90Degrees());
        }
    }
    public void Left()
    {
        if (!isRotating)
        {
            StartCoroutine(RotateL90Degrees());
        }
    }

    private IEnumerator RotateR90Degrees()
    {
        isRotating = true;
        PlaySound();

        // Збереження дочірніх об'єктів і їх Rigidbody
        Rigidbody[] childRigidbodies = GetComponentsInChildren<Rigidbody>();

        // Вимкнення гравітації у дочірніх об'єктів
        foreach (var rb in childRigidbodies)
        {
            rb.useGravity = false;
        }

        float targetRotation = transform.eulerAngles.z - 90;
        float initialRotation = transform.eulerAngles.z;
        float rotationProgress = 0f;

        while (rotationProgress < 1f)
        {
            rotationProgress += Time.deltaTime * rotationSpeed / 90;
            float currentRotation = Mathf.Lerp(initialRotation, targetRotation, rotationProgress);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentRotation);
            yield return null;
        }

        // Гарантуємо точність фінальної позиції
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, targetRotation);

        // Увімкнення гравітації у дочірніх об'єктів
        foreach (var rb in childRigidbodies)
        {
            rb.useGravity = true;
        }

        isRotating = false;
    }
    private IEnumerator RotateL90Degrees()
    {
        isRotating = true;
        PlaySound();

        // Збереження дочірніх об'єктів і їх Rigidbody
        Rigidbody[] childRigidbodies = GetComponentsInChildren<Rigidbody>();

        // Вимкнення гравітації у дочірніх об'єктів
        foreach (var rb in childRigidbodies)
        {
            rb.useGravity = false;
        }

        float targetRotation = transform.eulerAngles.z + 90;
        float initialRotation = transform.eulerAngles.z;
        float rotationProgress = 0f;

        while (rotationProgress < 1f)
        {
            rotationProgress += Time.deltaTime * rotationSpeed / 90;
            float currentRotation = Mathf.Lerp(initialRotation, targetRotation, rotationProgress);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentRotation);
            yield return null;
        }

        // Гарантуємо точність фінальної позиції
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, targetRotation);

        // Увімкнення гравітації у дочірніх об'єктів
        foreach (var rb in childRigidbodies)
        {
            rb.useGravity = true;
        }

        isRotating = false;
    }
}

