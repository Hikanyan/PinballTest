using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private Transform _ballSpawnPoint;
    private GameObject _ball;

    void Start()
    {
        _ball = Instantiate(_ballPrefab, _ballSpawnPoint.position, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_ball == null)
            {
                _ball = Instantiate(_ballPrefab, _ballSpawnPoint.position, Quaternion.identity);
            }
        }

        // リセット
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_ball != null)
            {
                Destroy(_ball);
            }
        }
    }
}