using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public bool IsTranslate;
    public bool IsRotate;
    public bool IsScale;
    void Update()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(-5, 0, 0) * Time.deltaTime;
    }
}