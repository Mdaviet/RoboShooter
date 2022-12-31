using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI killsText;
    public TextMeshProUGUI timeText;

    public void Setup(int kills, float timeSurvived)
    {
        gameObject.SetActive(true);
        int minutesSurvived = (int)timeSurvived / 60;
        int secondsSurvived = (int)timeSurvived % 60;

        killsText.text = "Kills: " + kills.ToString();
        timeText.text = "Time Survived: " 
                        + minutesSurvived.ToString() + ":" 
                        + secondsSurvived.ToString("D2");
    }
}
