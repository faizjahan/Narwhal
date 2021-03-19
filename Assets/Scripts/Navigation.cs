using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    
    [SerializeField] GameObject[] panels;

    private void selectPanel(GameObject selected)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        selected.SetActive(true);
    }

    private void Start()
    {
        selectPanel(panels[4]);
    }

    public void BarClick(GameObject activePanel)
    {
        selectPanel(activePanel);
    }
    
}
