using System.Collections;
using UnityEngine;

public class WaitByIEnumerator : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Wait(5, "1"));
        StartCoroutine(Wait(10, "2"));
    }

    IEnumerator Wait(float sec, string msg)
    {
        yield return new WaitForSeconds(sec);
        Debug.Log(msg);
    }
}