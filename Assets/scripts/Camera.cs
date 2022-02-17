using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform target;
    Vector2 targetPosition;

    public Transform LowerBounds;
    public Transform UpperBounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = target.position;

        targetPosition.x = Mathf.Clamp(target.position.x, LowerBounds.position.x, UpperBounds.position.x);
        targetPosition.y = Mathf.Clamp(target.position.y, LowerBounds.position.y, UpperBounds.position.y);

        transform.position = new Vector3(targetPosition.x, targetPosition.y, -10f);
    }
}
