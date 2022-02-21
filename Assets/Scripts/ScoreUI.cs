using UnityEngine.UI;
using UnityEngine;

public class ScoreUI: MonoBehaviour
{
    [SerializeField] private Text _couterText;

    private void Update()
    {
        _couterText.text = "Score " + GameData.PointsCount;
    }
}
