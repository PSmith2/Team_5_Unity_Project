using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://forum.unity.com/threads/solved-move-towards-a-point-only-on-two-axis.617176/
public class FloatingEnemy : MonoBehaviour
{
    public Transform PosA;
    public Transform PosB;
    public float speed;
    float Speed = speed * Time.deltaTime;
    public Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, PosA.position) < 0.05f)
        {
            targetPos = PosB.position;



        }

        if (Vector2.Distance(transform.position, PosB.position) < 0.05f)
        {
            targetPos = PosA.position;



        }
        var actualTargetPosition = new Vector3(transform.position.x, targetPos.position.y, targetPos.position.z);
        var MT = Vector3.MoveTowards(transform.position, actualTargetPosition, Speed);
        transform.position = MT;

    }

    
}
