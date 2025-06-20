using UnityEngine;

public class PathVisualizer : MonoBehaviour
{
    public Transform[] waypoints;
    public Color pathColor = Color.green;

    void OnDrawGizmos()
    {
        if (waypoints == null || waypoints.Length < 2) return;

        Gizmos.color = pathColor;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            if (waypoints[i] && waypoints[i + 1])
            {
                Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
                Gizmos.DrawSphere(waypoints[i].position, 0.2f);
            }
        }
    }
}
