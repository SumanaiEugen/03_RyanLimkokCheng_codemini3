using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePlatform : MonoBehaviour
{
    int KeyCount = 0;
    int KeyTotal;
    int TotalTimeOntimer = 0;

    bool RotateTrig = false;
    bool rotated = false;
    float TotalTime = 10;
    float CurrentTime = 0;

    public GameObject Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer.GetComponent<Text>().text = "Timer: 10";
    }

    // Update is called once per frame
    void Update()
    {
        KeyTotal = GameObject.FindGameObjectsWithTag("Key").Length;

        if (RotateTrig == true && rotated == true)
        {
            //conversion
            CurrentTime = Time.deltaTime;
            TotalTime -= CurrentTime;
            TotalTimeOntimer = (int)TotalTime;
            //text
            Timer.GetComponent<Text>().text = "Timer: " + TotalTimeOntimer;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if(TotalTimeOntimer == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            TotalTime = 10f;

            rotated = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && KeyTotal == KeyCount)
        {
            RotateTrig = true;
            rotated = true;
        }
    }
}
