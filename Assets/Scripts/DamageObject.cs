using UnityEngine;

public class DamageObject : MonoBehaviour
{
    [Header("Configuración de Daño")]
    [SerializeField] private int damageAmount = 10;   // Cantidad de daño
    [SerializeField] private LayerMask targetLayer;   // Capa de objetos afectados

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto colisionado está en la capa objetivo
        if (((1 << collision.gameObject.layer) & targetLayer) != 0)
        {
            ApplyDamage(collision.gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el objeto colisionado está en la capa objetivo
        if (((1 << collision.gameObject.layer) & targetLayer) != 0)
        {
            ApplyDamage(collision.gameObject);
        }
    }

    void ApplyDamage(GameObject target)
    {
        HealthSystem healthSystem = target.GetComponent<HealthSystem>();
        
        if(healthSystem != null)
        {
            healthSystem.TakeDamage(damageAmount);
            
        }
    }
}