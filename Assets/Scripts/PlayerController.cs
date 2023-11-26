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
