using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float ballSpeed = 100;
    void Start()
    {
        Invoke("GoBall",2.0f);
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.collider.tag == "Player")
        {
          GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,GetComponent<Rigidbody2D>().velocity.y/2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y/2);
          GetComponent<AudioSource>().pitch = Random.Range(0.8f,1.2f);
          GetComponent<AudioSource>().Play();
        }
    }

    public void ResetBall()
    {
        GetComponent<Rigidbody2D>().velocity=new Vector2(0f,0f);
       GetComponent<Transform>().position=new Vector2(0f,0f);
        Invoke("GoBall",1.0f);
    }

    public void GoBall()
    {
      var randomNumber = Random.Range(0,2);
      if(randomNumber <= 0.5)
      {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed,10));
      }
      else
      {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-ballSpeed,-10));
        
      }
    }
}
