using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirectorScript : MonoBehaviour
{
    GameObject timerText;
    float time = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("TimerText");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = "���� �ð� : " + this.time.ToString("F0") + "��";
        if (this.time < 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
