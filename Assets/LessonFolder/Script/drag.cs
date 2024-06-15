using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

    Vector2 difference = Vector2.zero;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    // Update is called once per frame
    private void OnMouseDrag()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }
}
