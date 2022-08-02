using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Transform _transform;
    [SerializeField] private float scale;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = scale * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _transform.position -= new Vector3(0, 0, x);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _transform.forward += new Vector3(0, 0, x);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _transform.position += new Vector3(x, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _transform.position -= new Vector3(x, 0, 0);
        }
    }
}