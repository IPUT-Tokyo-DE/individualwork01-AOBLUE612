//using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Goal : MonoBehaviour
{
    public GameObject Player;
    public TextMeshProUGUI GoalText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        GoalText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.gameObject == Player)
        {
            GoalText.text = "Goal!";
        }
    }
}
