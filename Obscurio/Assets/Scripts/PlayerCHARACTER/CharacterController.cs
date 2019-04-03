using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CharacterController : MonoBehaviour
{
    [SerializeField] private float Jumping = 400f;
    [SerializeField] private float SmoothMove = 0.5f;
    [SerializeField] private LayerMask Ground;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private Transform CeilingCheck;

    const float GroundedRadius = 0.2f;
    private bool Grounded;
    const float CeilingRadius = 0.2f;
    private Rigidbody2D rb;
    private bool FaceRight = true;
    private Vector3 velocity = Vector3.zero;

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    public Animator Animator;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
    }

    private void FixedUpdate()
    {
        bool wasGrounded = Grounded;
        Grounded = false;


        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            Animator.SetFloat("Speed", 1);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            Animator.SetFloat("Speed", 0);
        }


        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, Ground);
            for (int i = 0; i< colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                Grounded = true;
                if (!wasGrounded)
                    OnLandEvent.Invoke();
            }
        } 
    }


    public void Move(float move, bool jump)
    {
        if (Grounded)
        {


            Vector3 targetVelocity = new Vector2(move * 10f, rb.velocity.y);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, SmoothMove);
            if (move > 0 && !FaceRight)
            {
                Flip();
                

            }
            else if (move < 0 && FaceRight)
            {
                Flip();
                
            }
        }
        if(Grounded && jump)
        {
            Grounded = false;
            rb.AddForce(new Vector2(0f, Jumping));
        }

    }

    private void Flip()
    {
        FaceRight = !FaceRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

}
