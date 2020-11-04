using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
  *  this component lets the player control the character using the arrow keys
  */

public class P2_Controller : MonoBehaviour
{

    [SerializeField]
    float Speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) // up and right
        {
            transform.position += new Vector3(Speed / 2 * Time.deltaTime, Speed / 2 * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) // right and down
        {
            transform.position += new Vector3(Speed / 2 * Time.deltaTime, -(Speed / 2 * Time.deltaTime), 0f);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) // down and left
        {
            transform.position += new Vector3(-(Speed / 2 * Time.deltaTime), -(Speed / 2 * Time.deltaTime), 0f);
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))// left and up
        {
            transform.position += new Vector3(-(Speed / 2 * Time.deltaTime), Speed / 2 * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.W)) // up
        {
            transform.position += new Vector3(0f, Speed * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.D)) // right
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.S)) // down
        {
            transform.position += new Vector3(0f, -(Speed * Time.deltaTime), 0f);
        }
        else if (Input.GetKey(KeyCode.A)) // left
        {
            transform.position += new Vector3(-(Speed * Time.deltaTime), 0f, 0f);
        }
    }
}
