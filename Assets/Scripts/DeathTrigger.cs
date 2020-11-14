using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CharacterMovement.Instance.DisableInput();
        CharacterMovement.Instance.FreezeRigidbody();
        UIManager.Instance.ShowHideUI(UIElement.GameOver, true);
    }
}
