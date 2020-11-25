using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Animator PlayerAnim;
    public Rigidbody PlayerRb;
    public GameObject RotatePlatform;

    float KeyCollected = 0f;
    float Speed = 5f;

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

        //falls off
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("LoseScene");
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
        }
        
        if(other.gameObject.tag == "Target")
        {
                SceneManager.LoadScene("WinScene");
        }
    }
}
