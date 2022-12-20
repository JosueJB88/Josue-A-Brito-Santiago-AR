using System.Collections;
using System.Collections.Generic;
using Firebase.Firestore;
using UnityEngine;
using TMPro;

public class PopularPlacesController : MonoBehaviour
{
	FirebaseFirestore Database,Database1,Database2,Database3,Database4;
	public TMP_InputField TextInputField;
	public GameObject abusador;
	
    void Start()
    {
	    Database = FirebaseFirestore.DefaultInstance;
	    
	    /*
	    TABLA Caracteristicas CAMPO c_caracteristicas 
	    
	    TABLA Emociones CAMPO e_emociones
	    
	    
	    TABLA Melodia CAMPO m_melodia
	    
	    
	    */
	    

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
	            abusador.SetActive(true);
	            
            }
            // Console.WriteLine("");
        } 
        
        
    }
    
   
}





/*using System.Collections;
using System.Collections.Generic;
using Firebase.Firestore;
using UnityEngine;
using TMPro;

public class PopularPlacesController : MonoBehaviour
{
	FirebaseFirestore Database, Database1;
	public TMP_InputField TextInputField;
	public GameObject abusador;

	void Start()
	{
		Database = FirebaseFirestore.DefaultInstance;
		Database1 = FirebaseFirestore.DefaultInstance;
	}

	public async void Search()
	{
		Query placesQuery1 = Database.Collection("Lugares").WhereEqualTo("Nombre", TextInputField.text);
		Query placesQuery2 = Database1.Collection("Caracteristicas").WhereEqualTo("c_caracteristicas", TextInputField.text);
		QuerySnapshot placeQuerySnapshot = await placesQuery1.GetSnapshotAsync();
		QuerySnapshot placeQuerySnapshot1 = await placesQuery2.GetSnapshotAsync();
		foreach (DocumentSnapshot documentSnapshot in placeQuerySnapshot.Documents)
		{
			// PopularPlaceModel popularPlaceModel = documentSnapshot.ConvertTo<PopularPlaceModel>();
			Debug.Log("Document data for {0} document:" + documentSnapshot.Id);
			Dictionary<string, object> city = documentSnapshot.ToDictionary();
			foreach (KeyValuePair<string, object> pair in city)
			{
				Debug.Log("{0}: {1}" + pair.Key + pair.Value);
				abusador.SetActive(true);
			}
			// Console.WriteLine("");
		} 
	}
}
*/