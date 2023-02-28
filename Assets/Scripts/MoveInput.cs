using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveInput : MonoBehaviour
{
    PlayerInputAction playerInputAction;
    private void Awake()
    {
        playerInputAction = new PlayerInputAction();
        playerInputAction.Enable();
    }
    public Vector2 GetMoveInputDirection()
    {
        Vector2 inputVector = playerInputAction.Player.Move.ReadValue<Vector2>();
        //if (Input.GetKey(KeyCode.W))
        //{
        //    inputVector.y += 1;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    inputVector.y -= 1;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    inputVector.x -= 1;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    inputVector.x += 1;
        //}
        //inputVector = inputVector.normalized;
      
        return inputVector;
    }
}
