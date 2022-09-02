using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderManager : MonoBehaviour
{
    private OffsetController _offsetController;
    private ColliderCreationManager _colliderCreation;
    

    public List<BoxCollider2D> CreateBoxCollider(GameObject gameObject, float boxColliderHeight)
    {
        _offsetController = gameObject.AddComponent<OffsetController>();
        _colliderCreation = gameObject.AddComponent<ColliderCreationManager>();
        float renderedSizeHeight = gameObject.GetComponent<Renderer>().bounds.size.y;
        List<BoxCollider2D> colliderList = new List<BoxCollider2D>();

        BoxCollider2D topBox;
        BoxCollider2D bottomBox;

        float verticalColliderOffset = _offsetController.CalculateOffsetHeight(renderedSizeHeight, boxColliderHeight);

        topBox = _colliderCreation.CreateAndPlaceBoxCollider(boxColliderHeight, verticalColliderOffset, gameObject, "vertical");
        bottomBox = _colliderCreation.CreateAndPlaceBoxCollider(boxColliderHeight, -verticalColliderOffset, gameObject, "vertical");
        

        colliderList.Add(bottomBox);
        colliderList.Add(topBox);

        return colliderList;
    }

    public void CreateMiddleBoxCollider(GameObject gameObject, float boxColliderHeight)
    {
        _offsetController = GetComponent<OffsetController>();
        _colliderCreation = GetComponent<ColliderCreationManager>();
        BoxCollider2D middleBox;
        float renderedSizeWidth = gameObject.GetComponent<Renderer>().bounds.size.x;
        float horizontalColliderOffset = _offsetController.CalculateOffsetWidth(renderedSizeWidth, boxColliderHeight);
        
        middleBox = _colliderCreation.CreateAndPlaceBoxCollider(boxColliderHeight, horizontalColliderOffset, gameObject, "horizontal");
    }
}
