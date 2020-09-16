using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{

    void Update()
    {
          if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Transform>().position += new Vector3 (0.008f, 0f, 0f);

        }
        

        //If player press RIGHT ARROW, move slowly right
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Transform>().position += new Vector3 (-0.008f, 0f, 0f);


        }
    }
}
