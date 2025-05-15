using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RestartButton : MonoBehaviour
{
  
  public Text scoreText;

  void Start(){

    scoreText.text = "Your Score\n " + PlayerPrefs.GetFloat("Minutes") + " Min. "+
    PlayerPrefs.GetFloat("Seconds")+" Sec.";
  }

    public void GoToMenu(){

       
        SceneManager.LoadScene("StartMenu");
        
   }

}
