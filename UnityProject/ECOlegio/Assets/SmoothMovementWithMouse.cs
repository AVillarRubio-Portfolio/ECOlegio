using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovementWithMouse : MonoBehaviour {

    Camera camera_;
    float cameraDistance_;

    public float limX_ = 50.0f;
    public float camVelX_ = 50.0f;
    // Use this for initialization
    void Start () {
        camera_ = Camera.main;
        cameraDistance_ = camera_.nearClipPlane; // Distancia de la cámara al plano cercano
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePos = Input.mousePosition;

        Vector3 topLeft = Camera.main.ViewportToScreenPoint(new Vector3(0, 1, cameraDistance_));
        Vector3 topRight = Camera.main.ViewportToScreenPoint(new Vector3(1, 1, cameraDistance_));

        Vector3 pos = camera_.transform.position;
        if (mousePos.x > -10.0f && mousePos.x < topLeft.x + limX_)
            pos.x += -camVelX_;
        else if (mousePos.x > topRight.x - limX_ && mousePos.x < topRight.x + 10.0f)
            pos.x += camVelX_;

        camera_.transform.position = Vector3.Lerp(camera_.transform.position, pos, camVelX_ * Time.deltaTime);
    }
}
