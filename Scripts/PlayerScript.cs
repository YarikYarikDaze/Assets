using UnityEngine;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    Transform handPoint;
    [SerializeField]
    float maxWidth;
    float width;
    float radius;

    void Start()
    {
        handPoint = this.transform;
    }

    void Update()
    {
        int handLen = transform.GetChild(0).childCount;
        width = (handLen*2 < maxWidth) ? handLen*2 : maxWidth;
        for (int i = 0; i < handLen; i++)
        {
            transform.GetChild(0).GetChild(i).position = new Vector3(
                handPoint.position.x - width / 2 + width / handLen * ((float)i + 0.5f), handPoint.position.y, handPoint.position.z
            );
            transform.GetChild(0).GetChild(i).GetComponent<SpriteRenderer>().sortingOrder = i;
        }
    }
}
