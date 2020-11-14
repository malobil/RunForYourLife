using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CharacterMovement.Instance.DisableInput();
        CharacterMovement.Instance.FreezeRigidbody();
        UIManager.Instance.ShowHideUI(UIElement.Victory, true);
    }
}
