using UnityEngine;

namespace Util
{
    public class BootConstantsUtil: MonoBehaviour
    {
        public const float ZFreezePosition = 0;
        public const int NumOfDotsToShow = 10;
        public const float DotTimeStep = 0.05f;
        public const int Force = 70;
        public const int XDistanceConstraint = 5;
        public const int YUpDistanceConstraint = 10;
        public const int YDownDistanceConstraint = 2;
        public static readonly Vector3 GravityVector = new Vector3(0f, -100f, 0);
    }
}