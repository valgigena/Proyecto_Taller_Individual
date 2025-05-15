using TMPro;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;       // Salud pública (ajustable desde el Inspector)
    public TMP_Text healthText;    // Referencia al texto

    void Update()
    {
        // Actualiza el texto cada frame
        healthText.text = "Vida: " + health.ToString();
    }

    // Método básico para recibir daño
    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, 100); // Evita valores negativos
    }
}