using UnityEngine;

public class Keypickupd : MonoBehaviour
{
    [SerializeField]
    GameObject obstacle;
    bool isopened = false;



    private void OnTriggerEnter(Collider collision)
    {
        if (isopened == false)
        {
            isopened = true;
            obstacle.GetComponent<Dooropend>().pickedKey();
            //obstacle.transform.position += new Vector3(0, 4, 0);
            Destroy(gameObject);
        }
    }
}
