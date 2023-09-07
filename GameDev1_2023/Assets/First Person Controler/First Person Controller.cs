using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : MonoBehaviour
{
    //player Variables
    public float speed;
    public float gravity = -9.8f;
    public float jump_force = 10f;

    private CharacterController character_controller;
    private Vector2 move_input;
    private Vector3 player_velocity;
    private bool grounded;
    private Vector2 mouse_movment;

    //camera Variables
    public Camera camera;
    public float sensitivity = 30;
    private float cam_x_rotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move_input = context.ReadValue<Vector2>();
        //Debug.Log("Move Input: " + move_input.ToString());
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        //Debug.Log("Pressed the jump key");
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        mouse_movment = context.ReadValue<Vector2>();
        //Debug.Log("Mouse Movment: " + mouse_movment.ToString());
    }
}
