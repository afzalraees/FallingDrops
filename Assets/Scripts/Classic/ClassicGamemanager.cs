using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicGamemanager : MonoBehaviour
{

    public static ClassicGamemanager instance;
    public DropManager dropManager;

    private void Awake()
    {
        instance = this;
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
