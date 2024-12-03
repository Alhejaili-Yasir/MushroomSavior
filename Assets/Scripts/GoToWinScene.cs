using UnityEngine;
using UnityEngine.SceneManagement; 

public class TeleportToLevel1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
