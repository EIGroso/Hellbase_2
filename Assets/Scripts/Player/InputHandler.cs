using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 InputVector { get; private set; }

    public Vector3 MousePosition { get; private set; }
    // Update is called once per frame
    void Update()
    {
        var h = SimpleInput.GetAxis("Horizontal");
        var v = SimpleInput.GetAxis("Vertical");
        InputVector = new Vector2(h, v);

        MousePosition = Input.mousePosition;
    }
}
