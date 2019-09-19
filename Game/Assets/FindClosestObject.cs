using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosestObject : MonoBehaviour
{
    public string targetTag;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(targetTag);
        GameObject closestObj = null;
        Renderer targetRenderer = null;
        float distance = float.MaxValue;
        
        foreach(GameObject target in gameObjects) {
            Vector3 diff = this.transform.position - target.transform.position;

            if (diff.sqrMagnitude < distance) {
                distance = diff.sqrMagnitude;
                closestObj = target;
            }

            targetRenderer = target.GetComponent<Renderer>();
            targetRenderer.material.color = new Color(1.0f, 1.0f, 1.0f);
        }

        targetRenderer = closestObj.GetComponent<Renderer>();
        targetRenderer.material.color = new Color(1.0f, 0.0f, 0.0f);
    }
}
