using TMPro.EditorUtilities;
using UnityEngine;

public class MünzenManager : MonoBehaviour
{
    [SerializeField] private int MünzenZähler = 0;
    [SerializeField] private UIManager uiManager;
    private void Start()
    {
        MünzenZähler = 0;
        uiManager.UpdateCoinText(MünzenZähler);
    }
    public void AddMünze()
    {
        MünzenZähler++;
        uiManager.UpdateCoinText(MünzenZähler);
    }
}
