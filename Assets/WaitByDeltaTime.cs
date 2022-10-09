using UnityEngine;

public class WaitByDeltaTime : MonoBehaviour
{
    public float time = 0;
    bool used = false;

    void Update()
    {
        time += Time.deltaTime;

        if (time > 10)
        {
            Debug.Log(2);
            Destroy(gameObject);
        }
        else if (time > 5 && !used)
        {
            Debug.Log(1);
            used = true;
        }
    }
}