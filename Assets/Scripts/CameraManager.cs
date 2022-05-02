using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Transform follow;

    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = follow.position + offset;
    }
   public IEnumerator Shake (float duration , float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0f;
        while (elapsed<duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y,originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPos;
    }
}
