using UnityEditor.U2D.Aseprite;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    public GameObject Player;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        startPosition = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.position = startPosition;
        }
    }
}