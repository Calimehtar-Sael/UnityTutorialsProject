using System;
using UnityEngine;

public class Grounder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TouchedGround?.Invoke(other);
    }

    private void OnTriggerExit(Collider other)
    {
        LeftGround?.Invoke(other);
    }

    public event Action<Collider> TouchedGround;
    public event Action<Collider> LeftGround;
}
