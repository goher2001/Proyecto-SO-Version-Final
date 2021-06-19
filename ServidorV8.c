#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <string.h>
#include <pthread.h>
int contador;
int h;
int j2;
int i2;
int color = 2;
int sockets[100];
pthread_t thread[100];

pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
typedef struct {
	char nombre[50];
}Tnombres;
typedef struct {
	Tnombres nombres[100];
	int num;
}Tlista;
Tlista listaN;
void Usuario (char p[50],Tlista *lista)
{
   int i= lista->num;
	p = strtok( NULL, "/");
	sprintf (lista->nombres[i].nombre,"%d/%s/",(h-1),p);
	lista->num++;
	
}
int DameSocket(Tlista *lista, char p[50],char invi[50])
{ //funcion que devuelve el socket buscado
	int i =0;
  int encontrado=0;
  
  p=strtok(NULL,"/");
   while ((i<h)&&(encontrado!=1))
   {
	char *f = strtok (lista->nombres[i].nombre,"/");
	int prueba;
	prueba=atoi(f);
	f= strtok (NULL,"/");
	if (strcmp(p,f)==0)
	{ 
		encontrado=1;
		strcpy (invi,"8/");
		return prueba;
   }
	i++;
	
   }
}
void DameUsuario (Tlista *lista,char p[50],char respuesta[200])
{//funcion que devuelve los usuarios
	int i=0;
	
	while (i<lista->num)
	{
		sprintf(respuesta, "%s%s",respuesta,lista->nombres[i].nombre);
		i++;
	}
}
void QuitarUsuario(Tlista *lista)
{//funcion que quita un usuario de la lista de conectados
	
	lista->num--;
}
void DameJugadores  (char p[50],char respuesta[200], MYSQL *conn)
{
	 //funcion que muestra los jugadores
	 MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta[100];
	int err;
	strcpy(consulta, "SELECT nombre From jugador;");
	err = mysql_query(conn, consulta);
	if (err != 0) {
		sprintf(respuesta, "Error al consultar datos de la base %u %s \n",
				mysql_errno(conn), mysql_error(conn));
		
	}
	
	else
		resultado = mysql_store_result(conn);
	
	row = mysql_fetch_row(resultado);
	strcpy (respuesta, "1/");
	while (row != NULL) {
		
		
		sprintf(respuesta, "%s%s,",respuesta, row[0]);
		
		
		row = mysql_fetch_row(resultado);
	}
};
void DameGanador  (char p[50],char respuesta[200], MYSQL *conn)
{//funcion que ense�a las partidas ganadas por un jugador
	char nombre[30];
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	int err;
	p = strtok( NULL, "/");
	strcpy (nombre, p);
	
	char consulta[100];
	sprintf(consulta,"SELECT id,fecha FROM partida WHERE ganador='%s';",nombre);
	
	mysql_query(conn, consulta);
	err = mysql_query(conn, consulta);
	
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	strcpy(respuesta,"2/");
	
	if (row == NULL)
		strcpy(respuesta, "No se han obtenido datos en la consulta\n");
	else {
	     
	    	while (row != NULL)
	    	{
		    	sprintf(respuesta, "%s Partida:%s Fecha:%s, ", respuesta, row[0], row[1]);
		    	row = mysql_fetch_row(resultado);
	    	}
	}
};
void Consulta3  (char p[50],char respuesta[200], MYSQL *conn)
	{
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta[100];
	strcpy(consulta, "SELECT id,ganador FROM partida;");
	
	err = mysql_query(conn, consulta); 
	if (err != 0) {
		sprintf(respuesta, "Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		
	}
	else 
	{
		resultado = mysql_store_result(conn);
		
		row = mysql_fetch_row(resultado);
		
		
		if (row == NULL)
			strcpy(respuesta, "3/No se han obtenido datos en la consulta");
		else 
		{    strcpy(respuesta,"3/");
			while (row != NULL)
			{
				sprintf(respuesta, "%s Partida: %s Ganador: %s,  ", respuesta, row[0], row[1]);
				row = mysql_fetch_row(resultado);
				
			}
			
		}
	}
};
void Logging (char p[50],char respuesta[200], MYSQL *conn)
{
//funcion para loggearse al sistema
	char nombre [30];
	int pwd;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	p = strtok( NULL, "/");
	strcpy (nombre, p);
	// Ya tenemos el nombre
	p = strtok(NULL, "/");
	pwd = atoi(p);
	
	char consulta[100];
	sprintf ( consulta, "SELECT * FROM jugador WHERE nombre='%s' AND contrase�a='%d';",nombre, pwd);
	
	err = mysql_query(conn, consulta);
	if (err != 0) {
		strcpy(respuesta, "Error al consultar datos de la base");
			
		
	}
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	if (row == NULL)
		strcpy(respuesta, "4/El nombre de usuario y contrase�a es incorrecto");
	else
		strcpy(respuesta, "4/Login correcto");

	
}

void Registro  (char p[50],char respuesta[200], MYSQL *conn)
	{
	// funcion que permite el registro
	char nombre [30];
	int pwd;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	p = strtok( NULL, "/");
	strcpy (nombre, p);
	// Ya tenemos el nombre
	p = strtok(NULL, "/");
	pwd = atoi(p);
	char consulta[100];
	sprintf (consulta, "INSERT INTO jugador VALUES('%s',%d);",nombre,pwd);
	
	err = mysql_query(conn, consulta);
	if (err != 0) {
		strcpy(respuesta, "5/Error al introducir datos la base");
		
		
	}
	else{
		
		strcpy(respuesta, "5/Registro correcto");
	}
}
void Invitacion (char p[50])
{
	//en esta funcion comprobamos si todos los invitados han aceptado 
	//o rechazado la propuesta
	p = strtok( NULL, "/");
	int result = atoi(p);
	
	if (result == 1)
	{
	
		i2++;
		j2++;
	}
	if (result==0)
	{
		i2++;
	}
	if (result ==2)
	{
		i2++;
	}
	if((i2==(h-1))&&(j2==(h-1)))
	{
		pthread_mutex_lock( &mutex);
		char notificacion[100];
		strcpy(notificacion, "9/Se juega la partida");
		pthread_mutex_unlock( &mutex);
		
		int T=0;
		while (T<h)
		{
			write (sockets[T],notificacion, strlen(notificacion));
			T++;
		}
		
	}
	else if((i2==(h-1))&&(j2!=(h-1)))
	{
		
		pthread_mutex_lock( &mutex);
		char notificacion[100];
		strcpy(notificacion, "13/No se juega la partida");
		pthread_mutex_unlock( &mutex);
		
		
		int T=0;
		while (T<h)
		{
			write (sockets[T],notificacion, strlen(notificacion));
			T++;
		}
	}	
	else{
			char notificacion[10];
			int T=0;
			strcpy (notificacion,"12/");
			while (T<h)
			{
			write (sockets[T],notificacion, strlen(notificacion));
			T++;
			}
		}
	
	
}
void Eliminar (char p[50],char respuesta[200], MYSQL *conn)
{
	
	char nombre [30];
	int pwd;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	p = strtok( NULL, "/");
	strcpy (nombre, p);
	// Ya tenemos el nombre
	p = strtok(NULL, "/");
	pwd = atoi(p);
	char consulta[100];
	sprintf ( consulta, "DELETE FROM jugador WHERE nombre='%s' AND contrase�a='%d';",nombre, pwd);
	err = mysql_query(conn, consulta);
	if (err != 0) {
		strcpy(respuesta, "10/No se pudo eliminar");
		
		
	}
	
	else
		strcpy(respuesta, "10/Eliminacion completada");
	
	
}

void *AtenderCliente (void *socket)
{
	
	MYSQL *conn;
	conn = mysql_init(NULL);
	if (conn==NULL){
		printf("Error al crear la conexion: %u %s \n", mysql_errno(conn), mysql_error(conn));
		
	}
	conn = mysql_real_connect (conn, "localhost", "root", "mysql","parchis",0, NULL, 0);
	if (conn==NULL){
		printf ("Error al inicializar la conexion: %u %s \n", mysql_errno(conn), mysql_error(conn));
		
	}
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn = *s;
	
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		peticion[ret]='\0';
		
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		
		int codigo =  atoi (p);
		// Ya tenemos el c?digo de la petici?n
		char nombre[20];
		int pwd;
		int pwds;
		
		if (codigo == 0) //peticion de desconexi?n
		{	
			QuitarUsuario(&listaN);
			pthread_mutex_lock( &mutex);
			char notificacion[100];
			strcpy(notificacion, "7/");
			DameUsuario(&listaN,p,notificacion);
			pthread_mutex_unlock( &mutex);
			//notificar a todos los clientes
			
			int j=0;
			while (j<h)
			{
				write (sockets[j],notificacion, strlen(notificacion));
				j++;
			}
			terminar = 1;
		}
		if (codigo == 1)
		{//consulta de mostrar jugadores 
			DameJugadores  (p, respuesta, conn);
		}
		
		
		if (codigo == 2) //consulta partidas ganadas
		{
			DameGanador (p, respuesta,conn);
		}
		
		if (codigo ==3) //consulta de resultados
		{
			
			Consulta3 (p, respuesta,conn);
			
		}
		
		if (codigo == 4)//logging
		{ 
			Logging (p, respuesta,conn);
	    	
		}
		if (codigo==5)//registro
		{
			Registro (p, respuesta,conn);
		}
		
		if (codigo==8)
		{
			DameUsuario(&listaN,p,respuesta);
		}
		if (codigo == 9) //envia invitaciones 
		{
			pthread_mutex_lock( &mutex);
			char invi[20];
			int code;
			code = DameSocket(&listaN,p,invi);
			printf ("%d\n",code);
			pthread_mutex_unlock( &mutex);
			sprintf (invi,"%s%d",invi,color);
			color++;
			printf ("%s\n",invi);
			j2=0;
			i2=0;
				write (sockets[code],invi, strlen(invi));
				
			
		}
		if (codigo ==10) //comprueba si se juega o no
		{
			Invitacion(p);
		}
		if (codigo==11) //darse de baja
		{
			Eliminar(p,respuesta,conn);
			
		}
		if (codigo == 12) //tirar el dado
		{
			int dado;
			p = strtok (NULL,"/");
			dado = atoi(p);
			int j=0;
			char notificacion [100];
			sprintf (notificacion,"14/%d",dado);
			while (j<h)
			{
				write (sockets[j],notificacion, strlen(notificacion));
				j++;
			}
			
		}
		if (codigo==13) //recibe localizacion de la ficha y la comparte
		{
			int ficha;
			p = strtok (NULL,"/");
			int X = atoi(p);
			p = strtok (NULL,"/");
			int Y = atoi(p);
			p = strtok (NULL,"/");
			ficha= atoi(p);
			int j=0;
			char notificacion [100];
		
			sprintf (notificacion,"15/%d/%d/%d",ficha,X,Y);
			while (j<h)
			{
				write (sockets[j],notificacion, strlen(notificacion));
				j++;
			}
			
		}
		if(codigo==7) //a�adir conectado
		{ 
			Usuario (p,&listaN);
			pthread_mutex_lock( &mutex);
			char notificacion[100];
			strcpy(notificacion, "7/");
			
			DameUsuario(&listaN,p,notificacion);
			pthread_mutex_unlock( &mutex);
			//notificar a todos los clientes
			
			int j=0;
			while (j<h)
			{
				write (sockets[j],notificacion, strlen(notificacion));
				j++;
			}
		}
		if (codigo !=0)
		{
			//enviar respuesta
			printf ("Respuesta: %s\n", respuesta);
	
			write (sock_conn,respuesta, strlen(respuesta));
			
		
			
		}
		
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}
int main(int argc, char *argv[])
{ 
	 
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf ("Error creant socket");
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family= AF_INET;
	serv_adr.sin_port=htons(9230);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf ("Error en el listen");
	
	
	
	h=0;
	for (;;){
		printf ("Escuchando\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		sockets[h]=sock_conn;
		pthread_create (&thread[h], NULL, AtenderCliente,&sockets[h]);
		h++;
	}
}


