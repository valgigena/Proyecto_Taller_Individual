using UnityEngine;

public class ReferenciaExterna : MonoBehaviour
{

    public HealthSystem referencia; // primero el nombre del Script luego donde se aloja, arrastrar aca el objeto que l ocntenga

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Debug.Log("Referencia Externa: " + referencia.health); //primero donde esta alojado el 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
