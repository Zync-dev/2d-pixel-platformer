using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
  //Be sure to assign this a value in the designer.
 public Text ScoreText;

 private float timer;
 private float score;

 void Update () {

    timer += Time.deltaTime;

    if (timer > 5f) {

        score += 5;

        //We only need to update the text if the score changed.
        ScoreText.text = score.ToString();

        //Reset the timer to 0.
        timer = 0;
    }
  }
}