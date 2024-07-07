using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageItem : ItemManager
{
    [SerializeField] float _damage;
    public override void Activate()
    {
        FindObjectOfType<PlayerManager>().Damage(_damage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
