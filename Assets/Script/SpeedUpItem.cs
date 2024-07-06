using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : ItemManager
{
    [SerializeField] float _speedUp;
    public override void Activate()
    {
        FindObjectOfType<PlayerManager>().Move(_speedUp);
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
