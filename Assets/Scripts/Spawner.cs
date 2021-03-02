using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CustomUpdate());
    }

    IEnumerator CustomUpdate()
    {
        while (true)
        {
            var go = SimplePool.Instance.GetPooledObject();
            go.transform.position = transform.position;
            go.transform.rotation = Quaternion.identity;
            go.SetActive(true);
            yield return new WaitForSeconds(2.0f);
        }
    }
}
