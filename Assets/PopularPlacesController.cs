using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopularPlacesController : MonoBehaviour
{
    void Start()
    {
        // FirebaseFirestore.ini
    }

    // async void Search(string QueryString)
    // {
    //     Query placesQuery = db.Collection("Lugares").WhereEqualTo("Nombre", QueryString);
    //     QuerySnapshot placeQuerySnapshot = await placesQuery.GetSnapshotAsync();
    //     foreach (DocumentSnapshot documentSnapshot in placeQuerySnapshot.Documents)
    //     {
    //         PopularPlaceModel popularPlaceModel = documentSnapshot.ConvertTo<PopularPlaceModel>();
    //         Debug.Log("Document data for {0} document:", documentSnapshot.Id);
    //         // Dictionary<string, object> city = documentSnapshot.ToDictionary();
    //         // foreach (KeyValuePair<string, object> pair in city)
    //         // {
    //         //     Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
    //         // }
    //         // Console.WriteLine("");
    //     }
    //     // Program.cs
    // }
}
