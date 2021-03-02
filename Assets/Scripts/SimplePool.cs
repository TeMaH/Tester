using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePool : Singleton<SimplePool>
{
    public int amountToPool = 5;
    public GameObject prefab;

    List<GameObject> pooledObjects;

    void Awake()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            var go = Instantiate<GameObject>(prefab, transform.position, Quaternion.identity);
            go.transform.SetParent(transform);
            go.SetActive(false);
            pooledObjects.Add(go);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
