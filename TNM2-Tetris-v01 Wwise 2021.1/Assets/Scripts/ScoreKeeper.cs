using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;

    public Text linesClearedText;
    public int linesCleared = 0;
    public int linesToWin;
    public Text youWonText;
    [SerializeField] private AK.Wwise.RTPC linesRTPC;
    [SerializeField] private AK.Wwise.Event lineClearEvent;
    public GameObject theBoard;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {      
        linesClearedText.text = linesCleared.ToString();
        youWonText.enabled = false;
    }

    public void addToScore()
    {
        linesCleared += 1;
        linesClearedText.text = linesCleared.ToString();
        lineClearEvent.Post(gameObject);
        linesRTPC.SetGlobalValue(linesCleared);

        if (linesCleared == linesToWin)
        {
            GameWon();
        }

    }

    public void ResetScore()
    {
        linesCleared = 0;
        linesClearedText.text = linesCleared.ToString();
    }

    public void GameWon()
    {
        youWonText.enabled = true;
        theBoard.SetActive(false);

    }

}
