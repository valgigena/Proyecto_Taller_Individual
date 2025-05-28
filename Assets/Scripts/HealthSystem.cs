using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;       // Salud pública (ajustable desde el Inspector)
    public TMP_Text healthText;    // Referencia al texto
    public int maxHealth = 100;
    public Transform respawnPoint;



    void Update()
    {
        // Actualiza el texto cada frame
        healthText.text = "Vida: " + health.ToString();
        if (health == 0)
        {
            Respawn();
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
        AudioManager.instance.PlaySFX(AudioManager.instance.robotClip);
    }


}