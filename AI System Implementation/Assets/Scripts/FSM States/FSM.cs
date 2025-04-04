using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    //player transform
    protected Transform playerTransform;

    //next destination position of the NPC tank
    protected Vector3 destPos;

    //list of points for patrolling
    protected GameObject[] pointList;

    //bullet shooting rate
    //protected float shootRate;
    //protected float elaspedTime;

    //tank turret
    //public Transform turret { get; set; }
    //public Transform bulletSpawnPoint { get; set; }

    protected virtual void Initialize() { }
    public virtual void FSMUpdate() { }
    protected virtual void FSMFixedUpdate() { }

    //use this for initialization
    void Start()
    {
        Initialize();
    }

    //update is called once per frame
    void Update()
    {
        FSMUpdate();
    }

    void FixedUpdate()
    {
        FSMFixedUpdate();
    }
}

