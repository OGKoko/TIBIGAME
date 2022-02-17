using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private GameObject settingPanel;
    private GameObject player;


    private void Awake()
    {
        settingPanel = GameObject.FindGameObjectWithTag(GLOBALS.SETTINGS_PANEL);
        player = GameObject.FindGameObjectWithTag(GLOBALS.PLAYER);
    }
    void Start()
    {
        settingPanel.SetActive(false);
    }


    public void SettingPanelSwitch()
    {
        settingPanel.SetActive(true);
        if (settingPanel.activeSelf == true)
        {
            player.GetComponent<PlayerInput>().InputEnabler = false;
            player.GetComponent<PlayerController>().DestinationPoint = player.transform.position;
        }
        else if (settingPanel.activeSelf == false)
        {
            player.GetComponent<PlayerInput>().InputEnabler = true;

        }

    }



}
