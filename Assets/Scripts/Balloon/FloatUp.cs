using System;
using UnityEngine;

public class FloatUp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool floatUpToggle = false;
    [SerializeField] float floatUpSpeed = 1.2f;
    private Vector3 initPos;

    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (floatUpToggle)
        {
            FloatBallonUp();
        }
    }

    public void SetFloatUpToggle(bool val)
    {
        floatUpToggle = val;
    }

    public void FloatBallonUp()
    {
        transform.position += new Vector3(0, floatUpSpeed * Time.deltaTime, 0);
    }
}
