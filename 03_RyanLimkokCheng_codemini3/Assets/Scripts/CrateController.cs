using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateController : MonoBehaviour
{
    public Animator MovingPlatform;
    bool movingplattrig = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingplattrig == true)
        {
            MovingPlatform.SetTrigger("MovingTrig");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            movingplattrig = true;
        }
    }
}
