using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float _moveSpeed;
    [SerializeField] float _jumpPower;
    Rigidbody2D _rb2d;
    bool _isGround;
    List<ItemManager> _itemList = new List<ItemManager>();
    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        ItemUse();
    }
    void ItemUse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_itemList.Count > 0)
            {
                // リストの先頭にあるアイテムを使って、破棄する
                ItemManager item = _itemList[0];
                _itemList.RemoveAt(0);
                item.Activate();
                Destroy(item.gameObject);
            }
        }
    }
    public void GetItem(ItemManager item)
    {
        _itemList.Add(item);
    }
    public void Move()
    {
        transform.position += transform.right * _moveSpeed  * Time.deltaTime;
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _rb2d.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
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
