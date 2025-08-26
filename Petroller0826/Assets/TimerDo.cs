using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerDo : MonoBehaviour
{
    float currentTime;
    public float startingTime = 20f;

    [SerializeField] TextMeshProUGUI textMeshPro;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
        currentTime -= 1 * Time.deltaTime;
        textMeshPro.text = currentTime.ToString("0");
        }

        //if (currentTime <= 0)
        //{
           // currentTime = 0;
            // Your Code Here
        //}
    }
}

