using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIscript : MonoBehaviour
{
public GameObject ball;
public float speed=10f;
float easy=0.2f;
float medium=0.35f;
float hard=0.5f;
void Update () 
{
//Moves the player
float difficulty;
int gameDiff=GameManager.PlayerScore1-GameManager.PlayerScore2;
    if(gameDiff<=2){
        difficulty=easy;
        if (ball.transform.position.y > transform.position.y)
                //transform.Translate(new Vector3(0,speed,0) * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity=(new Vector2(0f,speed*difficulty));
                
        if (ball.transform.position.y < transform.position.y)
                //transform.Translate(new Vector3(0,-speed,0) * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity=(new Vector2(0f,-speed*difficulty));
}else if(gameDiff>2&&gameDiff<=5){
        difficulty=medium;
        if (ball.transform.position.y > transform.position.y)
                //transform.Translate(new Vector3(0,speed,0) * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity=(new Vector2(0f,speed*difficulty));
                
        if (ball.transform.position.y < transform.position.y)
                //transform.Translate(new Vector3(0,-speed,0) * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity=(new Vector2(0f,-speed*difficulty));
}else if(gameDiff>5){
        difficulty=hard;
        if (ball.transform.position.y > transform.position.y)
                //transform.Translate(new Vector3(0,speed,0) * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity=(new Vector2(0f,speed*difficulty));
                
        if (ball.transform.position.y < transform.position.y)
                //transform.Translate(new Vector3(0,-speed,0) * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity=(new Vector2(0f,-speed*difficulty));
}
}
}