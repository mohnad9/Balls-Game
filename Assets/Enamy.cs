using UnityEngine;

public class Enamy : MonoBehaviour
{
    public manger m;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        m = FindObjectOfType<manger>();
        m.add();
    }
}
