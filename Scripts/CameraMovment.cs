using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private float _normalSpeed;
    [SerializeField] private float _fastSpeed;
 
    void Update()
    {
        ChekInsideBoundary();         

        MoveCamera();          
    }

    private void MoveCamera()
    {
        float moveSpeed = Input.GetKey(KeyCode.LeftShift) ? _fastSpeed : _normalSpeed;

        if (Input.GetKey(KeyCode.A))
            gameObject.transform.position += new Vector3(-moveSpeed, 0, 0);
        else if (Input.GetKey(KeyCode.D))
            gameObject.transform.position += new Vector3(moveSpeed, 0, 0);

        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += new Vector3(0, 0, moveSpeed);
        else if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += new Vector3(0, 0, -moveSpeed);
    }
    private void ChekInsideBoundary()
    {
        if (transform.position.x > 700 || transform.position.z > 700)
            transform.position += new Vector3(-1, 0, -1);

        if (transform.position.z < 40 || transform.position.x < 40)
            transform.position += new Vector3(1, 0, 1);
    }
}
