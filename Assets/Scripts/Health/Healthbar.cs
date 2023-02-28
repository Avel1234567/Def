using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    public void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
    public void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
}