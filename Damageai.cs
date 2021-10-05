
using UnityEngine;

public class Damageai : MonoBehaviour
{
    public int Health=100;
    int Damage;
    public void Damagehealth(int damage)
    {
        Damage = damage;
        Health -= Damage;
        if (Health <= 0)
        {
            //LevelManager.instance.Completelevel();
            Destroy(this.gameObject);
           
            
        }
    }
    
}
