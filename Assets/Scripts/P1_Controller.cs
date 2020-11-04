using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*  this component lets the player control the character using the arrow keys
*/

public class P1_Controller : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) // up and right
        {
            transform.position += new Vector3(Speed / 2 * Time.deltaTime, Speed / 2 * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) // right and down
        {
            transform.position += new Vector3(Speed / 2 * Time.deltaTime, -(Speed / 2 * Time.deltaTime), 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) // down and left
        {
            transform.position += new Vector3(-(Speed / 2 * Time.deltaTime), -(Speed / 2 * Time.deltaTime), 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))// left and up
        {
            transform.position += new Vector3(-(Speed / 2 * Time.deltaTime), Speed / 2 * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow)) // up
        {
            transform.position += new Vector3(0f, Speed * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) // right
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) // down
        {
            transform.position += new Vector3(0f, -(Speed * Time.deltaTime), 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) // left
        {
            transform.position += new Vector3(-(Speed * Time.deltaTime), 0f, 0f);
        }
    }
}
