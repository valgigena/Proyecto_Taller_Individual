using UnityEngine;
using TMPro;

public class DeathCounterUI : MonoBehaviour
{
    [SerializeField] private DeathCounter deathCounter;
    [SerializeField] private TMP_Text deathCountText;

    private void OnEnable()
    {
        // Suscribirse al evento cuando el objeto se habilita
        if (deathCounter != null)
        {
            deathCounter.OnDeathCountChanged += UpdateDeathCountText;
        }
    }

    private void OnDisable()
    {
        // Desuscribirse cuando el objeto se deshabilita
        if (deathCounter != null)
        {
            deathCounter.OnDeathCountChanged -= UpdateDeathCountText;
        }
    }

    private void Start()
    {
        // Actualizar el texto con el valor inicial
        if (deathCounter != null && deathCountText != null)
        {
            deathCountText.text = deathCounter.DeathCount.ToString();
        }
    }

    private void UpdateDeathCountText(int newCount)
    {
        if (deathCountText != null)
        {
            deathCountText.text = newCount.ToString();
        }
    }
}