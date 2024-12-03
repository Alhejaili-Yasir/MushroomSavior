using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // æÇÌåÉ ÒÑ ÇáÅíŞÇİ ÇáãÄŞÊ

    private bool isPaused = false;

    void Update()
    {
        // ÊÍŞŞ ãä ÇáÖÛØ Úáì ãİÊÇÍ ÇáÅíŞÇİ (Escape)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    // ÇÓÊÆäÇİ ÇááÚÈÉ
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // ÅÎİÇÁ ŞÇÆãÉ ÇáÅíŞÇİ
        Time.timeScale = 1f;          // ÇÓÊÆäÇİ ÇáæŞÊ
        isPaused = false;
    }

    // ÅíŞÇİ ÇááÚÈÉ
    public void Pause()
    {
        pauseMenuUI.SetActive(true); // ÅÙåÇÑ ŞÇÆãÉ ÇáÅíŞÇİ
        Time.timeScale = 0f;         // ÅíŞÇİ ÇáæŞÊ
        isPaused = true;
    }

    // ÒÑ ÇáÎÑæÌ
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit(); // íÚãá İŞØ ÚäÏ ÈäÇÁ ÇááÚÈÉ
    }
}
