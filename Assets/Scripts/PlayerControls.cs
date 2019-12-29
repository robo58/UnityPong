using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
  public KeyCode moveUp;
  public KeyCode moveDown;  

  Rigidbody2D rb;
  public float speed = 10f;

   void Start() {
       rb =GetComponent<Rigidbody2D>();
   }

  // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(moveUp))
        {
            rb.velocity= new Vector2(0,speed);
        }
        else if(Input.GetKey(moveDown))
        {
           rb.velocity = new Vector2(0,-speed);
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}
