using UnityEngine;
using System.Collections;


public class cameraMovement : MonoBehaviour
{
    Vector3 camPerspective = new Vector3(255, 255, 255);
    public float camSensibility = 0.3f;
    public float camSpeed = 10.0f;
    public bool camActive = true;
    public Canvas myCanvas;
    int key = 1;
    
Vector3 getKeyInput()
    {
        Vector3 camVelocity = new Vector3();
        
        if (Input.GetKey(KeyCode.W))
        {
            camVelocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            camVelocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            camVelocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            camVelocity += new Vector3(1, 0, 0);
        }
        return camVelocity;
    }
    
    void cameraPerspective()
    {
        Vector3 cam = getKeyInput();
        cam *= camSpeed;
        cam *= Time.deltaTime;
        transform.Translate(cam);
        camPerspective = Input.mousePosition - camPerspective;
        camPerspective = new Vector3(camSensibility * -camPerspective.y, camSensibility * camPerspective.x, 0);
        camPerspective = new Vector3(camPerspective.x + transform.eulerAngles.x, camPerspective.y + transform.eulerAngles.y, 0);
        transform.eulerAngles = camPerspective;
        camPerspective = Input.mousePosition;
    }

    void Start()
    {
    }
    
    void Update()
    {
        switch(key)
        {
            case 1:

                if (Input.GetKey(KeyCode.Space))
                {
                    camActive = !camActive;
                }
            break;
        }

        if (camActive)
        {
            cameraPerspective();
        }
    }
}