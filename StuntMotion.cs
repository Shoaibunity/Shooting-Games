
using UnityEngine;




public class StuntMotion : MonoBehaviour
{
  
    public static StuntMotion instance;
    public static Transform LastCheckpoint;
    public  Rigidbody rb;

   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        instance = this;
       
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finished")
        {
           
            rb.isKinematic = true;

            LevelManager.instance.Completelevel();
           
        }
        if (other.gameObject.tag == "Failed")
        {

            LevelManager.instance.Failedlevel();                  
           
        }
           
    }
    
    
   
   
}
