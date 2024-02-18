using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playersHealth;
    public Slider playerHealthSlider;
    public Text healthText;
    void Start()
    {
        playerHealthSlider = GetComponent<Slider>();
    }
    void Update()
    {
        float deneme = (playersHealth.playerHealth / playersHealth.playerMaxhealth) *10;
        playerHealthSlider.value = (playersHealth.playerHealth / playersHealth.playerMaxhealth)*10;
    }
    public void HealthBarTextChange()
    {
       // healthText.text = playersHealth.playerHealth.ToString();
    }

    public void UpdatePlayerHealth(float currentHealthValue, float maxHealthValue)
    {
        playerHealthSlider.value = currentHealthValue / maxHealthValue;
    }
}
