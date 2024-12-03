using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60; 
    public Text timerText;
    public AudioSource TimeIncrease;
    public AudioSource TimeDecrease;
    private bool timerRunning = true;

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                TimerEnded();
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        Debug.Log("Timer has ended!");
        SceneManager.LoadScene("NewLose"); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("timeincrease"))
        {
            timeRemaining += 10;
            Destroy(other.gameObject);
            TimeIncrease.Play();

        }
        else if (other.CompareTag("Enemy"))
        {
                       timeRemaining -= 10;
                       TimeDecrease.Play();
           }
    }
}
