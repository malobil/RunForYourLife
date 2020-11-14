using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPill : MonoBehaviour
{
    [SerializeField] private float m_lifeGiven = 10f;

    private void OnTriggerEnter(Collider other)
    {
        CharacterMovement.Instance.GainLife(m_lifeGiven);
        Destroy(gameObject);
    }
}
