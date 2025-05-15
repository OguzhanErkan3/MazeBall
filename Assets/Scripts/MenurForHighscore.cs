using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenurForHighscore : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()

    {


        scoreText.text = "Best Time\n " + PlayerPrefs.GetFloat("Min") + "."+
    PlayerPrefs.GetFloat("Sec")+"";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
