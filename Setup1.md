# Ejercicio de Markdown
los pasos para instalar el ambiente de desarrollo para aplicaciones de consola en C#.

## Instalación de dotnet core 2.2.
![justmock__net_770](https://user-images.githubusercontent.com/60378108/73618093-dad78a80-45d9-11ea-9421-c82b9796e946.png)
#### 1) Descargar de la pagina ofiacial de Microsoft
![image](https://user-images.githubusercontent.com/60378108/73618262-3eae8300-45db-11ea-88d4-515067551f83.png)

#### 2) Selecciona el SDK para el desarrollo de nuestros programas
![image](https://user-images.githubusercontent.com/60378108/73618314-ad8bdc00-45db-11ea-8a10-95039d76383a.png)

#### 3) Instala el SDK en tu equipo
![image](https://user-images.githubusercontent.com/60378108/73618359-1410fa00-45dc-11ea-822f-981b1215f6f8.png)

#### 4) Verifica la instalacion
![image](https://user-images.githubusercontent.com/60378108/73618386-46baf280-45dc-11ea-8af8-398c8534907d.png)




## Instalación y configuración de Visual Studio Code para C#.
![vscode](https://user-images.githubusercontent.com/60378108/73618098-e7f47980-45d9-11ea-817d-1b1af071b03b.png)

#### 1) Descarga Visual Studios Code
![image](https://user-images.githubusercontent.com/60378108/73618436-9d283100-45dc-11ea-9dec-6e47d76f96de.png)

#### 2)Instalar Visual Studio Code en Windows
Haga doble clic sobre el instalador de Visual Studio Code para poner en marcha el asistente de instalación.
La primera pantalla exige aceptar la licencia de Visual Studio Code para continuar la instalación
![image](https://user-images.githubusercontent.com/60378108/73618490-01e38b80-45dd-11ea-9e0b-d139bf4bb072.png)

#### 3) La segunda pantalla permite elegir el directorio de instalación (por tratarse de la versión User installer, el directorio de instalación está en la carpeta de usuario, no en Archivos de programa):
![image](https://user-images.githubusercontent.com/60378108/73618499-1758b580-45dd-11ea-8ea2-7fc42b162027.png)

#### 4) La tercera pantalla permite elegir el nombre de la carpeta del menú de inicio:
![image](https://user-images.githubusercontent.com/60378108/73618536-3ce5bf00-45dd-11ea-9cf1-c2b52978f602.png)

#### 5) La cuarta pantalla permite elegir algunas tareas adicionales tras la instalación. Personalmente, aconsejo marcar las casillas "Agregar la acción ..."
![image](https://user-images.githubusercontent.com/60378108/73618547-55ee7000-45dd-11ea-879d-68dbe83e933c.png)

#### 6) Finalmente se muestran las opciones elegidas en las pantallas anteriores. Para iniciar la instalación, haga clic en Instalar
![image](https://user-images.githubusercontent.com/60378108/73618563-6b639a00-45dd-11ea-9df0-c6e8264acc26.png)

#### 7) A continuación, se instalará Visual Studio Code
![image](https://user-images.githubusercontent.com/60378108/73618623-bf6e7e80-45dd-11ea-9c31-7c7bdf72d933.png)

#### 8) Una vez completada la instalación, se muestra la pantalla final. Si va a utilizar Git con Visual Studio Code, desmarque la casilla "Ejecutar Visual Studio Code", haga clic en Finalizar e instale Git.
![image](https://user-images.githubusercontent.com/60378108/73618636-d90fc600-45dd-11ea-959c-7a3e9d8832fa.png)

#### 9) Primera ejecución
La primera vez que se abre Visual Studio Code tras la instalación, se muestra una página de bienvenida al programa:
![image](https://user-images.githubusercontent.com/60378108/73618656-f3e23a80-45dd-11ea-9168-73e881d23507.png)



## Instalación de git. conectado a tu cuenta de GitHub y VSC.
![image](https://user-images.githubusercontent.com/60378108/73618684-3dcb2080-45de-11ea-8c39-5e12dccfc0eb.png)

#### 1)Clonar un repositorio de GitHub localmente
Para clonar localmente con Visual Studio Code un repositorio de GitHub:

Cree un directorio donde se guardarán los repositorios
![image](https://user-images.githubusercontent.com/60378108/73618814-09a42f80-45df-11ea-9d5b-05b05bb716a3.png)

#### 2)Abra el directorio en Visual Studio Code (menú Archivo > Abrir carpeta ...):
![image](https://user-images.githubusercontent.com/60378108/73618828-1de82c80-45df-11ea-906d-f91d0e100e73.png)

#### 3)Para clonar el repositorio necesitará dos rutas (el origen y el destino):
La URL de repositorio, que se puede copiar desde el propio repositorio haciendo clic en el botón "Clone or download".
Esta URL es la misma URL que aparece en el navegador pero terminada en .git.

En la captura de ejemplo, la URL de origen es https://github.com/NumaNigerio/test-01.git
![image](https://user-images.githubusercontent.com/60378108/73618905-7ae3e280-45df-11ea-973f-81bd9f0b2017.png)
La ruta del directorio de destino, es decir, la ruta de la carpeta en la que se va a crear la carpeta que contendrá la copia del repositorio. Esta ruta se puede copiar del Explorador de Windows.
En la captura de ejemplo, el directorio de destino es C:\Users\Barto\Documents\LMSGI\Barto\Repositorios
![image](https://user-images.githubusercontent.com/60378108/73618921-94852a00-45df-11ea-90bb-256f1290725e.png)

#### 4)En Visual Studio abra la ventana de comandos con Ctrl+May+p
![image](https://user-images.githubusercontent.com/60378108/73618945-c6968c00-45df-11ea-8047-a18a1699a720.png)

#### 5)Escriba el comando git:clone y pulse Intro
![image](https://user-images.githubusercontent.com/60378108/73618959-dca44c80-45df-11ea-9b4a-052fc09730d1.png)

#### 6)Escriba la URL del repositorio de origen y pulse Intro:
![image](https://user-images.githubusercontent.com/60378108/73618987-065d7380-45e0-11ea-80e0-1398ff8c929c.png)

#### 7) Escriba la ruta del directorio que contendrá la copia y pulse Intro:
![image](https://user-images.githubusercontent.com/60378108/73619017-2725c900-45e0-11ea-90c6-50f918d8ea74.png)

#### 8) En unos segundos se mostrará la carpeta del repositorio clonado en la barra del explorador y se ofrecerá la posibilidad de abrir la carpeta del repositorio clonado. Haga clic en "Abrir repositorio".
![image](https://user-images.githubusercontent.com/60378108/73619032-37d63f00-45e0-11ea-8877-5eb9989bb253.png)

#### 9) Visual Studio Code abrirá la carpeta del repositorio clonado, mostrando su contenido (en el ejemplo, el repositorio contiene únicamente el fichero README.md.
![image](https://user-images.githubusercontent.com/60378108/73619041-4886b500-45e0-11ea-9ccd-ed5e8e3ad442.png)




