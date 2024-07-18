using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;


    // private variables
    private float speed =  15.0f;
    private float trunSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
        // This is where we get the player  input 
    
        horizontalInput = Input.GetAxis("Horizontal"+ inputID );
        verticalInput = Input.GetAxis("Vertical"+ inputID);
        // Move the vehicle forward
        transform.Translate(Vector3.forward *Time.deltaTime * speed * verticalInput);
        // rotate the vechicle 
        transform.Rotate(Vector3.up, Time.deltaTime  * trunSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
}

    }
}
