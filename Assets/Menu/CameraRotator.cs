using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public static CameraRotator cr;
	public float hitrost;
    public float panHitrost = 2;
    private bool idle = true;

    void Start() {
        if (CameraRotator.cr == null) {
            cr = gameObject.GetComponent<CameraRotator>();
        }
    }

    void Update()
    {
        if (idle) {
            this.transform.Rotate(0, hitrost * Time.deltaTime, 0);
        }
    }

    public void CameraPan() {
        Vector3 targetPos = new Vector3(2, 0, 0);
        Quaternion targetRot = new Quaternion(0, 0, 0, 1);
        Debug.Log("1");
        idle = false;
        StartCoroutine(PanTo(targetPos, targetRot));
        Debug.Log("4");
    }

    IEnumerator PanTo(Vector3 targetPos, Quaternion targetRot) {
        Debug.Log("2");
        while (transform.position != targetPos && transform.rotation != targetRot) {
            Debug.Log("3");
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * panHitrost);
            transform.rotation = Quaternion.LerpUnclamped(transform.rotation, targetRot, Time.deltaTime * panHitrost);
            yield return null;
        }
        Debug.Log(transform.rotation);
    }
}
