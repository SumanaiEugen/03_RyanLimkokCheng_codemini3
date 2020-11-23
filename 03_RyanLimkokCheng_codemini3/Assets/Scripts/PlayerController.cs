using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator PlayerAnim;
    float Speed = 5f;
    public Rigidbody PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            PlayerAnim.SetBool("IsMoving", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            PlayerAnim.SetBool("IsMoving", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            PlayerAnim.SetBool("IsMoving", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            PlayerAnim.SetBool("IsMoving", true);
        }
        //On Release
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            PlayerAnim.SetBool("IsMoving", false);
        }
    }

}
