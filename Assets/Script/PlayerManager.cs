using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    public static float _staticSpeed;
    [SerializeField] float _maxSpeed;
    [SerializeField] float _minSpeed;
    [SerializeField] float _jumpPower;
    Rigidbody2D _rb2d;
    bool _isGround;
    [SerializeField] float _maxLife;
    [SerializeField] float _life;
    public static float _staticLife;
    int _count;
    [SerializeField] Animator _anim;
    [SerializeField] string _sceneName;
    public static bool _gameOver;
    [SerializeField] float _invokeTime = 1;
    [SerializeField] GameObject _gameOverEffect;
    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move(0);
        Jump();
        Recovery(0);
        Damage(0);
    }


    public void Move(float speed)
    {
        _moveSpeed += speed;
        transform.position += transform.right * _moveSpeed * Time.deltaTime;
        if (_moveSpeed <= _minSpeed)
        {
            _moveSpeed = 0;
            GameOver();
            Instantiate(_gameOverEffect,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (_moveSpeed >= _maxSpeed)
        {
            _moveSpeed = _maxSpeed;
        }
        _staticSpeed = _moveSpeed;
    }
    void Jump()
    {
        Vector2 velocity = _rb2d.velocity;
        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            velocity.y = _jumpPower;
            if (_anim)
            {
                _anim.Play("JumpAnim");
            }
        }
        if (Input.GetKeyDown(KeyCode.Return) && _count < 1 && !_isGround)
        {
            velocity.y = -_jumpPower;
            _count++;
            if (_anim)
            {
                _anim.Play("JumpDownAnim");
            }
        }
        _rb2d.velocity = velocity;
    }
    public void Recovery(float recovery)
    {
        if (_maxLife > _life)
        {
            _life += recovery;
        }
        _staticLife = _life;
    }

    public void Damage(float damage)
    {
        _life -= damage;
        if (_life <= 0)
        {
            GameOver();
            Instantiate(_gameOverEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void GameOver()
    {
        _gameOver = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _count = 0;
            _isGround = false;
        }
    }
}
