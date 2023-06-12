using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class TargetDetect : MonoBehaviour
{
    [SerializeField] Camera cam;
    public static int hitPoint = 0;
    public static int missPoint = 0;
    public AimStats aimStats;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && aimStats.timerIsRunning)
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                TargetGenerator target = hit.collider.gameObject.GetComponent<TargetGenerator>();

                if (target != null)
                {
                    target.Hit();
                    hitPoint++;
                }
                else
                    missPoint++;
            }
        }
    }
}
