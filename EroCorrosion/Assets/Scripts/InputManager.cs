using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action<float> OnInputHorizontalAxis;
    public Action OnInputDig;
    public Action OnInputJump;

    private void Update()
    {
        OnInputHorizontalAxis.Invoke(Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Z))
        {
            OnInputDig?.Invoke();
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            OnInputJump?.Invoke();
        }
    }
}
