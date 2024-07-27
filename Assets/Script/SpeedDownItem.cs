using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDownItem : ItemManager
{
    [SerializeField] float _speedDown;
    [SerializeField] float _spawnDisDown;
    public override void Activate()
    {
        FindObjectOfType<PlayerManager>().Move(-_speedDown);
        FindObjectOfType<ItemGenerator>().StartSpawn(-_spawnDisDown);
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
