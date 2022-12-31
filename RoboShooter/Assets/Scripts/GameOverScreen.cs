using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI killsText;
    public TextMeshProUGUI timeText;

    public void Setup(int kills, int minutesSurvived, int secondsSurvived)
    {
        gameObject.SetActive(true);

        killsText.text = "Kills: " + kills.ToString();
        timeText.text = "Time Survived: " 
                        + minutesSurvived.ToString() + ":" 
                        + secondsSurvived.ToString("D2");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }
}
