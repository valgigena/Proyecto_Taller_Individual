using UnityEngine;
[CreateAssetMenu(fileName = "PointsCounter", menuName = "Game/Points Counter")]


public class PointsCounter : ScriptableObject
{
    [SerializeField] public int pointsCount = 0;

    public int PointsCount => pointsCount;

    public void IncrementPointCount()
    {
        pointsCount++;
    }
    
        private void OnEnable()
    {
        //Siempre reinicia al cargarse
        pointsCount = 0;
    }

}
