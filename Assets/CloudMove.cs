using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If player press LEFT ARROW, move slowly left
        if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Transform>().position += new Vector3 (-0.001f, 0f, 0f);

        }
        

        //If player press RIGHT ARROW, move slowly right
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Transform>().position += new Vector3 (0.001f, 0f, 0f);


        }
    }
}
