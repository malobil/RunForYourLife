using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisionDetector : MonoBehaviour
{
    private bool m_wallDetected = false;
    private Transform m_wallTransform;

    public bool WallDetected { get => m_wallDetected; }

    private void OnTriggerEnter(Collider other)
    {
        m_wallDetected = true;
    }

    private void OnTriggerExit(Collider other)
    {
        m_wallDetected = false;
    }

   
}
