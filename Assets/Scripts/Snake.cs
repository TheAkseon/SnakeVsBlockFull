using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SnakeHead), typeof(TailGenerator))]
public class Snake : MonoBehaviour
{
    private SnakeHead _head;
    private List<Segment> _tail;
    private TailGenerator _tailGenerator;

    private void Awake()
    {
        _head = GetComponent<SnakeHead>();
        _tailGenerator = GetComponent<TailGenerator>();
        _tail = _tailGenerator.Generate();
    }
}
