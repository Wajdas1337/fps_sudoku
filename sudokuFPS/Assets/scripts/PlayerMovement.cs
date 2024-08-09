using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    private CharacterController _ruch;
    void Start()
    {
        _ruch = transform.GetComponent<CharacterController>();
    }


    void Update()
    {
        _ruch.Move((transform.forward*Input.GetAxis("Vertical")+ transform.right *Input.GetAxis("Horizontal")) * movementSpeed); 
    }
}
