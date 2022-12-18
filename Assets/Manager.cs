using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


 public class Manager: MonoBehaviour
 {
 	
 	
	 public GameObject Holder, PaginaLugares,PaginaLugares2,PaginaLugares3,PaginaLugares4,Categorias1,Categorias2,
		 PaginaLugares5,Categorias3,PaginaLugares6,PaginaLugares7,PaginaLugares8,PaginaLugares9,PaginaLugares10,
		 PaginaLugares11,busqueda;
	 
	 public Button Lugar1, Lugar2, Lugar3,Lugar4,categoria1,historia,categoria2,entretenimiento,categoria3,gastronomia, 
		 butonAtras,butonAtras2,butonAtras3,butonAtras4,butonAtras5,hist1,hist2,hist3,butonAtras6,hist4,hist5,hist6,
		 butonAtras7,butonAtras8,hist7,butonAtras9,butonAtras10,hist8,hist9,butonAtras11,hist10,butonAtras12,
		 butonAtras13,hist11,butonAtras14,hist14,butonAtras15;
	 
	 public Sprite [] lugarlImg;
	 
	 public Image Hijogalerial,Hijogaleria2,Hijogaleria3,Hijogaleria4,Hijogaleria5,Hijogaleria6,Hijogaleria7,Hijogaleria8,
		 Hijogaleria9,Hijogaleria10,Hijogaleria11,Hijogaleria12,Hijogaleria13,Hijogaleria14,Hijogaleria15,Hijogaleria16,
		 Hijogaleria17,Hijogaleria18,Hijogaleria19,Hijogaleria20,Hijogaleria21,Hijogaleria22,Hijogaleria23,Hijogaleria24,
		 Hijogaleria25,Hijogaleria26,Hijogaleria27,Hijogaleria28,Hijogaleria29,Hijogaleria30,Hijogaleria31,Hijogaleria32,
		 Hijogaleria33,Hijogaleria34,Hijogaleria35,Hijogaleria36,Hijogaleria37,Hijogaleria38,Hijogaleria39,Hijogaleria40,
		 Hijogaleria41,Hijogaleria42,Hijogaleria43,Hijogaleria44;
	 
	 public TMP_Text Descripcion,Nombre,Descripcion2,Nombre2,Descripcion3,Nombre3,Descripcion4,Nombre4,Descripcion5,
		 Nombre5,Descripcion6,Nombre6,Descripcion7,Nombre7,Descripcion8,Nombre8,Descripcion9,Nombre9,Descripcion10,
		 Nombre10,Descripcion11,Nombre11;
	 
	 
	 protected void Start()
  {//apggola pagina
  	
   PaginaLugares.SetActive(false);

   //acciones de los botones
	  butonAtras.onClick.AddListener(backfn);
	  butonAtras2.onClick.AddListener(backfn);
	  butonAtras3.onClick.AddListener(backfn);
	  butonAtras4.onClick.AddListener(backfn);
	  butonAtras5.onClick.AddListener(backfn);
	  butonAtras6.onClick.AddListener(backfn);
	  butonAtras7.onClick.AddListener(backfn);
	  butonAtras8.onClick.AddListener(backfn);
	  butonAtras9.onClick.AddListener(backfn);
	  butonAtras10.onClick.AddListener(backfn);
	  butonAtras11.onClick.AddListener(backfn);
	  butonAtras12.onClick.AddListener(backfn);
	  butonAtras13.onClick.AddListener(backfn);
	  butonAtras14.onClick.AddListener(backfn);
	
	  Lugar1.onClick.AddListener(()=> lugarfn(1));
   Lugar2.onClick.AddListener(()=> lugarfn(2));
   Lugar3.onClick.AddListener(()=> lugarfn(3));
   Lugar4.onClick.AddListener(()=> lugarfn(4));
   categoria1.onClick.AddListener(()=> lugarfn(5));
   historia.onClick.AddListener(()=> lugarfn(5));
   categoria2.onClick.AddListener(()=> lugarfn(6));
   entretenimiento.onClick.AddListener(()=> lugarfn(6));
   categoria3.onClick.AddListener(()=> lugarfn(8));
   gastronomia.onClick.AddListener(()=> lugarfn(8));
  }

	 // funcion para mostrar los lugares
  void lugarfn(int lugar)
	 { 
	 	
		 Categorias1.SetActive(false);
		 busqueda.SetActive(false);
		 Categorias2.SetActive(false);
		 Categorias3.SetActive(false);
		
	
		 switch(lugar) 
		 {
		 case 1:
		 PaginaLugares.SetActive(true);
		 Nombre.text = " Monumento de la restauracion";
			 Descripcion.text = " Monumento a los Héroes de la Restauración conocido también como el Monumento de Santiago está erigido en"+
			 " la ciudad de Santiago de los Caballeros para conmemorar el 100 aniversario de la independencia del país. Originalmente fue " +
			 "nombrado como el Monumento de la Paz de Trujillo y el mismo sería parte de una serie de obras de distintas índoles construidas"+
			 "en Santiago de los Caballeros en la misma época.";
			 Hijogalerial.sprite = lugarlImg[0];
		 Hijogaleria2.sprite = lugarlImg[1];
		 Hijogaleria3.sprite = lugarlImg[2];
		 Hijogaleria4.sprite = lugarlImg[3];
		 break; 

		 case 2:
			 PaginaLugares2.SetActive(true);
			 Nombre2.text = " Fortaleza San Luis";
			 Descripcion2.text = " Fortaleza San Luis está ubicada cerca del río Yaque del Norte en el suroeste de Santiago de los Caballeros , República Dominicana."+
				 " El Fuerte fue escenario de varias batallas durante la Guerra de la Restauración .  " +
				 " Fortaleza San Luis también ha servido como Cárcel Municipal y más recientemente el fuerte ha sido convertido en Museo";
			 Hijogaleria5.sprite = lugarlImg[4];
			 Hijogaleria6.sprite = lugarlImg[5];
			 Hijogaleria7.sprite = lugarlImg[6];
			 Hijogaleria8.sprite = lugarlImg[7];
		 break;
		 
		 case 3:
			 PaginaLugares3.SetActive(true);
			 Nombre3.text = " Estadio Cibao";
			 Descripcion3.text = "El Estadio Cibao es un estadio de béisbol en Santiago de los Caballeros, República Dominicana."+
			 " Se utiliza para los juegos de béisbol teniendo de anfitriones a las Águilas Cibaeñas, equipo perteneciente a la Liga Dominicana de Béisbol." +
			 " l estadio se inauguró el 25 de octubre de 1958 y fue construido por el ingeniero Bienvenido Martínez Brea.";
			 Hijogaleria9.sprite = lugarlImg[8];
			 Hijogaleria10.sprite = lugarlImg[9];
			 Hijogaleria11.sprite = lugarlImg[10];
			 Hijogaleria12.sprite = lugarlImg[11];
		 break;
	 
	 
	 case 4:
		 PaginaLugares4.SetActive(true);
		 Nombre4.text = " Jardín Botánico de Santiago";
		 Descripcion4.text = " El Jardín Botánico de Santiago es el más grande parque urbano de la región, un espacio natural concebido para toda la familia."+
				 " La entrada es libre, todos los días. Ideal para caminatas, disfrutar la biodiversidad, picnics familiares, educación ambiental  " +
				 " , sesiones fotográficas y actividades al aire libre.";
		 Hijogaleria13.sprite = lugarlImg[12];
		 Hijogaleria14.sprite = lugarlImg[13];
		 Hijogaleria15.sprite = lugarlImg[14];
		 Hijogaleria16.sprite = lugarlImg[15];
		 break;
		 
		 case 5:
			 Categorias1.SetActive(true);
			 hist1.onClick.AddListener(()=> lugarfn(1));
			 hist2.onClick.AddListener(()=> lugarfn(2));
			 hist3.onClick.AddListener(()=> lugarfn(9));
			 hist8.onClick.AddListener(()=> lugarfn(10));
			 hist10.onClick.AddListener(()=> lugarfn(11));
			 break;
			 
		 case 6:
			 Categorias2.SetActive(true);
			 hist4.onClick.AddListener(()=> lugarfn(3));
			 hist5.onClick.AddListener(()=> lugarfn(4));
			 hist6.onClick.AddListener(()=> lugarfn(12));
			 hist9.onClick.AddListener(()=> lugarfn(10));
			
			 break;
			 
		 case 7:
			 PaginaLugares5.SetActive(true);
			 Nombre5.text = " Hazlo Simple";
			 Descripcion5.text = " Restaurante con las mejores hamburguesas de Republica Dominica 😎 Sucursales"+
				 "en Santiago de los caballeros y Jarabacoa.";
			 Hijogaleria17.sprite = lugarlImg[16];
			 Hijogaleria18.sprite = lugarlImg[17];
			 Hijogaleria19.sprite = lugarlImg[18];
			 Hijogaleria20.sprite = lugarlImg[19];
			 break;
			 
		 case 8:
			 Categorias3.SetActive(true);
			 hist7.onClick.AddListener(()=> lugarfn(7));
			 hist11.onClick.AddListener(()=> lugarfn(13));
			 hist14.onClick.AddListener(()=> lugarfn(14));

			 break;
			 
		 case 9:
			 PaginaLugares6.SetActive(true);
			 Nombre6.text = " Parque Duarte";
			 Descripcion6.text = " El Parque Duarte es el lugar perfecto para tomar un respiro de visitar los puntos de interés de la ciudad."+
			  "l parque tiene árboles centenarios y está rodeado de edificios históricos,incluyendo la catedral, el antiguo ayuntamiento "+
			 "y la calle peatonal comercial, Calle del Sol.";
			 Hijogaleria21.sprite = lugarlImg[20];
			 Hijogaleria22.sprite = lugarlImg[21];
			 Hijogaleria23.sprite = lugarlImg[22];
			 Hijogaleria24.sprite = lugarlImg[23];
			 break;
			 
		 case 10:
			 PaginaLugares7.SetActive(true);
			 Nombre7.text = " Centro León";
			 Descripcion7.text = "El Centro Cultural Eduardo León Jimenes, también llamado Centro León, es un museo ubicado en Santiago de los Caballeros"+
			  "República Dominicana.​ El centro desarrolla programas culturales y educativos que contribuyen a la valoración del arte y la cultura dominicana."+
				 "Fue inaugurado en octubre de 2003.​ El museo lleva el nombre de Eduardo León Jimenes, fundador de La Aurora, una empresa tabaquera que dio"+
				 " origen al consorcio Grupo León Jiménes.";
			 Hijogaleria25.sprite = lugarlImg[24];
			 Hijogaleria26.sprite = lugarlImg[25];
			 Hijogaleria27.sprite = lugarlImg[26];
			 Hijogaleria28.sprite = lugarlImg[27];
			 break;
			 
		 case 11:
			 PaginaLugares8.SetActive(true);
			 Nombre8.text = "Catedral Santiago Apóstol";
			 Descripcion8.text = "La Catedral de Santiago Apóstol​ o simplemente Catedral de Santiago de los Caballeros"+
			  "es el nombre que recibe un templo católico que se encuentra ubicado en la ciudad de Santiago de los Caballeros la capital "+
				 "de la provincia de Santiago al norte de la isla La Española y del país caribeño de República Dominicana.​ "+
				 "Fue bautizada así en honor de Santiago el Mayor, discípulo de Jesús, hijo de Sebedeo y de Salomé.";
			 Hijogaleria29.sprite = lugarlImg[28];
			 Hijogaleria30.sprite = lugarlImg[29];
			 Hijogaleria31.sprite = lugarlImg[30];
			 Hijogaleria32.sprite = lugarlImg[31];
			 break;
			 
		 case 12:
			 PaginaLugares9.SetActive(true);
			 Nombre9.text = "Cinema Centro Cibao";
			 Descripcion9.text = "Este es un cine que se encuenta en la plaza internacional en santiago y pertenece a las cadena de cine de"+
				 "Caribbean Cinemas";
			 Hijogaleria33.sprite = lugarlImg[32];
			 Hijogaleria34.sprite = lugarlImg[33];
			 Hijogaleria35.sprite = lugarlImg[34];
			 Hijogaleria36.sprite = lugarlImg[35];
			 break;
			 
		 case 13:
			 PaginaLugares10.SetActive(true);
			 Nombre10.text = "Kukaramakara";
			 Descripcion10.text = "Una de las atracciones turísticas locales, Monumento a los Heroes de la Restauracion, está justo al lado de este"+
				 "Sus invitados pueden tomar un famoso laing, unos sabrosos mofongo y un perfectamente elaborado pollo en Kukaramakara."+
				 "Prueba su singular flan. No vas a poder olvidar la sensacional cerveza que se puede probar aquí. Este lugar ofrece entre sus"+
				 " bebidas un excelente café cortado y un magnífico café americano.";
			 Hijogaleria37.sprite = lugarlImg[36];
			 Hijogaleria38.sprite = lugarlImg[37];
			 Hijogaleria39.sprite = lugarlImg[38];
			 Hijogaleria40.sprite = lugarlImg[39];
			 break;
			 
		 case 14:
			 PaginaLugares11.SetActive(true);
			 Nombre11.text = "NOAH Restaurant & Lounge";
			 Descripcion11.text = "Se requieren máscaras, barbijos o tapabocas para el personal en áreas públicas"+
				 " Control diario de temperatura y de síntomas para el personal.";
			 Hijogaleria41.sprite = lugarlImg[40];
			 Hijogaleria42.sprite = lugarlImg[41];
			 Hijogaleria43.sprite = lugarlImg[42];
			 Hijogaleria44.sprite = lugarlImg[43];
			 break;
 }
	 
	 } 
	 
	 void backfn()
	 {
		 PaginaLugares.SetActive(false);
		 PaginaLugares2.SetActive(false);
		 PaginaLugares3.SetActive(false);
		 PaginaLugares4.SetActive(false);
		 PaginaLugares5.SetActive(false);
		 Categorias1.SetActive(false);
		 Categorias2.SetActive(false);
		 Categorias3.SetActive(false);
		 PaginaLugares6.SetActive(false);
		 PaginaLugares7.SetActive(false);
		 PaginaLugares8.SetActive(false);
		 PaginaLugares9.SetActive(false);
		 PaginaLugares10.SetActive(false);
		 PaginaLugares11.SetActive(false);
		 busqueda.SetActive(true);
     
	 }
	

}

