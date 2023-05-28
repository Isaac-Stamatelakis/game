using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    Transform cameraTransform;
    Transform playerTransform;
    // Start is called before the first frame update    
    void Start()
    {
        cameraTransform = this.GetComponent<Transform>();
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        followPlayer();
    }

    private void followPlayer() {
        cameraTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z - 1);
    }
}
