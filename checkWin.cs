using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkWin : MonoBehaviour
{
    [SerializeField]
    private GameObject winPanel, winSound;

    public float fireCounter;
    void Start()
    {
        fireCounter = 0;
        winPanel.SetActive(false);
    }

    void Update()
    {
        if(fireCounter == 8)
        {
            winPanel.SetActive(true);
	    winSound.SetActive(true);
        }
    }
}
