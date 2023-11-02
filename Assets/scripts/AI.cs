using UnityEngine;

public class AI : MonoBehaviour
{
    //variables

    // speed
    public float speed = 5.0f; 
    // transform
    public Transform ballTransform;

    void Update()
    {
        if (ballTransform != null)
        {
                                                           
            float direction = Mathf.Sign(ballTransform.position.y - transform.position.y);

        
            float newYPosition = transform.position.y + direction * speed * Time.deltaTime;

            newYPosition = Mathf.Clamp(newYPosition, -3.9f, 3.9f);

            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }
    }
}
