using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    float y;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        y = transform.position.y;
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = target.position + offset;
        pos.y = y;
        transform.position = pos;
    }
}
