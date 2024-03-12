using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStingers : MonoBehaviour
{
    [SerializeField] private AK.Wwise.Event MoveLeft;
    [SerializeField] private AK.Wwise.Event MoveRight;
    [SerializeField] private AK.Wwise.Event Rotate;
    [SerializeField] private AK.Wwise.Event HardDrop;

    // Update is called once per frame
    void Update()
    {
        // Handle rotation
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
        {
            Rotate.Post(gameObject);
        }

        //Handle hard drop
        if (Input.GetKeyDown(KeyCode.Space))
        {
           HardDrop.Post(gameObject);
        }

        /*
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
        }
        */

        // Left/right movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft.Post(gameObject);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight.Post(gameObject);
        }


    }
}
