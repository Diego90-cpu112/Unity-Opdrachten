using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float _moveSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            {
                transform.position += Vector3.up * Time.deltaTime * _moveSpeed;
            }
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * _moveSpeed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * _moveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * _moveSpeed;
        }

        




    }
}
