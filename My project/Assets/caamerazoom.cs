using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caamerazoom : MonoBehaviour
{private Camera cam;
     public float TargetZoom = 3;
     private float ScrollData;
     public float ZoomSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        TargetZoom = cam.orthographicsize;
    }

    // Update is called once per frame
    void Update()
    {
        ScrollData = Input.GetAxis("Mouse ScrollWheel");
         TargetZoom = TargetZoom - ScrollData;
          TargetZoom = Mathf.Clamp(TargetZoom , 3 , 6);
          cam.orthographicsize = Mathf.Lerp( cam.orthographicsize ,TargetZoom , Time.deltaTime *ZoomSpeed   );
    }
}
