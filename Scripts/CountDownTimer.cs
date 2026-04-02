using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime; //Set the total time for the countdown
    public Text timerText;

    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime; // Subtract elapsed time every frame
            float minutes = Mathf.FloorToInt(totalTime / 60); // Divide the time by 60
            float seconds = Mathf.FloorToInt(totalTime % 60); // Returns the remainder
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Set the text string
        }
        else
        {
            timerText.text = "00:00";
            totalTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //this will later be set to exit the level and go back to level select scene
        }
    }
}
