using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float dumping = 1.5f;
    private Transform player;
    public static CameraController instance;
    public Room currRoom;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    
    // Update is called once per frame
    /*void Update()
    {
        UpdatePosition();
        //transform.position = Vector3.MoveTowards(transform.position, V3, dumping);
    }
    void UpdatePosition()
    {
        if(currRoom == null)
        {
            return;
        }
        Vector3 targetPos = GetCameraTargetPosition();
    }

    Vector3 GetCameraTargetPosition()
    {
        if (currRoom == null)
        {
            return Vector3.zero;
        }
        Vector3 targetPos = currRoom.GetRoomCentre();
        targetPos.z = transform.position.z;

        return targetPos;
    }
    public bool IsSwitchingScene()
    {
        return transform.position.Equals(GetCameraTargetPosition()) == false;
    }*/
}
