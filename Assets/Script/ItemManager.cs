using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class ItemManager : MonoBehaviour
{
    [SerializeField] ItemType _itemtype;
    enum ItemType
    {
        item,
        goal
    }

    public abstract void Activate();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_itemtype == ItemType.item)
        {
            if (collision.gameObject.tag == "Player")
            {
                Activate();
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_itemtype == ItemType.goal)
        {
            if (collision.gameObject.tag == "Player")
            {
                Activate();
            }
        }
    }

}
