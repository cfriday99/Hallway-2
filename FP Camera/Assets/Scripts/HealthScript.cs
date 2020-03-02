using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public GameObject loseCanvas;
    public int currentHealth;
    public Slider healthBar;

    private int startHealth;

    private void Start()
    {
        startHealth = currentHealth;
    }

    private void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(0, currentHealth - amount);
        healthBar.value = currentHealth;

        if (currentHealth == 0)
        {
            loseCanvas.SetActive(true);
        }
    }

}
