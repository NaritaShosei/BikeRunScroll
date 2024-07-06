using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryItem : ItemManager
{
    [SerializeField] float _recovery;
    public override void Activate()
    {
        FindObjectOfType<PlayerManager>().Life(_recovery);
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
