using UnityEngine;
public class PlayAreaLimiter : MonoBehaviour
{
    private const float NEGATIVE_X_VALUE = -6f;
    private const float POSSITIVE_X_VALUE = 5.2f;
    public void LimitingPlayArea()
    {
        if (transform.position.x > POSSITIVE_X_VALUE)
            transform.position = new Vector3(POSSITIVE_X_VALUE,transform.position.y,transform.position.z);
        else if (transform.position.x < NEGATIVE_X_VALUE)
            transform.position = new Vector3(NEGATIVE_X_VALUE,transform.position.y,transform.position.z);
    }
}