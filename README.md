# contactoform
formulario contacto pruebas sed
Servicio contactos https://localhost:5001/api/contactos 
metodos
Get https://localhost:5001/api/contactos Lista contactos
ejemplo respuesta 
 {
        "id": 2,
        "nombre": "Gustavo Santos",
        "email": "gustavosantosr@gmail.com",
        "mensaje": null,
        "documento": 80819446,
        "tipoDocumentoID": 1,
        "tipoDocumento": {
            "id": 1,
            "tipo": "Cédula Ciudadania"
        }
    }
    
Get https://localhost:5001/api/contactos/id Filtra contactos por id
Post https://localhost:5001/api/contactos 
parametros nombre(requerido),email(requerido), mensaje, documento, TipoDocumentoId(requerido) 
ejemplo json 
{
	"nombre" : "Gustavo Santos",
	"email" : "gustavosantosr@gmail.com",
  "mensaje": "ejemplo contacto"
	"documento" : "80819446",
	"tipoDocumentoID":1
  
}

Put https://localhost:5001/api/contactos
parametros id,nombre(requerido),email(requerido), mensaje, documento, TipoDocumentoId(requerido) 
ejemplo json 
{
  "id" : "1",
	"nombre" : "Gustavo Santos",
	"email" : "gustavosantosr@gmail.com",
  "mensaje": "ejemplo contacto"
	"documento" : "80819446",
	"tipoDocumentoID":2
  
}

Servicio tipodocumento https://localhost:5001/api/TiposDocumentos
solo cuenta con el metodo Get https://localhost:5001/api/TiposDocumentos Lista tipos de documento
ejemplo json
{"id":1,"tipo":"Cédula Ciudadania"},{"id":2,"tipo":"Cédula Extrangería"},{"id":3,"tipo":"Tarjeta de Identidad"}

para configurar la base de datos el string de conexion se encuentra en el archivo

appsetings.json
"ConnectionStrings": {
    "DefaultConnectionString": "server=drmonkey.co;database=drmonkey_contactos;uid=drmonkey_drmonkey;password=Admin360!"
  }
  
 la cabecera CORS para ser expuesto el servicio al servidor angular se encuentra en el archivo Startup.cs
 services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder1 => builder1.WithOrigins("http://localhost:4200"));
            });


