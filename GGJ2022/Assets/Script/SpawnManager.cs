// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEditor;

// public class SpawnManager : MonoBehaviour
// {
//     public Vector3 blackspawnPos;
//     public GameObject blackPrefab;

//     public List<GameObject> blacks;

//     private void Start()
//     {
//       SpawnBlack();
      
//     }

//     private void Update() {
      
//       StartCoroutine(CheckBlackState());

//     }
//     public void SpawnBlack()
//     {
//         Debug.Log("Spawning black");	
//         GameObject newGo = Instantiate(blackPrefab, blackspawnPos, Quaternion.identity);
//         blacks.Add(newGo);
//     }

//     IEnumerator CheckBlackState()
//     {

//       yield return new WaitForSeconds(1);

//       if(blacks.Contains())
//       {
//           SpawnBlack();
//       }
//     }
// }
