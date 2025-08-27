using UnityEngine;
using TMPro;

public class PointCounterUI : MonoBehaviour
{

    [SerializeField] private PointsCounter pointsCounter;

    [SerializeField] private TMP_Text pointCountText;


    // Update is called once per frame
    void Update()
    {
        pointCountText.text = pointsCounter.PointsCount.ToString();
    }
}
