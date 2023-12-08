using UnityEngine;

public class Wall : MonoBehaviour
{
    public Vector3 Position = new Vector3();
    public int NumberOfRows = 5;
    public int NumberOfColumns = 5;
    public bool RandomizeBrickColors = true;

    void Start()
    {
        BuildEntireWall();
    }

    private void BuildEntireWall()
    {
        for (int i = 0; i < NumberOfRows; i++)
        {
            BuildOneRowOfWall(Position + i * Vector3.up, i);
        }
    }

    private void BuildOneRowOfWall(Vector3 where, int row)
    {
        for (int i = 0; i < NumberOfColumns; i++)
        {
            var brick = GameObject.CreatePrimitive(PrimitiveType.Cube);
            brick.transform.position = where + new Vector3(0, 0, 1.01f * i);

            var body = brick.AddComponent<Rigidbody>();
            body.mass = 0.1f;

            var material = brick.GetComponent<MeshRenderer>().material;
            var j1 = (1 + i) / (float)NumberOfColumns;
            var j2 = (1 + row) / (float)NumberOfRows;

            if (RandomizeBrickColors)
            {
                material.color = Random.ColorHSV(0, 1);
            }
            else
            {
                material.color = new Color(j1, 1.0f - j2, 0);
            }
        }
    }
}
