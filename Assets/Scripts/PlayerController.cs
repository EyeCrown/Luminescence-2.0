using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /*
     * --- Attributes ----------------------------------------------
     * Public attributes
     */



    /*
     * Private attributes
     */
    // Components
    private Rigidbody rb;


    [SerializeField] private GameObject leftWheel;
    [SerializeField] private GameObject rightWheel;
     
    // Variables
    [SerializeField] private float speedMovement;

    private Vector2 inputMovement;


    /*
     * ---- Methods ------------------------------------------------
     */

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //DoMovements();
        Debug.Log(inputMovement);
        leftWheel.transform.Rotate(Vector3.right, inputMovement.y * speedMovement);
        rightWheel.transform.Rotate(Vector3.right, inputMovement.y * speedMovement);
    }

    void DoMovements()
    {
        leftWheel.transform.Rotate(Vector3.right, inputMovement.y);
        rightWheel.transform.Rotate(Vector3.right, inputMovement.y);
    }

    /// <summary>
    /// //TODO
    /// </summary>
    /// <param name="context"></param>
    public void Move(InputAction.CallbackContext context)
    {
        inputMovement = context.ReadValue<Vector2>();
    }

    public void Look(InputAction.CallbackContext context)
    {

    }

    public void Interact(InputAction.CallbackContext context)
    {

    }
}
