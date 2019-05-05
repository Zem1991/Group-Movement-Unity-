using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Camera _cam;
    private Vector3 _currentPos;
    private Vector3 _clickPos;

    public string currentPos = "No data";
    public string clickPos = "No data";
    public List<Unit> units = new List<Unit>();

    // Start is called before the first frame update
    void Start()
    {
        _cam = FindObjectOfType<Camera>();
        units = new List<Unit>(FindObjectsOfType<Unit>());
    }

    // Update is called once per frame
    void Update()
    {
        MouseData();
        MoveUnits();
    }

    private void MouseData()
    {
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        int layer_mask = LayerMask.GetMask("Scenario");

        if (Physics.Raycast(ray, out hit, 1000, layer_mask))
        {
            _currentPos = hit.point;
            currentPos = _currentPos.ToString();
        }
        else
        {
            currentPos = "Out of bounds";
        }
    }

    private void MoveUnits()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (currentPos != "Out of bounds")
            {
                _clickPos = _currentPos;
                foreach (var item in units)
                {
                    item.UpdateAIDestination(_clickPos);
                }
            }
            clickPos = currentPos;
        }
    }
}
