using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    public bool IsTranslate;
    public bool IsRotate;
    public bool IsScale;
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3(1.5f, 1.5f, 1.5f) * Time.deltaTime;
    }
}