using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageOnOff : MonoBehaviour
{
    public GameObject marker1;
    public GameObject marker2;
    public GameObject image;

    // Update is called once per frame
    void Update()
    {
        MeshRenderer marker1_meshRenderer = marker1.GetComponent<MeshRenderer>();
        MeshRenderer marker2_meshRenderer = marker2.GetComponent<MeshRenderer>();
        Image imageComponent = image.GetComponent<Image>();

        if (marker1_meshRenderer.isVisible && marker2_meshRenderer.isVisible)
        {
            imageComponent.enabled = true;
        }
        else
        {
            imageComponent.enabled = false;

        }
    }
}
