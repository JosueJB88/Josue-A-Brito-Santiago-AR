using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Autonomo : MonoBehaviour
{
	public TMP_InputField TextInputField;
	
	
	
	public Sprite [] Ima,Galeria;
	
	public Image im1,im2,im3,im4,im5, ima1,ima2,ima3,ima4,ima5,ima6;
	
	public string imput,Url;
	public TMP_Text tx1,tx2,tx3,tx4,tx5,txt1,txt2;
	
	public Button Atras,Atras2, op1,op2,op3,op4,op5,lupa,mapa;
	
	public GameObject rut,Resultado,opcioness;
	
	
	// Start is called before the first frame update
	void Start()
	{
		
		Atras.onClick.AddListener(Inicio);
		Atras2.onClick.AddListener(Cerrar);
		lupa.onClick.AddListener(busqueda);
	
	}
    
    
    
	void busqueda() { 
		
		imput = TextInputField.text;
		
		
		switch (imput /*= "romantico"*/){
	    	
		case "Monumento a los Héroes de la Restauración":
			op1.onClick.AddListener(()=> RseultadoOP(1));
			tx1.text = " Monumento de la restauracion";
		    
			im1.sprite = Ima[1];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = " ";
		    
			im5.sprite = Ima[0];
			break;
			
			
		case "amor":
			op1.onClick.AddListener(()=> RseultadoOP(1));
			tx1.text = " Monumento de la restauracion";
		    
			im1.sprite = Ima[1];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(7));
			tx2.text = "Hazlo Simple";
		    
			im2.sprite = Ima[7];
		    
		    
		    
		    
			op3.onClick.AddListener(()=> RseultadoOP(9));
			tx3.text = "Cinema Centro Cibao";
		    
			im3.sprite = Ima[9];
		    
		    
		    
		    
			op4.onClick.AddListener(()=> RseultadoOP(17));
			tx4.text = "Jardín Botánico";
		    
			im4.sprite = Ima[14];
		    
		    
		    
			op5.onClick.AddListener(()=> RseultadoOP(19));
			tx5.text = "McDonald's Estrella Sadhalá";
		    
			im5.sprite = Ima[16];
			break;
			
			
		case "romantico":
			op1.onClick.AddListener(()=> RseultadoOP(1));
			tx1.text = " Monumento de la restauracion";
		    
			im1.sprite = Ima[1];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(7));
			tx2.text = "Hazlo Simple";
		    
			im2.sprite = Ima[7];
		    
		    
		    
		    
			op3.onClick.AddListener(()=> RseultadoOP(9));
			tx3.text = "Cinema Centro Cibao";
		    
			im3.sprite = Ima[9];
		    
		    
		    
		    
			op4.onClick.AddListener(()=> RseultadoOP(17));
			tx4.text = "Jardín Botánico";
		    
			im4.sprite = Ima[14];
		    
		    
		    
			op5.onClick.AddListener(()=> RseultadoOP(19));
			tx5.text = "McDonald's Estrella Sadhalá";
		    
			im5.sprite = Ima[16];
			break;
		    
		case "monumento":
			op1.onClick.AddListener(()=> RseultadoOP(1));
			tx1.text = " Monumento de la restauracion";
		    
			im1.sprite = Ima[1];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
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
			tx2.text = " No hay mas opciones ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = " No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
			
		case "estadio":
		   
			op1.onClick.AddListener(()=> RseultadoOP(2));
			tx1.text = " Estadio Cibao";
		    
			im1.sprite = Ima[2];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = " No hay mas opciones ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = " No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
		    
		case "Fortaleza San Luis":
		   
			op1.onClick.AddListener(()=> RseultadoOP(3));
			tx1.text = " Fortaleza San Luis";
		    
			im1.sprite = Ima[3];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
		    
		case "Catedral Santiago Apóstol":
		   
			op1.onClick.AddListener(()=> RseultadoOP(4));
			tx1.text = " Catedral Santiago Apóstol";
		    
			im1.sprite = Ima[4];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
		case "fe":
		   
			op1.onClick.AddListener(()=> RseultadoOP(4));
			tx1.text = " Catedral Santiago Apóstol";
		    
			im1.sprite = Ima[4];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(15));
			tx2.text = "Parroquia Nuestra Sra. De La Altagracia";
		    
			im2.sprite = Ima[12];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Parque Duarte":
		   
			op1.onClick.AddListener(()=> RseultadoOP(5));
			tx1.text = "Parque Duarte";
		    
			im1.sprite = Ima[5];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Centro León":
		   
			op1.onClick.AddListener(()=> RseultadoOP(6));
			tx1.text = "Centro León";
		    
			im1.sprite = Ima[6];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Hazlo Simple":
		   
			op1.onClick.AddListener(()=> RseultadoOP(7));
			tx1.text = "Hazlo Simple";
		    
			im1.sprite = Ima[7];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Kukaramakara":
		   
			op1.onClick.AddListener(()=> RseultadoOP(8));
			tx1.text = "Kukaramakara";
		    
			im1.sprite = Ima[8];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Caribbean Cinemas":
		   
			op1.onClick.AddListener(()=> RseultadoOP(9));
			tx1.text = "Cinema Centro Cibao";
		    
			im1.sprite = Ima[9];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(10));
			tx2.text = "Las Colinas";
		    
			im2.sprite = Ima[10];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Crunchy Pizza":
		   
			op1.onClick.AddListener(()=> RseultadoOP(11));
			tx1.text = "Crunchy Pizza Monumento";
		    
			im1.sprite = Ima[11];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(12));
			tx2.text = "Crunchy Pizza Area UTESA";
		    
			im2.sprite = Ima[11];
		    
		    
		    
		    
			op3.onClick.AddListener(()=> RseultadoOP(13));
			tx3.text = "Crunchy Pizza Tamboril ";
		    
			im3.sprite = Ima[11];
		    
		    
		    
		    
			op4.onClick.AddListener(()=> RseultadoOP(14));
			tx4.text = "Crunchy Pizza La Duarte ";
		    
			im4.sprite = Ima[11];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "Parroquia Nuestra Sra. De La Altagracia":
		   
			op1.onClick.AddListener(()=> RseultadoOP(15));
			tx1.text = "Parroquia Nuestra Sra. De La Altagracia";
		    
			im1.sprite = Ima[12];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
		case "Lovera Bar 2":
		   
			op1.onClick.AddListener(()=> RseultadoOP(16));
			tx1.text = "Lovera Bar 2";
		    
			im1.sprite = Ima[13];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
		    
		    
		case "Jardín Botánico":
		   
			op1.onClick.AddListener(()=> RseultadoOP(17));
			tx1.text = "Jardín Botánico";
		    
			im1.sprite = Ima[14];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
			
		case "Lugar ecologico":
		   
			op1.onClick.AddListener(()=> RseultadoOP(17));
			tx1.text = "Jardín Botánico";
		    
			im1.sprite = Ima[14];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(5));
			
			tx2.text = "Parque Duarte";
		    
			im2.sprite = Ima[5];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;

			
			

		    
		case "Mazucamba Bar & Terraza":
		   
			op1.onClick.AddListener(()=> RseultadoOP(18));
			tx1.text = "Mazucamba Bar & Terraza";
		    
			im1.sprite = Ima[15];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
		case "McDonald's":
		   
			op1.onClick.AddListener(()=> RseultadoOP(19));
			tx1.text = "McDonald's Estrella Sadhalá";
		    
			im1.sprite = Ima[16];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(20));
			tx2.text = "McDonald's Juan Pablo Duarte";
		    
			im2.sprite = Ima[16];
		    
		    
		    
		    
			op3.onClick.AddListener(()=> RseultadoOP(21));
			tx3.text = "McDonald's San Luis ";
		    
			im3.sprite = Ima[16];
		    
		    
		    
		    
			op4.onClick.AddListener(()=> RseultadoOP(22));
			tx4.text = "McDonald's Las Colinas ";
		    
			im4.sprite = Ima[16];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
		case "para para pa pa":
		   
			op1.onClick.AddListener(()=> RseultadoOP(19));
			tx1.text = "McDonald's Estrella Sadhalá";
		    
			im1.sprite = Ima[16];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(20));
			tx2.text = "McDonald's Juan Pablo Duarte";
		    
			im2.sprite = Ima[16];
		    
		    
		    
		    
			op3.onClick.AddListener(()=> RseultadoOP(21));
			tx3.text = "McDonald's San Luis ";
		    
			im3.sprite = Ima[16];
		    
		    
		    
		    
			op4.onClick.AddListener(()=> RseultadoOP(22));
			tx4.text = "McDonald's Las Colinas ";
		    
			im4.sprite = Ima[16];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
			
			
		case "madonal":
		   
			op1.onClick.AddListener(()=> RseultadoOP(19));
			tx1.text = "McDonald's Estrella Sadhalá";
		    
			im1.sprite = Ima[16];
		    
		    
		    
			op2.onClick.AddListener(()=> RseultadoOP(20));
			tx2.text = "McDonald's Juan Pablo Duarte";
		    
			im2.sprite = Ima[16];
		    
		    
		    
		    
			op3.onClick.AddListener(()=> RseultadoOP(21));
			tx3.text = "McDonald's San Luis ";
		    
			im3.sprite = Ima[16];
		    
		    
		    
		    
			op4.onClick.AddListener(()=> RseultadoOP(22));
			tx4.text = "McDonald's Las Colinas ";
		    
			im4.sprite = Ima[16];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
			im5.sprite = Ima[0];
			break;
			
			
			
		case "Bares tranquilos":
		   
			op1.onClick.AddListener(()=> RseultadoOP(23));
			tx1.text = "Morbos drinks lounge";
		    
			im1.sprite = Ima[17];
		    
		    
		    
			// op2.onClick.AddListener(()=> RseultadoOP(1));
			tx2.text = "No hay mas opciones  ";
		    
			im2.sprite = Ima[0];
		    
		    
		    
		    
			// op3.onClick.AddListener(()=> RseultadoOP(1));
			tx3.text = "No hay mas opciones ";
		    
			im3.sprite = Ima[0];
		    
		    
		    
		    
			// op4.onClick.AddListener(()=> RseultadoOP(1));
			tx4.text = "No hay mas opciones ";
		    
			im4.sprite = Ima[0];
		    
		    
		    
			// op5.onClick.AddListener(()=> RseultadoOP(1));
			tx5.text = "No hay mas opciones ";
		    
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
			
		case 3:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[12];
		 
			txt1.text = " Fortaleza San Luis";
			txt2.text = " Fortaleza San Luis está ubicada cerca del río Yaque del Norte en el suroeste de Santiago de los Caballeros , República Dominicana."+
				" El Fuerte fue escenario de varias batallas durante la Guerra de la Restauración .  " +
				" Fortaleza San Luis también ha servido como Cárcel Municipal y más recientemente el fuerte ha sido convertido en Museo";
			ima2.sprite = Galeria[13];
			ima3.sprite = Galeria[14];
			ima4.sprite = Galeria[15];
			ima5.sprite = Galeria[16];
			ima6.sprite = Galeria[17];
		 break;
		 
		case 4:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[18];
			txt1.text = "Catedral Santiago Apóstol";
			txt2.text = "La Catedral de Santiago Apóstol​ o simplemente Catedral de Santiago de los Caballeros"+
				"es el nombre que recibe un templo católico que se encuentra ubicado en la ciudad de Santiago de los Caballeros la capital "+
				"de la provincia de Santiago al norte de la isla La Española y del país caribeño de República Dominicana.​ "+
				"Fue bautizada así en honor de Santiago el Mayor, discípulo de Jesús, hijo de Sebedeo y de Salomé.";
			ima2.sprite = Galeria[19];
			ima3.sprite = Galeria[20];
			ima4.sprite = Galeria[21];
			ima5.sprite = Galeria[22];
			ima6.sprite = Galeria[23];
			break;
			
			
		case 5:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[24];
			txt1.text = "Parque Duarte";
			txt2.text = " El Parque Duarte es el lugar perfecto para tomar un respiro de visitar los puntos de interés de la ciudad."+
				"l parque tiene árboles centenarios y está rodeado de edificios históricos,incluyendo la catedral, el antiguo ayuntamiento "+
			 "y la calle peatonal comercial, Calle del Sol.";
			ima2.sprite = Galeria[25];
			ima3.sprite = Galeria[26];
			ima4.sprite = Galeria[27];
			ima5.sprite = Galeria[28];
			ima6.sprite = Galeria[29];
			break;
			
		case 6:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[30];
			txt1.text = "Centro León";
			txt2.text = "El Centro Cultural Eduardo León Jimenes, también llamado Centro León, es un museo ubicado en Santiago de los Caballeros"+
				"República Dominicana.​ El centro desarrolla programas culturales y educativos que contribuyen a la valoración del arte y la cultura dominicana."+
				"Fue inaugurado en octubre de 2003.​ El museo lleva el nombre de Eduardo León Jimenes, fundador de La Aurora, una empresa tabaquera que dio"+
				" origen al consorcio Grupo León Jiménes.";
			ima2.sprite = Galeria[31];
			ima3.sprite = Galeria[32];
			ima4.sprite = Galeria[33];
			ima5.sprite = Galeria[34];
			ima6.sprite = Galeria[35];
			break;
			
		case 7:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[36];
			txt1.text = "Hazlo Simple";
			txt2.text = " Restaurante con las mejores hamburguesas de Republica Dominica 😎 Sucursales"+
				"en Santiago de los caballeros y Jarabacoa.";
			ima2.sprite = Galeria[37];
			ima3.sprite = Galeria[38];
			ima4.sprite = Galeria[39];
			ima5.sprite = Galeria[40];
			ima6.sprite = Galeria[41];
			break;
			
		case 8:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[42];
			txt1.text = "Kukaramakara";
			txt2.text = " Una de las atracciones turísticas locales, Monumento a los Heroes de la Restauracion, está justo al lado de este"+
				"Sus invitados pueden tomar un famoso laing, unos sabrosos mofongo y un perfectamente elaborado pollo en Kukaramakara."+
				"Prueba su singular flan. No vas a poder olvidar la sensacional cerveza que se puede probar aquí. Este lugar ofrece entre sus"+
				" bebidas un excelente café cortado y un magnífico café americano.";
			ima2.sprite = Galeria[43];
			ima3.sprite = Galeria[44];
			ima4.sprite = Galeria[45];
			ima5.sprite = Galeria[46];
			ima6.sprite = Galeria[47];
			break;
			
		case 9:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[48];
			txt1.text = "Cinema Centro Cibao";
			txt2.text = " Este es un cine que se encuenta en la plaza internacional en santiago y pertenece a las cadena de cine de"+
				"Caribbean Cinemas.";
			ima2.sprite = Galeria[49];
			ima3.sprite = Galeria[50];
			ima4.sprite = Galeria[51];
			ima5.sprite = Galeria[52];
			ima6.sprite = Galeria[53];
			break;
			
		case 10:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[54];
			txt1.text = "Las Colinas";
			txt2.text = " Este es un cine que se encuenta en la Las Colinas en santiago y pertenece a las cadena de cine de"+
				"Caribbean Cinemas.";
			ima2.sprite = Galeria[55];
			ima3.sprite = Galeria[56];
			ima4.sprite = Galeria[57];
			ima5.sprite = Galeria[58];
			ima6.sprite = Galeria[59];
			break;
			
		case 11:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[60];
			txt1.text = "Crunchy Pizza Monumento";
			txt2.text = " Puedes tomarte un sorprendente laing y una perfectamente elaborada pizza en este restaurante." +
				"La comida a domicilio es una de las estupendas opciones de Crunchy Pizza. Sus visitantes dicen que aquí el servicio es eficiente." +
				"Este lugar te permite elegir entre una gran variedad de platos a unos precios adecuados. ";
			ima2.sprite = Galeria[61];
			ima3.sprite = Galeria[62];
			ima4.sprite = Galeria[63];
			ima5.sprite = Galeria[64];
			ima6.sprite = Galeria[65];
			break;
			
		case 12:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[60];
			txt1.text = "Crunchy Pizza Area UTESA";
			txt2.text = " Puedes tomarte un sorprendente laing y una perfectamente elaborada pizza en este restaurante." +
				"La comida a domicilio es una de las estupendas opciones de Crunchy Pizza. Sus visitantes dicen que aquí el servicio es eficiente." +
				"Este lugar te permite elegir entre una gran variedad de platos a unos precios adecuados. ";
			ima2.sprite = Galeria[61];
			ima3.sprite = Galeria[62];
			ima4.sprite = Galeria[63];
			ima5.sprite = Galeria[64];
			ima6.sprite = Galeria[66];
			break;
			
		case 13:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[60];
			txt1.text = "Crunchy Pizza Tamboril";
			txt2.text = " Puedes tomarte un sorprendente laing y una perfectamente elaborada pizza en este restaurante." +
				"La comida a domicilio es una de las estupendas opciones de Crunchy Pizza. Sus visitantes dicen que aquí el servicio es eficiente." +
				"Este lugar te permite elegir entre una gran variedad de platos a unos precios adecuados. ";
			ima2.sprite = Galeria[61];
			ima3.sprite = Galeria[62];
			ima4.sprite = Galeria[63];
			ima5.sprite = Galeria[64];
			ima6.sprite = Galeria[67];
			break;
			
		case 14:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[60];
			txt1.text = "Crunchy Pizza La Duarte";
			txt2.text = " Puedes tomarte un sorprendente laing y una perfectamente elaborada pizza en este restaurante." +
				"La comida a domicilio es una de las estupendas opciones de Crunchy Pizza. Sus visitantes dicen que aquí el servicio es eficiente." +
				"Este lugar te permite elegir entre una gran variedad de platos a unos precios adecuados. ";
			ima2.sprite = Galeria[61];
			ima3.sprite = Galeria[62];
			ima4.sprite = Galeria[63];
			ima5.sprite = Galeria[64];
			ima6.sprite = Galeria[68];
			break;
			
			
			
		case 15:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[69];
			txt1.text = "Parroquia Nuestra Sra. De La Altagracia";
			txt2.text = " Parroquia y Santuario ubicado en la Arquidiócesis de " +
				"Santiago. Fundada en el año 1874";
			ima2.sprite = Galeria[70];
			ima3.sprite = Galeria[71];
			ima4.sprite = Galeria[72];
			ima5.sprite = Galeria[73];
			ima6.sprite = Galeria[74];
			break;
			
		case 16:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[75];
			txt1.text = "Lovera Bar 2";
			txt2.text = " Establecimiento comercial donde se sirven bebidas alcohólicas , no alcohólicas y " +
				"además, sirvan al público mediante precio, aperitivos, tapas, raciones, bocadillos u otros " +
				"alimentos acompañada de música en vivo o dj, Santiago República Dominicana.";
			ima2.sprite = Galeria[76];
			ima3.sprite = Galeria[77];
			ima4.sprite = Galeria[78];
			ima5.sprite = Galeria[79];
			ima6.sprite = Galeria[80];
			break;
			
			
		case 17:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[81];
			txt1.text = "Jardín Botánico";
			txt2.text = " Zona enorme con paredes, plantas exóticas, un arboreto," +
				"un mariposario y senderos para ciclistas y peatones.";
			ima2.sprite = Galeria[82];
			ima3.sprite = Galeria[83];
			ima4.sprite = Galeria[84];
			ima5.sprite = Galeria[85];
			ima6.sprite = Galeria[86];
			break;
			
			
			
		case 18:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[87];
			txt1.text = "Mazucamba Bar & Terraza";
			txt2.text = "Mazucamba Bar & Terraza se encuentra en Santiago de los Caballeros, " +
				"Santiago (República Dominicana). Esta empresa se desempeña en la siguiente " +
				"industria: Bares, pubs y tabernas.";
			ima2.sprite = Galeria[88];
			ima3.sprite = Galeria[89];
			ima4.sprite = Galeria[90];
			ima5.sprite = Galeria[91];
			ima6.sprite = Galeria[92];
	
			
			/*Url="https://goo.gl/maps/wTvwYuyRmGKaebDo8";
			
			mapa.onClick.AddListener(()=> URL.Open(Url));*/
			
					

			break;
			
			
			
			
		case 19:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[93];
			txt1.text = "McDonald's Estrella Sadhalá";
			txt2.text = "Clásica cadena de comida rápida de larga trayectoria conocida " +
				"por sus hamburguesas y papas fritas.";
			ima2.sprite = Galeria[94];
			ima3.sprite = Galeria[95];
			ima4.sprite = Galeria[96];
			ima5.sprite = Galeria[97];
			ima6.sprite = Galeria[98];
			break;
			
		case 20:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[93];
			txt1.text = "McDonald's La Juan Pablo Duarte";
			txt2.text = "Clásica cadena de comida rápida de larga trayectoria conocida " +
				"por sus hamburguesas y papas fritas.";
			ima2.sprite = Galeria[94];
			ima3.sprite = Galeria[95];
			ima4.sprite = Galeria[96];
			ima5.sprite = Galeria[97];
			ima6.sprite = Galeria[99];
			break;
			
			
		case 21:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[93];
			txt1.text = "McDonald's San Luis";
			txt2.text = "Clásica cadena de comida rápida de larga trayectoria conocida " +
				"por sus hamburguesas y papas fritas.";
			ima2.sprite = Galeria[94];
			ima3.sprite = Galeria[95];
			ima4.sprite = Galeria[96];
			ima5.sprite = Galeria[97];
			ima6.sprite = Galeria[100];
			break;
			
		case 22:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[93];
			txt1.text = "McDonald's Las Colinas";
			txt2.text = "Clásica cadena de comida rápida de larga trayectoria conocida " +
				"por sus hamburguesas y papas fritas.";
			ima2.sprite = Galeria[94];
			ima3.sprite = Galeria[95];
			ima4.sprite = Galeria[96];
			ima5.sprite = Galeria[97];
			ima6.sprite = Galeria[101];
			break;
			
			
			
			
		case 23:
			Resultado.SetActive(true);
		 opcioness.SetActive(false);
		 
		 ima1.sprite = Galeria[102];
			txt1.text = "Morbos drinks lounge";
			txt2.text = "Un gran bar 5 estrellas de Santiago de los Caballeros";
			ima2.sprite = Galeria[103];
			ima3.sprite = Galeria[104];
			ima4.sprite = Galeria[105];
			ima5.sprite = Galeria[106];
			ima6.sprite = Galeria[107];
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