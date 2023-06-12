using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public void Hit()
    {
        transform.position = TargetBounds.instance.GetRandomPosition();
    }
}
