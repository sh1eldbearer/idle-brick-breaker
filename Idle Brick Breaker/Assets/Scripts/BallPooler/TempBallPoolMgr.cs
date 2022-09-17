using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: This whole script will need reworked
public class TempBallPoolMgr : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private List<GameObject> _balls;

    [Space, SerializeField] private List<Transform> _spawnPoints;

    [Space, SerializeField] private KeyCode _addBallKeyCode;
    [SerializeField] private KeyCode _removeBallKeyCode;

    private bool _addBallKeypressed = false;

    // Start is called before the first frame update
    void Start()
    {
        if (_ballPrefab == null)
        {
            Debug.LogError("No ball prefab added to the ball factory");
        }

        if (_balls.Count == 0)
        {
            AddBall();
        }

        StartCoroutine(WaitForKeyDown());
    }

    // TODO: Remove this once proper UI/game functionality is implemented
    private IEnumerator WaitForKeyDown()
    {
        while (true)
        {
            if (Input.GetKeyDown(_addBallKeyCode))
            {
                AddBall();
            }
            else if (Input.GetKeyUp(_removeBallKeyCode))
            {
                RemoveBall();
            }
            yield return null;
        }
    }

    private void AddBall()
    {
        // TODO: Flesh out functionality
        Debug.Log("AddBall called");
        int spawnPoint = Random.Range(0, 15);

        GameObject newBall = Instantiate(_ballPrefab, _spawnPoints[spawnPoint].position, Quaternion.identity);
        _balls.Add(newBall);
    }

    private void RemoveBall()
    {
        // TODO: Flesh out functionality
        Debug.Log("RemoveBall called");
        if (_balls.Count > 0)
        {
            Destroy(_balls[_balls.Count - 1]);
            _balls.RemoveAt(_balls.Count - 1);
        }
    }
}
