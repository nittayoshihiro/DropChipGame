using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    [SerializeField] Vector2 m_center = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.centerOfMass = m_center;
    }

    // Update is called once per frame
    void Update()
    {

    }
}