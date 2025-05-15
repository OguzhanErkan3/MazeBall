 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class Timer : MonoBehaviour {
 
      public Text timer;
     public float highscore = 00;
     public float seconds = 00;
     public float miliseconds = 00;
     public float minutes = 00;
     public float saat=00;
     public Canvas canvas;

    
 
     void FixedUpdate(){
         if (miliseconds >= 60) {
             seconds++;
             miliseconds = 00;
         }    
 
         if (seconds >=60) {
             minutes++;
             seconds = 00;
         }
         if(minutes>=60){
            saat++;
            minutes=00;
         }   

 
             miliseconds += Time.deltaTime * 60;
         timer.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
         PlayerPrefs.SetFloat("Minutes", minutes);
        PlayerPrefs.SetFloat("Seconds", seconds);
        
     }
 }