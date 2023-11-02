using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



public class InputPaddle : MonoBehaviour
{
    // variables
    public float speed = 5f;
    //used to identify left or right
    public string leftOrRight;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
       
        //Controls both paddles
    {
        // Left Paddle

        
        // sees if pos= left/right
        if (leftOrRight == "Left")
        {
           //gets input
            if (Input.GetKey(KeyCode.W))
            {
                //transforms speed/position when the key W gets pressed
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("yes W is pressed down");
            }
            // the same as the one above only diff is that its checking key S
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("yes S is pressed down"); // debuglogs for checking if it worked correct
            }
        }
        //Right paddle
        // realy just the same as above only for the right player and using arrow keys input
        else if (leftOrRight == "Right")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("yes UpArrow is pressed down");
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("yes DownArrow is pressed down");
            }
        }
    }
}