using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScreen : MonoBehaviour
{
    public TextMeshProUGUI levelText;

    int level;

    GameManager gameManagerScript;

    private void Awake() 
    {
        GameObject gameManager = GameObject.Find("Game Manager");
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        level = gameManagerScript.currentLevel + 1;
        levelText.text = "Level: " + (level).ToString();
    }
}
