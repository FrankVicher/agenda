# agenda

Proyecto demo usando .Net Core 2.2, Entity framework Core y Angular 6


## Instrucciones para ejecutar el proyecto.

1. Despues de clonar, abrir una consola en la carpeta donde se encuentra el archivo agenda.sln y ejecutar el comando **npm install** para instalar los paquetes de node.

2. Crear la base de datos ejecutando el comando **ef dotnet database update**.

## Pasos seguidos para realizar el ejercicio

1. En primer lugar creé las clases referentes al modelo de datos. 
2. Cree la clase DataContext que sirviera como base para agregar las clases nesesarias para la comunicación con la base de datos.
3. Usando Fluent API, agregué la configuración de las propiedades del paso, relaciones y datos semilla que se requieren para construir la base de datos a la clase DataContext.
4. Con cada configuración programada agregué una migración usando el comando **dotnet ef migrations add** y actuelicé la base con el comando **dotnet ef database update**.
5. Programe una clase abstracta para implementar un repositorio genérico (Repository pattern) que sirviera como base para interactuar con la base de datos.
6. Agregué los controladores de los catálogos para obtener los tipos de Correo electrónico y Télefono que ya debian estar en la base de datos.
7. Agregué el Modelo del Contacto para agregar las propiedades necesarias
8. Agregué el Controlador API del Contacto para obtener y almacenar los contactos.
9. Instale la versión más reciente de Angular CLI con el comando **npm intall -g angular-cli**.
10. Dentro de la carpeta de la solución creé una nueva aplicación de angular con el comanoo **ng new agenda**.
11. Moví el contenido de la carpeta que se creo al nivel del archivo de la solución.
12. Actualicé el contenido del archivo *angular-cli.json* para asignar la carpeta *wwwroot* a la variable *outDir*.
13. Generé las clases en TypeScript necesarias con el comando **ng generate class** y posteriormente agregué las propiedades y constructores.
14. Los módulos los cree usando el comando **ng generate module** y después agreque los elementos y logica a su correspondiente clase.
15. Para servicios usé el comando **ng generate service** para después agregar las rutas corresponientes a los controladores API.

## Versiones empleadas

- Angular 6
- Angular CLI 1.0.0-beta-29.3
- node 8.12.2
- .Net framework core 2.1
