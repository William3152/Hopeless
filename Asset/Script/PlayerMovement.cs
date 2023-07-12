using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    public float jumpForce = 30f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    int groundLayer;
    private Animator animator;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      spriteRenderer = GetComponent<SpriteRenderer>();
      groundLayer = LayerMask.GetMask("Ground");
      animator = GetComponent<Animator>();
    }

    private void SpriteFlip(float horizontalInput)
    {
        if(horizontalInput < 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }

    #region AnimationHandler
    private void PlayWalk()
    {
        animator.SetTrigger("goWalk");
    }
    private void PlayJump()
    {
        animator.SetTrigger("goJump");
    }
    #endregion

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f));
        SpriteFlip(horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            PlayJump();
        }
    }
}
