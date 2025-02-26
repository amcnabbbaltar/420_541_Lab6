using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
  private Animator animator;
  private PlayerMovement movement;
  private Rigidbody rb;
  public void Start()
  {
      animator = GetComponent<Animator>();
      movement = GetComponent<PlayerMovement>();
      rb = GetComponent<Rigidbody>();
  }
  public void LateUpdate()
  {
      if (animator == null || movement == null)
      {
        return;
      }

      animator.SetFloat("CharacterSpeed", rb.velocity.magnitude);
      animator.SetBool("IsFalling",!movement.IsGrounded);
      if (Input.GetButtonUp("Fire1"))
      {
        animator.SetTrigger("doRoll");
      }
      if (Input.GetButtonUp("Fire2"))
      {
        animator.SetTrigger("doPunch");
      }
     
  }

}
