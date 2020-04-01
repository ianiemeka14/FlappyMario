using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
    public static bool panelOpen;
    public GameObject panelBoxUI;
   
    public void Open()
    {
        panelBoxUI.SetActive(true);
    }

    public void Close()
    {
        panelBoxUI.SetActive(false);
    }
}
