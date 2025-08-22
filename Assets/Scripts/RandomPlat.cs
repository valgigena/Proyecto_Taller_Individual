using UnityEngine;
using UnityEngine.Rendering;

public class randomPlat : MonoBehaviour
{

    public GameObject plats;
    public GameObject plats2;
    [SerializeReference] float time;
    [SerializeReference] float Xmin;
    [SerializeReference] float Xmax;
    [SerializeReference] float Ymin;
    [SerializeReference] float Ymax;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPlats", 0f, time);
        
    }

    void SpawnPlats()
    {
        Vector3 randomPos = new Vector3(Random.Range(Xmin, Xmax), Random.Range(Ymin, Ymax), 0);
        GameObject newPlats = Instantiate(plats, randomPos, Quaternion.identity);
        Destroy(newPlats, time);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
