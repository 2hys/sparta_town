using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    /*
    //디렉션은 플레이어인풋컨트롤에서 가져옴.
    public delegate void OnMoveDel(Vector2 direction);
    public OnMoveDel OnMoveEvent;

    public delegate void OnLookDel(Vector2 direction);
    public OnLookDel OnLookEvent;
    */
    //위랑 같음 event는 이 코드 내에서만 쓰게만듬
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
