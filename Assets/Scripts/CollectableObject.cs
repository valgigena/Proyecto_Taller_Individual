using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    [Header("Configuración de Puntos")]
    [SerializeField] private int valorDePunto = 1;   // Cantidad de daño
    [SerializeField] private LayerMask targetLayer;   // Capa de objetos afectados
    [SerializeField] PointsCounter pointsCounter;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto colisionado está en la capa objetivo
        if (((1 << collision.gameObject.layer) & targetLayer) != 0)
        {
            ApplyPoint(collision.gameObject);
            Destroy(gameObject);
        }
    }

     void ApplyPoint(GameObject target)
    {
        pointsCounter.IncrementPointCount();        
    }

}
