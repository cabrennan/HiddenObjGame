using UnityEngine;
using TMPro;

public class SceneTimer : MonoBehaviour {
    public float seconds;
    public TextMeshProUGUI timerText;
    public float flash;


    // Use this for initialization
    void Start()
    {
        seconds = 35;
        timerText = GetComponent<TextMeshProUGUI>();
       // timerText.color = Color.green;
       // orange.r = 1f;
       // orange.g = 0.5f;
       // orange.b = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        int minutes = ((int)seconds / 60);
        int sec = (int)seconds % 60;

        timerText.text = minutes + ":";
        if (sec < 10)
        {
            timerText.text += "0";
        }
        timerText.text += sec;

        if (minutes <= 0)
        {
           // timerText.color = Color.yellow;
            if (sec <= 30)
            {
                // timerText.color = new Color32(255, 128, 0, 0); //doesn't work
               // timerText.color = orange;

                if (sec <= 10)
                {
                   // timerText.color = Color.red;
                    flash += Time.deltaTime;
                    if (flash >= 0.5)
                    {
                        GetComponent<TextMeshProUGUI>().enabled = true;
                    }
                    if (flash >= 1.0)
                    {
                        GetComponent<TextMeshProUGUI>().enabled = false;
                        flash = 0;
                    }

                    if (sec <= 0)
                    {
                        timerText.text = "GAME OVER";
                    }
                }
            }
        }

    }
}