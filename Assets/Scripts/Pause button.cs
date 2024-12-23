using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // ����� �� ������� ������

    private bool isPaused = false;

    void Update()
    {
        // ���� �� ����� ��� ����� ������� (Escape)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    // ������� ������
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // ����� ����� �������
        Time.timeScale = 1f;          // ������� �����
        isPaused = false;
    }

    // ����� ������
    public void Pause()
    {
        pauseMenuUI.SetActive(true); // ����� ����� �������
        Time.timeScale = 0f;         // ����� �����
        isPaused = true;
    }

    // �� ������
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit(); // ���� ��� ��� ���� ������
    }
}
