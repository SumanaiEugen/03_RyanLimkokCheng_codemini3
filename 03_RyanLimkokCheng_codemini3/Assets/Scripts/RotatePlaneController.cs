using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlaneController : MonoBehaviour
{
    bool ConeTrig = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ConeTrig == true)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ConeTrig = true;
        }
    }
}
