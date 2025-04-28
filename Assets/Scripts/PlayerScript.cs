using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    public float Power = 10;
    bool isJumping = false;
    bool isCircle = true;
    bool isSquare = false;
    bool isTriangle = false;

        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
       
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    
    {
        //どのキーでどの図形になるか
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCircle = true;
            isSquare = false;
            isTriangle = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            isSquare = true;
            isCircle = false;
            isTriangle= false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            isTriangle = true;
            isCircle = false;
            isSquare = false;
        }

        //図形ごとの能力のオンオフ
        if (!isCircle)
        {

        }

        if (isSquare)
        {

        }

        if (isTriangle)
        {

        }

	float horizontalInput = Input.GetAxis("Horizontal");
	Vector3 pos = transform.position;
	pos.x += horizontalInput * 0.04f;
	transform.position = pos;

        float VerticalInput = Input.GetAxis("Vertical");
        if (VerticalInput != 0)
        
            if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!isJumping) {
                    rb.AddForce(new Vector3(0, Power, 0), ForceMode2D.Impulse);
                    isJumping = true;
                }
                
            }
        if (!isJumping)
        {
            
        }
       
        
    }
}
