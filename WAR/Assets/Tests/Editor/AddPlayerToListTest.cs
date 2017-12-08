using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class AddPlayerToListTest {

	[Test]
	public void AddPlayerToListTestSimplePasses() {
        // Use the Assert class to test conditions.
        GameObject playerPrefab = Resources.Load("Prefabs/player.prefab") as GameObject;
        GameObject playerList = new GameObject();
        playerList.AddComponent(typeof(AddPlayerToList));
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
	public IEnumerator AddPlayerToListTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
