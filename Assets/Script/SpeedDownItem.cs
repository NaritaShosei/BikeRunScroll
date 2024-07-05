using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDownItem : ItemManager
{
    [SerializeField] float _speedDown;
    public override void Activate()
    {
        FindObjectOfType<PlayerManager>()._moveSpeed -= _speedDown;
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
