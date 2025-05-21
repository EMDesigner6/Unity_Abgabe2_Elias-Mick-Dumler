using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMangerEMD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textZählerMünzen;

    [SerializeField] private GameObject panelGewonnen;
    [SerializeField] private GameObject panelVerloren;

    [SerializeField] private Button buttonNeustartLevel;


    void Start()
    {
        panelVerloren.SetActive(false); 
        panelGewonnen.SetActive(false);
        buttonNeustartLevel.onClick.AddListener(ReloadLevel);
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void UpdateCoinText(int NeuerMünzenZähler)
    {
        textZählerMünzen.text = NeuerMünzenZähler.ToString();
    }

    public void ShowPanelVerloren()
    {
        panelVerloren.SetActive(true);
        panelGewonnen.SetActive(false);
    }
    public void ShowPanelGewonnen()
    {
        panelGewonnen.SetActive(true);
        panelVerloren.SetActive(false);
    }
}
