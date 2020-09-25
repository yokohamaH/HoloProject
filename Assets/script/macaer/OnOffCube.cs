using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffCube : MonoBehaviour
{
    public GameObject marker1;
    public GameObject marker2;
    public GameObject cube;

    // Update is called once per frame
    void Update()
    {
        MeshRenderer marker1_meshRenderer = marker1.GetComponent<MeshRenderer>();
        MeshRenderer marker2_meshRenderer = marker2.GetComponent<MeshRenderer>();
        MeshRenderer cube_meshRenderer = cube.GetComponent<MeshRenderer>();

        if (marker1_meshRenderer.isVisible && marker2_meshRenderer.isVisible)
        {
            cube_meshRenderer.enabled = true;
        }
        else
        {
            cube_meshRenderer.enabled = false;

        }
    }
}
