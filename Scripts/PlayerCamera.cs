﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    Transform target;

    private void LateUpdate() {
        transform.position = new Vector3(target.position.x, target.position.y, -10f);
    }
}