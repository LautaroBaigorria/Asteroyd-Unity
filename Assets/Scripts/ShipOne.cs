using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;


public class ShipOne : MonoBehaviour
{
    public float speed = 2.5f;
    public float rotationSpeed = 100f;

    public ScreenBounds screenBounds;

    [Header("Animation")]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
              
        // Rotate the ship based on input
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.back * rotationInput * rotationSpeed * Time.deltaTime);

        // Move the ship forward based on input
        float moveInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.up * moveInput;
        transform.position += moveDirection * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isUpPressed", true);
            Debug.Log("Animation activated");
        }
        else 
        {
            animator.SetBool("isUpPressed", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Left Shift key was pressed");
            Warp();
        }

        Vector3 velocity = speed * moveDirection;
        Vector3 tempPosition = transform.localPosition + velocity * Time.deltaTime;
        if (screenBounds.AmIOutOfBounds(tempPosition))
        {
            Vector2 newPosition = screenBounds.CalculateWrappedPosition(tempPosition);
            transform.position = newPosition;
        }
        else
        {
            transform.position = tempPosition;
        }


    }

    void Warp() 
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // Get random x and y positions within the screen boundaries
        float randomX = Random.Range(0f, screenWidth);
        float randomY = Random.Range(0f, screenHeight);

        // Convert screen coordinates to world coordinates
        Vector3 randomScreenPoint = new Vector3(randomX, randomY, Camera.main.nearClipPlane);
        Vector3 randomWorldPoint = Camera.main.ScreenToWorldPoint(randomScreenPoint);

        // Set the ship's position to the random world point
        transform.position = randomWorldPoint;

    }
}
