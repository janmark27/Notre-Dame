using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extinguishFire : MonoBehaviour
{

    checkWin addFireCounter;
    [SerializeField]
    private Transform[] fires;

    public float x = 1.0f;
    public float y = 1.0f;
    public float z = 1.0f;

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
    void DestroyScriptInstance()
    {
        Destroy(this);
    }
    private void OnMouseDown()
    {
        x -= 0.2f;
        y -= 0.2f;
        z -= 0.2f;
        transform.localScale = new Vector3(x, y, z);

        if (transform.localScale.x < 0.1)
        {
            addFireCounter = FindObjectOfType<checkWin>();
            addFireCounter.fireCounter += 1.0f;
            DestroyGameObject();
            DestroyScriptInstance();
        }
    }
}
