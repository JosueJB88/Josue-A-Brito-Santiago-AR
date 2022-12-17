using System.Collections;
using System.Collections.Generic;
using Firebase.Firestore;
using UnityEngine;
using TMPro;

public class PopularPlacesController : MonoBehaviour
{
    FirebaseFirestore Database;
    public TMP_InputField TextInputField;
    void Start()
    {
        Database = FirebaseFirestore.DefaultInstance;
    }

    public async void Search()
    {
        Query placesQuery = Database.Collection("Lugares").WhereEqualTo("Nombre", TextInputField.text);
        QuerySnapshot placeQuerySnapshot = await placesQuery.GetSnapshotAsync();
        foreach (DocumentSnapshot documentSnapshot in placeQuerySnapshot.Documents)
        {
            // PopularPlaceModel popularPlaceModel = documentSnapshot.ConvertTo<PopularPlaceModel>();
            Debug.Log("Document data for {0} document:" + documentSnapshot.Id);
            Dictionary<string, object> city = documentSnapshot.ToDictionary();
            foreach (KeyValuePair<string, object> pair in city)
            {
                Debug.Log("{0}: {1}" + pair.Key + pair.Value);
            }
            // Console.WriteLine("");
        }
        // Program.cs
    }
}
