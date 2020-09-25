using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChangeScaru : MonoBehaviour
{
    public GameObject dummyCube1;
    public GameObject dummyCube2;


    void Update()
    {
        Transform iT_dummyCube1 = dummyCube1.GetComponent<Transform>();
        Transform iT_dummyCube2 = dummyCube2.GetComponent<Transform>();
        Vector3 dummyCube1_pos = iT_dummyCube1.transform.position;
        Vector3 dummyCube2_pos = iT_dummyCube2.transform.position;
        RectTransform textRect = this.GetComponent<RectTransform>();

        //this.transform.LookAt(dummyCube2_pos);


        float scale_obj_pos_x = Mathf.Abs(dummyCube1_pos.x - dummyCube2_pos.x);
        float scale_obj_pos_y = Mathf.Abs(dummyCube1_pos.y - dummyCube2_pos.y);
        float scale_obj_pos_z = Mathf.Abs(dummyCube1_pos.z - dummyCube2_pos.z);


        //Vector3 root_obj_Scale = new Vector3(scale_obj_pos_x + 1, scale_obj_pos_y + 1, 0.05f);

        //this.transform.localScale = root_obj_Scale;
        textRect.sizeDelta = new Vector2(scale_obj_pos_x + 1, scale_obj_pos_y + 1);


    }
}