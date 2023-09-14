using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float h_speed = 1;
    [SerializeField]
    private int _jumpForce = 5;
    [SerializeField]
    private bool _grounded = false;
    private Rigidbody2D _rigb;
    [SerializeField]

    private PlayerAnimation _playeranim;
    [SerializeField]
    private SpriteRenderer _playersprite;


    //get reference to rigidbody
    void Start()
    {
        //assign handle of rigidbody
        _rigb = gameObject.GetComponent<Rigidbody2D>();
        _playeranim = gameObject.GetComponent<PlayerAnimation>();
        _playersprite = this.gameObject.GetComponentInChildren<SpriteRenderer>();

        if(_playersprite == null)
        {
            Debug.Log("The sprite renderer is NULL");
        }
        FlipPlayer();

    }

    // Update is called once per frame
    void Update()
    {
        CheckGrounded();
        PlayerMove();
        

        //instead of transform translate, modify velocity of player
        //horizontal input for left and right
        //current velocity = new velocity Vector2(horizontal input, current velocity.y)
        // cast ray for physics 2d, playerposition down to ground
    }


    void CheckGrounded(){
    RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1.0f, 1 << 8);
    Debug.DrawRay(transform.position, -Vector2.up, Color.red);

    if (hit.collider != null) {
        float distance = Mathf.Abs(hit.point.y - transform.position.y);
        // Debug.Log("distance " + distance);
        _grounded = true;
        _playeranim.Jump(_grounded);

    }
    else {
        _grounded = false;
        _playeranim.Jump(_grounded);

    }
    }

    void PlayerMove(){
        float horizontal = Input.GetAxisRaw("Horizontal"); //provides inputs, raw makes binary not float
        FlipPlayer();
        
        Debug.Log(horizontal);


        _rigb.velocity = new Vector2(horizontal * h_speed, _rigb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)  &&  _grounded == true){
            Debug.Log("space key down");
            _rigb.velocity = new Vector2(_rigb.velocity.x * h_speed, _jumpForce);
        }

        _playeranim.Move(horizontal);
    }

    void FlipPlayer(){
        if (_rigb.velocity.x > 0f){
            _playersprite.flipX = false;
            Debug.Log("not flipped");
        }
        else if (_rigb.velocity.x < -0f) {
            _playersprite.flipX = true;
            Debug.Log("flipped");
        }
    }
}
