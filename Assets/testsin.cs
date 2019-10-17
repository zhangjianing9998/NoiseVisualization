using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testsin : MonoBehaviour
{
    public GameObject _prefab;
    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            float _f = Mathf.Sin(i ) * 0.5f;

            GameObject go = Instantiate(_prefab);
            go.transform.localPosition = new Vector3(i * 1.5f, _f, 0);

        }
    }


}
