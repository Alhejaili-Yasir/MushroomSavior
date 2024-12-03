using UnityEngine;

public class Exit : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void ExitGame()
    {
        Debug.Log("Exiting game...");

        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
