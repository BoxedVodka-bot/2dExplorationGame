using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        float facedirection = Input.GetAxisRaw("Horizontal");
        //If player press LEFT ARROW, go left
        if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Transform>().position += new Vector3 (-0.05f, 0f, 0f);
            anim.SetFloat("Moving", Mathf.Abs(facedirection));
        }
        
        //If player press RIGHT ARROW, go right
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Transform>().position += new Vector3 (0.05f, 0f, 0f);
            anim.SetFloat("Moving", Mathf.Abs(facedirection));
        }
        //If player press UP ARRPW, go up
        if(Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Transform>().position += new Vector3 (0f, 0.05f, 0f);
            anim.SetFloat("Moving", Mathf.Abs(facedirection)); 
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Transform>().position += new Vector3 (0f, -0.05f, 0f);
            anim.SetFloat("Moving", Mathf.Abs(facedirection));        
        }

        if(facedirection !=0){
            transform.localScale = new Vector3(facedirection, 1, 1);
        }
    }
}
