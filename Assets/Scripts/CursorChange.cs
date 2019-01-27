using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChange : MonoBehaviour
{
    [SerializeField]
    private Texture2D _hoverCursor, _default;

    private void OnMouseEnter() {
        Cursor.SetCursor(_hoverCursor, new Vector2(.5f, .5f), CursorMode.Auto);
    }
    
    private void OnMouseExit() =>
        Cursor.SetCursor(_default, new Vector2(.5f, .5f), CursorMode.Auto);
}
