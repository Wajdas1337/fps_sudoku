using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class PlayerMouseLook : MonoBehaviour
{
    [SerializeField] Transform _PlayerCamera;
    public float MouseSensitivity = 1000f;
    private float _xRotation = 0f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime);
        _xRotation = Mathf.Clamp(_xRotation - (Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime), -90f, 90f);
        _PlayerCamera.localRotation = Quaternion.Euler(_xRotation,0,0);
    }
}
