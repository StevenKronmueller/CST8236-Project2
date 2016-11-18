using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera changeCamera = GetComponent<Camera>();

            changeCamera.orthographic = !changeCamera.orthographic;
        }
    }
}
