using UnityEngine;

[CreateAssetMenu(fileName = "DeathCounter", menuName = "Game/Death Counter")]
public class DeathCounter : ScriptableObject
{
    [SerializeField] private int deathCount = 0;
    
    public int DeathCount => deathCount;

    private void OnEnable()
    {
        // Siempre reinicia al cargarse
        ResetDeathCount();
    }

    public void IncrementDeathCount()
    {
        deathCount++;
    }
    
    public void ResetDeathCount()
    {
        deathCount = 0;
    }
}