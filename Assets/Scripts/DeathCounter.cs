using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "DeathCounter", menuName = "Game/Death Counter")]
public class DeathCounter : ScriptableObject
{
    [SerializeField] private int deathCount = 0;
    [SerializeField] private bool resetOnGameStart = true;
    
    // Evento para notificar cambios
    public System.Action<int> OnDeathCountChanged;
    
    public int DeathCount => deathCount;

    private void OnEnable()
    {
        // Este método se llama cuando el ScriptableObject se carga en memoria
        if (resetOnGameStart && Application.isPlaying)
        {
            ResetDeathCount();
        }
    }

    public void IncrementDeathCount()
    {
        deathCount++;
        Debug.Log($"Muertes totales: {deathCount}");
        OnDeathCountChanged?.Invoke(deathCount);
    }
    
    public void ResetDeathCount()
    {
        deathCount = 0;
        OnDeathCountChanged?.Invoke(deathCount);
    }
}