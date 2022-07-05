using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Action<Vector2> OnTap;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleTapInput(Input.mousePosition);
        }
    }

    private void HandleTapInput(Vector2 position)
    {
        OnTap?.Invoke(position);
    }
}
