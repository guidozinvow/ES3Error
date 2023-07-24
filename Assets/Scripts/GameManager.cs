using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviourSingletonPersistent<GameManager>
{
    public bool menuAnimationShown;

    public GameStates gameState;
    public bool isOnGame { get { return gameState == GameStates.GAME; } }

    private bool isStartButtonAlreadyPressed;
    public DataLoader dataLoader;

    public enum GameStates
    {
        START_SCREEN,
        HANGAR,
        GAME,
    };

    void Start()
    {
        gameState = GameStates.START_SCREEN;
        dataLoader = GetComponent<DataLoader>();
        StartCoroutine(Countdown(6f));
    }

    public void StartGame()
    {
        if (!isStartButtonAlreadyPressed)
        {
            UpdateGameState(GameStates.GAME);
            isStartButtonAlreadyPressed = true;
        }
    }

    public void GoToHangar()
    {
        UpdateGameState(GameStates.HANGAR);
    }

    private void UpdateGameState(GameStates newGameState)
    {
        gameState = newGameState;
        switch (newGameState)
        {
            case GameStates.START_SCREEN:
                StartCoroutine(ChangeScene("Menu"));
                break;
            case GameStates.HANGAR:
                StartCoroutine(BackToHangar());
                break;
            default:
                break;
        }
    }

    public IEnumerator Countdown(float time)
    {
        yield return new WaitForSeconds(time);
        GoToHangar();
    }

    private IEnumerator ChangeScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }

    private IEnumerator BackToHangar()
    {
        yield return SceneManager.LoadSceneAsync("Hangar");
    }
}