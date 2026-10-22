using UnityEngine;

public class livesFloor : MonoBehaviour
{
    
    [SerializeField] private int damage = 1;
    public int Damage
    {
        get {  return damage; }
        set{ damage = value ; }
    }
    [SerializeField] private int lifePiso = 3;
    public int LifePiso => lifePiso;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update() { 

    }


}

