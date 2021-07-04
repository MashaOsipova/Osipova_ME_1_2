using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool IsTranslate;
    public bool IsRotate;
    public bool IsScale;
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, 2) * Time.deltaTime;
    }
}
