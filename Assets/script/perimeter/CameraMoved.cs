using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoved : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float key = 0.0f;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1.0f;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1.0f;

        Vector3 tf_Rotate = new Vector3(0.0f, key, 0.0f);
        this.GetComponent<Transform>().Rotate(tf_Rotate);

    }
}
