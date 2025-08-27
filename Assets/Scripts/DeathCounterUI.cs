using UnityEngine;
using TMPro;

public class DeathCounterUI : MonoBehaviour
{
    [SerializeField] private DeathCounter deathCounter;
    [SerializeField] private TMP_Text deathCountText;

    private void Update()
    {
       
        deathCountText.text = deathCounter.DeathCount.ToString();
    }

    
}