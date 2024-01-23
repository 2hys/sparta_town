using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    /*
    //�𷺼��� �÷��̾���ǲ��Ʈ�ѿ��� ������.
    public delegate void OnMoveDel(Vector2 direction);
    public OnMoveDel OnMoveEvent;

    public delegate void OnLookDel(Vector2 direction);
    public OnLookDel OnLookEvent;
    */
    //���� ���� event�� �� �ڵ� �������� ���Ը���
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
