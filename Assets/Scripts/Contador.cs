using UnityEngine;

public class Contador : MonoBehaviour
{

    public int numeroDeEnemigos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Contar objetos con el tag "Enemy" y asignar el resultado a la variable pública
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");
        numeroDeEnemigos = enemigos.Length;
    }
}
