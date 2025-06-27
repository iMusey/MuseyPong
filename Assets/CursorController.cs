using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CursorController : MonoBehaviour
{
    public GameObject cursor;
    public float speed = 1000f;

    private Vector2 moveInput;
    private RectTransform canvasRect;

    private void Awake()
    {
        canvasRect = FindObjectOfType<Canvas>().GetComponent<RectTransform>();
    }

    public void OnNavigate(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnYes(InputAction.CallbackContext context)
    {
        Vector2 screenPos = cursor.transform.position;

        PointerEventData pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = screenPos;

        List<RaycastResult> results = new List<RaycastResult>();
        GraphicRaycaster raycaster = canvasRect.GetComponent<GraphicRaycaster>();
        raycaster.Raycast(pointerData, results);

        foreach (RaycastResult result in results)
        {
            ExecuteEvents.Execute(result.gameObject, pointerData, ExecuteEvents.pointerClickHandler);
        }
    }

    void Update()
    {
        Vector3 pos = cursor.transform.position;
        pos += new Vector3(moveInput.x, moveInput.y, 0) * speed * Time.deltaTime;
        pos = ClampToScreen(pos);
        cursor.transform.position = pos;
    }

    private Vector3 ClampToScreen(Vector3 pos)
    {
        pos.x = Mathf.Clamp(pos.x, 0, Screen.width);
        pos.y = Mathf.Clamp(pos.y, 0, Screen.height);
        return pos;
    }
}
