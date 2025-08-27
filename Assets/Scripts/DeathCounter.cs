using UnityEngine;

[CreateAssetMenu(fileName = "DeathCounter", menuName = "Game/Death Counter")]
public class DeathCounter : ScriptableObject
{
    [SerializeField] private int deathCount = 0;

    public int DeathCount => deathCount;

    public void IncrementDeathCount()
    {
        deathCount++;
    }
    
        private void OnEnable()
    {
        //Siempre reinicia al cargarse
        deathCount = 0;
    }
    

}