using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds; // Initialize the number of seeds left
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted); // Update UI in console
    }

    private void Update()
    {

         float moveInputHorizontal = Input.GetAxis("Horizontal");
        float moveInputVertical = Input.GetAxis("Vertical");

        //declare a vector3 variable for position
        Vector3 move = new Vector3(moveInputHorizontal, moveInputVertical, 0) * _speed * Time.deltaTime;

        //player's transform position transforms base on the vector3 Move
        _playerTransform.position += move;

        // If press space, then plant seed
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            PlantSeed();
        }

    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0){

             Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);


            _numSeedsLeft -= 1;
            _numSeedsPlanted +=1;

            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        
        }
    }
}
