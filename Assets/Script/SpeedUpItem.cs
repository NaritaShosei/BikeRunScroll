using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : ItemManager
{
    [SerializeField] PlayerManager _playerManager;
    [SerializeField] float _speedUp;
    public override void Activate()
    {
        _playerManager._moveSpeed += _speedUp;
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
