using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public Transform wall;
    public Transform cam;
    public float cameraFollowSpeed = 2f;
    public float wallMoveSpeed = 1f;

    private float offset = 9f;
    void Update()
    {
        Vector3 wallPosition = new Vector3((wall.position.x + 1), wall.position.y, 0);
        wall.position = Vector3.Lerp(wall.position, wallPosition, wallMoveSpeed*Time.deltaTime);

        Vector3 camPosition = new Vector3((wall.position.x + offset), wall.position.y, -10f);
        //cam.position = Vector3.Lerp(cam.position, camPosition, cameraFollowSpeed*Time.deltaTime);
        cam.position = camPosition;
    }
}
