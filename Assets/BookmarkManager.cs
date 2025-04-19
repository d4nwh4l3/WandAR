using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class BookmarkManager : MonoBehaviour
{
    public static BookmarkManager Instance;
    private Dictionary<string, GameObject> bookmarkUIMap = new Dictionary<string, GameObject>();


    [Header("UI References")]
    public Transform bookmarkListParent; // Assign your Grid Layout Group here
    public GameObject bookmarkItemPrefab; // Assign your prefab here

    private List<Bookmark> bookmarks = new List<Bookmark>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddBookmark(string name, double lat, double lon)
    {
        if (bookmarks.Exists(b => b.name == name))
        {
            Debug.Log($"Bookmark for {name} already exists.");
            return;
        }

        Bookmark newBookmark = new Bookmark(name, lat, lon);
        bookmarks.Add(newBookmark);

        GameObject bookmarkUI = Instantiate(bookmarkItemPrefab, bookmarkListParent);
        bookmarkUI.GetComponentInChildren<Text>().text = name;

        // Assign remove button (assuming prefab has one)
        Button removeButton = bookmarkUI.transform.Find("RemoveButton").GetComponent<Button>();
        removeButton.onClick.AddListener(() => RemoveBookmark(name));

        bookmarkUIMap[name] = bookmarkUI;
    }

    public void RemoveBookmark(string name)
    {
        Bookmark existing = bookmarks.FirstOrDefault(b => b.name == name);
        if (existing != null)
        {
            bookmarks.Remove(existing);
            Debug.Log($"{name} removed from bookmarks.");
        }

        if (bookmarkUIMap.ContainsKey(name))
        {
            Destroy(bookmarkUIMap[name]);
            bookmarkUIMap.Remove(name);
        }
    }



    public class Bookmark
    {
        public string name;
        public double latitude;
        public double longitude;

        public Bookmark(string name, double lat, double lon)
        {
            this.name = name;
            this.latitude = lat;
            this.longitude = lon;
        }
    }
}
