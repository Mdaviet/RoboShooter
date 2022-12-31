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

        killsText.text = "Kills: " + kills.ToString();
    }
}
