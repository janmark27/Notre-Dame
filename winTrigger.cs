using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    [SerializeField]
    private Transform[] blocks;

    [SerializeField]
    private GameObject winText, winAudio;
    public static bool youWin;

    void Start()
    {
        winText.SetActive(false);
    }

    void Update()
    {
        if (blocks[0].position.x > 305 &&  // Bottom block 
            blocks[0].position.x < 385 &&
            blocks[0].position.y > 80  &&
            blocks[0].position.y < 110 &&

            blocks[1].position.x > 315 &&  // Lower Mid block
            blocks[1].position.x < 385 &&
            blocks[1].position.y > 20 &&
            blocks[1].position.y < 45 &&

            blocks[2].position.x > 755 &&  // Upper Mid block
            blocks[2].position.x < 795 &&
            blocks[2].position.y > 85 &&
            blocks[2].position.y < 125 &&

            blocks[3].position.x > 155 &&  // Top block
            blocks[3].position.x < 205 &&
            blocks[3].position.y > 80  &&
            blocks[3].position.y < 110   )

        {
            winText.SetActive(true);
            winAudio.SetActive(true);
        }
    }
}
