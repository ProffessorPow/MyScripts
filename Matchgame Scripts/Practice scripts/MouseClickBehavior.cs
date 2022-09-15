using System;
using UnityEngine;
using UnityEngine.Events;
public class MouseClickBehavior : MonoBehaviour
{
    public UnityEvent clickForFun;
    private void OnMouseDown()
    {
        clickForFun.Invoke();
    }
}
