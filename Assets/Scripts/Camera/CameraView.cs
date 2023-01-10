using UnityEngine;

public class CameraView : MonoBehaviour
{
    public float speed = 3.5f;
    private float X;
    private float Y;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Cursor.lockState = CursorLockMode.Locked;

            X += speed * Input.GetAxis("Mouse Y");
            Y -= speed * Input.GetAxis("Mouse X");

            X = Mathf.Clamp(X, 5f, 90f);

            transform.eulerAngles = new Vector3(X, Y, 0f);
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}