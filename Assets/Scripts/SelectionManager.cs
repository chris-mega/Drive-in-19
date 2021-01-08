using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private string selectableTag = "Car";
    private Transform prevSelect;
    private Material prevMaterial;

    // Start is called before the first frame update
    void Start() {        
    }

    // Changes object's material and returns old material
    Material ExchangeMaterial(Transform inObject, Material newMat){
        Material oldMat = null;
        if(inObject != null && newMat != null) {
            var selectionRenderer = inObject.GetComponent<Renderer>();
            if(selectionRenderer != null) {
                oldMat = selectionRenderer.material;
                selectionRenderer.material = newMat;
            }
        }
        return oldMat;
    }
    // Update is called on{ce per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) {
                var selection = hit.transform;
                ExchangeMaterial(prevSelect, prevMaterial);
                if(selection != prevSelect && selection.CompareTag(selectableTag)) {
                    prevMaterial = ExchangeMaterial(selection, highlightMaterial);
                    prevSelect = selection;
                } else {
                    prevSelect = null;
                    prevMaterial = null;
                }        
            }
        }
    }
}
