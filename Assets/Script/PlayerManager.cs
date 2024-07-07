using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    [SerializeField] float _jumpPower;
    Rigidbody2D _rb2d;
    bool _isGround;
    [SerializeField] float _maxLife;
    [SerializeField] float _life;
    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(0);
        Jump();
        Recovery(0);
        Debug.Log($"life{_life}");
        Debug.Log($"Speed{_moveSpeed}");
    }


    public void Move(float speed)
    {
        _moveSpeed += speed;
        transform.position += transform.right * _moveSpeed  * Time.deltaTime;
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _rb2d.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }
    public void Recovery(float recovery)
    {
        if (_maxLife > _life)
        {
            _life += recovery;
        }
    }

    public void Damage(float damage)
    { 
            _life -= damage;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = true;
            Debug.Log(_isGround);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = false;
        }
    }
}
