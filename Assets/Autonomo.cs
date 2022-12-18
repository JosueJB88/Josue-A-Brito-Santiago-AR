using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Autonomo : MonoBehaviour
{
	public TMP_InputField TextInputField;
	
	//private string imput;
	
	public Sprite [] Ima,Galeria;
	
	public Image im1,im2,im3,im4,im5, ima1,ima2,ima3,ima4,ima5,ima6;
	
	
	public TMP_Text tx1,tx2,tx3,tx4,tx5,txt1,txt2;
	
	public Button Atras,Atras2, op1,op2,op3,op4,op5;
	
	public GameObject rut,Resultado,opcioness;
	
	
    // Start is called before the first frame update
    void Start()
	{
		
		Atras.onClick.AddListener(Inicio);
		Atras2.onClick.AddListener(Cerrar);
	    
		switch (TextInputField.text = "Monumento a los Héroes de la Restauración"){
	    	
	    case "Monumento a los Héroes de la Restauración":
		    op1.onClick.AddListener(()=> RseultadoOP(1));
		    tx1.text = " Monumento de la restauracion";
		    
		    im1.sprite = Ima[1];
		    
		    
		    
		    // op2.onClick.AddListener(()=> RseultadoOP(1));
		    tx2.text = "  ";
		    
		    im2.sprite = Ima[0];
		    
		    
		    
		    
		    // op3.onClick.AddListener(()=> RseultadoOP(1));
		    tx3.text = " ";
		    
		    im3.sprite = Ima[0];
		    
		    
		    
		    
		    // op4.onClick.AddListener(()=> RseultadoOP(1));
		    tx4.text = " ";
		    
		    im4.sprite = Ima[0];
		    
		    
		    
		    // op5.onClick.AddListener(()=> RseultadoOP(1));
		    tx5.text = " ";
		    
		    im5.sprite = Ima[0];
		    break;
		    
		   case "Estadio Cibao":
		   
		    op1.onClick.AddListener(()=> RseultadoOP(2));
		    tx1.text = " Estadio Cibao";
		    
		    im1.sprite = Ima[2];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
		    tx2.text = "  ";
		    
		    im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
		    tx3.text = " ";
		    
		    im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
		    tx4.text = " ";
		    
		    im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
		    tx5.text = " ";
		    
		    im5.sprite = Ima[0];
		    break;
		    
		    
		    
		    
	    default:
	    
		    break;
	    
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void RseultadoOP(int	 resul){
		
		
		
		switch(resul){
			
		case 1:
		 Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[0];
		 txt1.text = " Monumento de la restauracion";
			txt2.text = " Monumento a los Héroes de la Restauración conocido también como el Monumento de Santiago está erigido en"+
			 " la ciudad de Santiago de los Caballeros para conmemorar el 100 aniversario de la independencia del país. Originalmente fue " +
			 "nombrado como el Monumento de la Paz de Trujillo y el mismo sería parte de una serie de obras de distintas índoles construidas"+
			 "en Santiago de los Caballeros en la misma época."+
			 "               "+
			 "Direcion: Lunes y Martes de 6:30 a 17:00, Miercoles a Viernes 8:00 a 17:00 y Sabado y Domingo de 9:00 a16:00";
			 
			ima2.sprite = Galeria[1];
			ima3.sprite = Galeria[2];
			ima4.sprite = Galeria[3];
			ima5.sprite = Galeria[4];
			ima6.sprite = Galeria[5];
		 break; 
		 
		case 2:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[6];
		 
			txt1.text = " Estadio Cibao";
			txt2.text = "El Estadio Cibao es un estadio de béisbol en Santiago de los Caballeros, República Dominicana."+
			 " Se utiliza para los juegos de béisbol teniendo de anfitriones a las Águilas Cibaeñas, equipo perteneciente a la Liga Dominicana de Béisbol." +
			 " l estadio se inauguró el 25 de octubre de 1958 y fue construido por el ingeniero Bienvenido Martínez Brea.";
			ima2.sprite = Galeria[7];
			ima3.sprite = Galeria[8];
			ima4.sprite = Galeria[9];
			ima5.sprite = Galeria[10];
			ima6.sprite = Galeria[11];
		 break;
			
			
		default:
		
			break;
		}
		
		
	}
    
    
    
    
	void Inicio(){
		
		rut.SetActive(false);
		
	}
	
	void Cerrar(){
		
		Resultado.SetActive(false);
		opcioness.SetActive(true);
	}
}
