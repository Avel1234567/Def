using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Transform followingTarget;
    [SerializeField, Range(0f, 1f)] float parallaxStrenght = 0.3f;
    [SerializeField] bool disableVerticalParallax;
    Vector3 targetPreviousPosition;

    void Start()
    {
        if (!followingTarget)
        {
            followingTarget = Camera.main.transform;
        }
        targetPreviousPosition = followingTarget.position;
    }

    void Update()
    {
        var delta = followingTarget.position - targetPreviousPosition;
        if (disableVerticalParallax)
        {
            delta.y = 0;
        }
        targetPreviousPosition = followingTarget.position;
        transform.position -= delta * parallaxStrenght;
    }
}
