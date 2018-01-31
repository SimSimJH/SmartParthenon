using System.Linq;
using UnityEngine;




public class Parthenon : MonoBehaviour {

    public GameObject cubePrefab;
    public float width = 5.0f;
    public float depth = 10.0f;
    public float height = 0.25f;
    public float pillar_radius = 0.2f;
    public float pillar_height = 2.0f;
    public float pillar_count_width = 6.0f;
    public float pillar_count_Depth = 10.0f;
    public float roof_height = 1.0f;



    [ContextMenu("Build_Pharthenon")]
    void Build()
    {   
        foreach(Transform t in transform.Cast<Transform>().ToArray())
        {
            DestroyImmediate(t.gameObject);
        }

        var newGameObject1 = Instantiate(cubePrefab, transform);
        var floor1 = newGameObject1.GetComponent<Transform>();
        floor1.position= new Vector3(0, 0, 0);
        floor1.localScale = new Vector3(width, height, depth);

        var newGameObject2 = Instantiate(cubePrefab, transform);
        var floor2 = newGameObject2.GetComponent<Transform>();
        floor2.position = new Vector3(0, height, 0);
        floor2.localScale = new Vector3(width*0.9f, height, depth*0.9f);

        var newGameObject3 = Instantiate(cubePrefab, transform);
        var floor3 = newGameObject3.GetComponent<Transform>();
        floor3.position = new Vector3(0, height*2, 0);
        floor3.localScale = new Vector3(width * 0.81f, height, depth * 0.81f);

    }

}
