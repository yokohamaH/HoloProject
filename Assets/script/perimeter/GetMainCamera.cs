using UnityEngine;

public class GetMainCamera : MonoBehaviour
{

    GameObject mainCamObj;
    Camera cam;

    void Start()
    {
        mainCamObj = GameObject.FindGameObjectWithTag("MainCamera");
        cam = mainCamObj.GetComponent<Camera>();
    }
}
