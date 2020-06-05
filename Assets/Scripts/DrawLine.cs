﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    [SerializeField]
    protected LineRenderer m_LineRenderer;
    [SerializeField]
    protected Camera m_Camera;
    protected List<Vector3> m_Points;

    Vector3 startPos;
    public virtual LineRenderer lineRenderer
    {
        get
        {
            return m_LineRenderer;
        }
    }

    public virtual new Camera camera
    {
        get
        {
            return m_Camera;
        }
    }

    public virtual List<Vector3> points
    {
        get
        {
            return m_Points;
        }
    }


    protected virtual void Awake()
    {
        if (m_LineRenderer == null)
        {
            Debug.LogWarning("DrawLine: Line Renderer not assigned, Adding and Using default Line Renderer.");
            CreateDefaultLineRenderer();
        }
        if (m_Camera == null)
        {
            Debug.LogWarning("DrawLine: Camera not assigned, Using Main Camera or Creating Camera if main not exists.");
            CreateDefaultCamera();
        }
        m_Points = new List<Vector3>();
        m_Points.Add(new Vector3(0, 0, 0));
        m_Points.Add(new Vector3(0, 0, 0));
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.y < 917)
            {
                Vector3 mousePosition = m_Camera.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = m_LineRenderer.transform.position.z;
                startPos = mousePosition;
                m_LineRenderer.enabled = true;
            }
        }
        if (Input.GetMouseButton(0))
        {
            //if (Input.mousePosition.y < 917)
            //{
                Vector3 mousePosition = m_Camera.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = m_LineRenderer.transform.position.z;

                m_LineRenderer.SetPosition(0, startPos);
                m_LineRenderer.SetPosition(1, mousePosition);

            //}
        }

        if (Input.GetMouseButtonUp(0))
        {

            m_LineRenderer.enabled = false;
        }

    }

    protected virtual void Reset()
    {
        if (m_LineRenderer != null)
        {
            m_LineRenderer.positionCount = 0;
        }
        if (m_Points != null)
        {
            m_Points.Clear();
        }
    }

    protected virtual void CreateDefaultLineRenderer()
    {
        m_LineRenderer = gameObject.AddComponent<LineRenderer>();
        m_LineRenderer.positionCount = 0;
        m_LineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        m_LineRenderer.startColor = Color.white;
        m_LineRenderer.endColor = Color.white;
        m_LineRenderer.startWidth = 0.3f;
        m_LineRenderer.endWidth = 0.3f;
        m_LineRenderer.useWorldSpace = true;
    }

    protected virtual void CreateDefaultCamera()
    {
        m_Camera = Camera.main;
        if (m_Camera == null)
        {
            m_Camera = gameObject.AddComponent<Camera>();
        }
        m_Camera.orthographic = true;
    }

}