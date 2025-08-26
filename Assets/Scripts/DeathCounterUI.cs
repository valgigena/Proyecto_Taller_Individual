using UnityEngine;
using TMPro;

public class DeathCounterUI : MonoBehaviour
{
    [SerializeField] private DeathCounter deathCounter;
    [SerializeField] private TMP_Text deathCountText;

    private int lastKnownCount = -1;

    private void Update()
    {
        if (deathCounter != null && deathCountText != null)
        {
            // Solo actualizar si el valor ha cambiado
            if (deathCounter.DeathCount != lastKnownCount)
            {
                deathCountText.text = deathCounter.DeathCount.ToString();
                lastKnownCount = deathCounter.DeathCount;
            }
        }
    }

    private void Start()
    {
        // Inicializar el texto
        if (deathCounter != null && deathCountText != null)
        {
            deathCountText.text = deathCounter.DeathCount.ToString();
            lastKnownCount = deathCounter.DeathCount;
        }
    }
}