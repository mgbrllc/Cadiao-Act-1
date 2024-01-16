using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraManager : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public float smoothSpeed;
    public GameManager gameManager;
    public bool startCamera;
    public Transform startCameraPos;

    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


        targetPosition = startCameraPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.defaultCamera == true)
        {
            targetPosition = target1.position;     
        }

        else if (gameManager.faceButtonPressed == true)
        {
            targetPosition = target3.position;
        }
        else if (gameManager.bodyButtonPressed == true)
        {
            targetPosition = target4.position;
        }
        else if (gameManager.pantsButtonPressed == true)
        {
            targetPosition = target5.position;
        }
        


       

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;
        








    }
}
