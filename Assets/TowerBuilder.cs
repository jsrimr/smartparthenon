using UnityEngine;
using System.Linq;

public class TowerBuilder : MonoBehaviour
{
    public GameObject cubePrefab;
    public float width = 5.0f;
    public float height = 0.25f;
    public float Depth = 10.0f;

    public float PillarRadius;
    public float PillarHeight;
    public float PillarCountWidth;
    public float PillarCountDepth;
    public float RoofHeight;
  

    public Material floorMaterial;

    [ContextMenu("Build")]
    void Build()
    {
        var floor1 = Instantiate(cubePrefab, GetComponent<Transform>());
        floor1.transform.localPosition = new Vector3(0, 0, 0);
        floor1.transform.localScale = new Vector3(width, height, Depth);
      

        var floor2 = Instantiate(cubePrefab, transform);
        floor2.transform.localPosition = new Vector3(0, height, 0);
        floor2.transform.localScale = new Vector3(width*0.9f, height, Depth*0.9f);

        var floor3 = Instantiate(cubePrefab, transform);
        floor3.transform.localPosition = new Vector3(0, height*2, 0);
        floor3.transform.localScale = new Vector3(width*0.81f, height, Depth*0.81f);
    }
	
	[ContextMenu("Destory All Children")]
	void DestroyAllChildren()
	{
		foreach (Transform t in transform.Cast<Transform>().ToArray())
		{
			DestroyImmediate(t.gameObject);
		}
	}
}
