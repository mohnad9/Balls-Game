using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public GameObject target;
    Vector3 fixposition = new Vector3(0, 2, -10);
    void Update()
    {
        transform.position = target.transform.position + fixposition;
    }
}
