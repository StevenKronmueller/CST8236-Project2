using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour
{

    public Material[] textures;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        MeshRenderer renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            renderer.material = textures[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            renderer.material = textures[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            renderer.material = textures[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            renderer.material = textures[3];
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            renderer.material = textures[4];
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            renderer.material = textures[5];
        }

    }
}
