using UnityEngine;



public class InitialAsteroidMovement : MonoBehaviour
{
    public float accelerationTime = 1f;
    public float maxSpeed = 0.5f;
    private Vector2 movement;
    private float timeLeft;

    public Rigidbody2D rb;
    public float speed = 0.1f;

    //public GameObject characterObject;
    //public GameObject areaObject; // collider con forma rectangular
    public float areaLength = 0; // distance between characterObject and areaObject

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }

        //if (GetIfAsteroidInsideArea())
        //{
        //    Debug.Log("Asteroide dentro de zona");
        //}
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }

    //bool GetIfAsteroidInsideArea()
    //{
    //    if (Vector3.Distance(rb.transform.position, areaObject.transform.position) <= areaLength) // if distance between areaObject and character equal or less return true otherwise false
    //        return true;
    //    return false;
    //}


}


