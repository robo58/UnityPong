using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBottomWall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.collider.tag == "Ball")
        {
          GetComponent<AudioSource>().pitch = Random.Range(0.5f,1.5f);
          GetComponent<AudioSource>().Play();
        }
    }
}
