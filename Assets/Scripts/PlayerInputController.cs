using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 NewAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(NewAim);//Camera.main�� ����ī�޶� �ٷ�ȣ�� ����

        NewAim = (worldPos - (Vector2)transform.position);//���⸸

        CallLookEvent(NewAim);
    }
}
