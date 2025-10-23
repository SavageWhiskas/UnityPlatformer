using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingPanel;
    // Start is called before the first frame update
    void Start()
    {
        settingPanel.SetActive(false);
    }

    // Update is called once per frame
    public void OpenSettings()
    {
        settingPanel.SetActive(!settingPanel.activeSelf);
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            settingPanel.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            settingPanel.SetActive(false);
        }
    }
}
