using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {
    [SerializeField]
    Transform toDump;
    [SerializeField]
    int count;
    [SerializeField]
    Vector3Int boundMin;
    [SerializeField]
    Vector3Int boundMax;
    [SerializeField]
    Vector2 scaleRange;
    [SerializeField]
    bool isSquare;

    // Start is called before the first frame update
    void Start() {
        DumpObjects();
    }

    void DumpObjects() {
        Transform clone;
        for (int i = 0; i < count; i++) {
            clone = Instantiate(toDump, new Vector3(Random.Range(boundMin.x, boundMax.x), 
                                                    Random.Range(boundMin.y, boundMax.y),
                                                    Random.Range(boundMin.z, boundMax.z)),
                                        new Quaternion(
                                            Random.Range(-1,1),
                                            Random.Range(-1,1),
                                            Random.Range(-1,1),
                                            Random.Range(-1,1)));
            if (isSquare) {
                float size = Random.Range(scaleRange.x, scaleRange.y);
                clone.localScale = new Vector3(size, size, size) ;
            } else {
                clone.localScale = new Vector3(Random.Range(scaleRange.x, scaleRange.y), 
                                               Random.Range(scaleRange.x, scaleRange.y), 
                                               Random.Range(scaleRange.x, scaleRange.y)) ;
            }    
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
