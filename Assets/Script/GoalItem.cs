using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalItem : ItemManager
{
    [SerializeField] string _sceneName;
    public override void Activate()
    {
        SceneChangeManager.SceneChange(_sceneName);
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
