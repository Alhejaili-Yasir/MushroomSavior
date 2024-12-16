using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    public Slider slider;
    HealthSystem healthSystem = new HealthSystem(100);

    public void Update()
    {
        slider.value = healthSystem.getHealthPercentage();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            healthSystem.Damage(10);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heal")
        {
            healthSystem.Heal(10);
        }
    }
}
