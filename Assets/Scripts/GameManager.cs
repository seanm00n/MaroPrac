using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //public GameObject timeUI;
    public Text timeText;

    public GameObject restartUI;
    private Text bestText;
    float time = 0;
    float bestTime = 0;
    bool isGAOV = false;
    struct CHARACTER
    {
        public int hp;
    }
    
    void Start()
    {
        bestText = restartUI.transform.GetChild(0).gameObject.GetComponent<Text>();
    }

    void Update()
    {
        checkGAOV();
    }
    public void GameOver()
    {
        isGAOV = true;
        restartUI.SetActive(true);
        

        bestTime = PlayerPrefs.GetFloat("BestTime");//return float
        if(time > bestTime)
        {
            bestTime = time;
        }
        PlayerPrefs.SetFloat("BestTime", bestTime);
        bestText.text = "BestTime : " + string.Format("{0:.##}", bestTime);

    }
    void checkGAOV()
    {
        if (!isGAOV)
        {
            time += Time.deltaTime;
            timeText.text = "Time : " + (int)time;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}