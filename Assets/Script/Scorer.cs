using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("You bumped into things this many times: " + score);
    }
}
