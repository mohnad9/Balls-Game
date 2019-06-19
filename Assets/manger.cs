using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class manger : MonoBehaviour
{
    public Text txt;
    public int num = 0;
    public void add()
    {
        num++;
        txt.text = num + "";

        if(num > 4)
        {
            txt.text = "you won!";
        }
        
    }
}
