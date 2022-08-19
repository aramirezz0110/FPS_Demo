using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorStateHandler : MonoBehaviour
{
    [SerializeField] private bool isCursorLocked=true;

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            ChangeCursorState();
    }
    private void ChangeCursorState()
    {
        isCursorLocked = !isCursorLocked;
        if (isCursorLocked)
            Cursor.lockState = CursorLockMode.Locked;
        else
            Cursor.lockState = CursorLockMode.None;
    }
}
