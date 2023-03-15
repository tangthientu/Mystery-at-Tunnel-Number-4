using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SaveIsEasy;
using UnityEngine.SceneManagement;
public class SetCheckPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private string sceneFileName;
    private Scene selected;
   
    void Start()
    {
        selected = SceneManager.GetSceneAt(0);
        sceneFileName = SaveIsEasyAPI.GetSceneFileNameByScene(selected);

    }

    // Update is called once per frame
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            savegame();
            Debug.Log("Set new checkpoint");
            Destroy(gameObject);   
        }
    }
    public void savegame()
    {
        SaveIsEasyAPI.SaveAll(selected);
    }
}
