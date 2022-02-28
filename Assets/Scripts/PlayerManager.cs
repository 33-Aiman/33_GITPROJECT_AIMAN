using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    //Display coin
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public static int numberOfCoins;
    public Text coinsText;


    //Display Distance

    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;


    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
    }

    void Update()
    {
        if(isGameStarted == true)
        {
            if (addingDis == false)
            {
                addingDis = true;
                StartCoroutine(AddingDis());
            }

        }
       

        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

            
        }
        coinsText.text = "Coins: " + numberOfCoins;
        if(SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "Distance: " + disRun;
        yield return new WaitForSeconds(0.25f);

        addingDis = false;
    }
}
