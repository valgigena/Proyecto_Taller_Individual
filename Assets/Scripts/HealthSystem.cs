using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;


public class HealthSystem : MonoBehaviour
{
    public int health = 100;       // Salud pública (ajustable desde el Inspector)
    public int maxHealth = 100;
    public Transform respawnPoint;
    public Slider barraVida; 
    public TMP_Text textObject;

    [SerializeField] DeathCounter deathCounter;


    void Update()
    {
        //UI
        barraVida.value = health;
        textObject.text = health.ToString();

        //Respawn
        if (health == 0)
        {
            Respawn();
            deathCounter.IncrementDeathCount();
        }

    }

    // Método básico para recibir daño
    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, health); // Evita valores negativos
    }

    public void Respawn()
    {
        transform.position = respawnPoint.position;
        health = maxHealth;
        //AudioManager.instance.PlaySFX(AudioManager.instance.robotClip);
    }


}