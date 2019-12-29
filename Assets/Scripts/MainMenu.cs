using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void vsAI(){
        SceneManager.LoadScene(2);

    }
      public void PvP(){
        SceneManager.LoadScene(1);

    }
    public void QuitGame(){
       Application.Quit();
    }
}
