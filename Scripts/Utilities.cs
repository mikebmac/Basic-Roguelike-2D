﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
}
