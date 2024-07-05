using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class ItemManager : MonoBehaviour
{
    [SerializeField] ItemType _itemType;
    enum ItemType
    {
        use, get
    }

    public abstract void Activate();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (_itemType == ItemType.get)
            {
                Activate();
                Destroy(gameObject);
            }
            else if (_itemType == ItemType.use)
            {
                this.transform.position = Camera.main.transform.position;
                GetComponent<Collider2D>().enabled = false;
                collision.gameObject.GetComponent<PlayerManager>().GetItem(this);
            }
        }
    }

}
