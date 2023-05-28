using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject playerObject;

    Rigidbody2D playerRigidBody;
    Transform playerTransform;
    BoxCollider2D boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        boxCollider2D = this.gameObject.GetComponent<BoxCollider2D>();
        playerTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        handlePlayerMovement();
    }
    
    public void handlePlayerMovement() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x,10);
            }
        if (Input.GetKey(KeyCode.A)) {
            playerRigidBody.AddForce(Vector2.left);
        }
         if (Input.GetKey(KeyCode.D)) {
            playerRigidBody.AddForce(Vector2.right);
         }
    }

}
