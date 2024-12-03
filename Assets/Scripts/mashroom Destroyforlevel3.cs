using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MashroomCollector : MonoBehaviour
{
    public Text BlueMashroomText;
    public Text RedMashroomText;
    public Text GreenMashroomText;
    public Text SmurfText;

    public AudioSource MashroomSound;
    


    private int BlueMashroomCount = 0;
    private int RedMashroomCount = 0;
    private int GreenMashroomCount = 0;
    private int SmurfCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueMashroom"))
        {
            BlueMashroomCount++;
            BlueMashroomText.text = BlueMashroomCount.ToString() + "/4";
            Destroy(other.gameObject);
            MashroomSound.Play();
        }
        else if (other.gameObject.CompareTag("RedMashroom"))
        {
            RedMashroomCount++;
            RedMashroomText.text = RedMashroomCount.ToString() + "/6";
            Destroy(other.gameObject);
            MashroomSound.Play();
        }
        else if (other.gameObject.CompareTag("GreenMashroom"))
        {
            GreenMashroomCount++;
            GreenMashroomText.text = GreenMashroomCount.ToString() + "/6";

            Destroy(other.gameObject);
            MashroomSound.Play();
        }
        else if (other.gameObject.CompareTag("Smurf"))
        {
            SmurfCount++;
            SmurfText.text = SmurfCount.ToString() + "/4";

            Destroy(other.gameObject);
            MashroomSound.Play();
        }
        else if (other.gameObject.CompareTag("Lose"))
        {
            SceneManager.LoadScene("NewLose");
        }
        CheckMashroomCollection();
    }

    private void CheckMashroomCollection()
    {
        if (GreenMashroomCount == 6 && RedMashroomCount == 6 && BlueMashroomCount == 4)
        {
            SceneManager.LoadScene("NewWin");
        }

        if (GreenMashroomCount == 6 && RedMashroomCount == 6 && BlueMashroomCount == 4 && SmurfCount == 4)
        {
            SceneManager.LoadScene("Win2");
        }
    }
}
