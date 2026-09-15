using UnityEngine;
using UnityEngine.InputSystem;

public class ClickController : MonoBehaviour
{
    public Transform mousePos ;
    public BlueCircle blue;
    public RedCircle red;

    private void Update()
    {
        Vector2 screenMousePos = Mouse.current.position.ReadValue();

        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(screenMousePos);

        worldMousePos.z = 0f;

        mousePos.position = worldMousePos;
    }

    void OnLeftClick()
    {
        BlueCircle GO = Instantiate(blue, this.transform.position, this.transform.rotation);
    }

    void OnRightClick()
    {
        RedCircle GO = Instantiate(red, this.transform.position, this.transform.rotation);
    }

}
