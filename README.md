# CongresoForm
Visual studio application for a congress.

# Instrucciones
Utilizando la base de datos que elaboraste con Oracle en la tarea no. 4 (ej. 5: congresos, ej. 6: cadenas comerciales o ej. 7: instituciones educativas, respectivamente) desarrolla una aplicación Visual C# que contenga lo que se indica a continuación:

1. Una forma que contenga la barra principal de menús para seleccionar y llamar a todos los formas que se piden en cada uno de los puntos descritos a continuación.
2. Una forma que contenga dos botones para ejecutar la función y el procedimiento almacenados que elaboraste para la base de datos. Nota: si la función regresa un valor con decimales, deberás hacer el cambio que se describe en la nota que está al final de la página 6 de C3ConexCS_BD.pdf. 

Elabora adicionalmente las siguientes formas (junto con una forma que permita ver que se hizo bien la inserción en el caso del formulario 6): 

3. Una forma para que dado el nombre de un autor (a través de un combo box) y una fecha (por medio de un DateTimePicker), se muestren todos los artículos que ha presentado (o presentará) a partir de esa fecha, detallando por cada artículo: co-autores, nombre de la institución en que trabaja el autor, si el artículo fue financiado o no, nombre del congreso y fecha de presentación, y total de congresos en que se ha presentado (incluidos en los que se presentará). Emplea únicamente los objetos no gráficos de ADO.Net (o sea, la biblioteca de GestorBD). 
 
4. Una forma única para registrar un artículo que se presentará en un congreso (considera que tanto el artículo como el congreso ya existen). Toma en cuenta que los datos a dar de alta usarán o afectarán varias tablas. Considera que al hacer el registro de alta, hay que guardar la fecha y hora de presentación, quién lo presentará, etc.; esto es, en la forma deben aparecer todos aquellos campos, y no más, requeridos para hacer la operación. Emplea únicamente los objetos no gráficos de ADO.Net.

En todos los casos, emplea ComboBox, ListBox o DataGrid, para seleccionar la mayor parte de los datos que ya existan en la base de datos; sólo usa TextBox en aquellos casos, estrictamente necesarios, en los que haya que teclear nuevos datos. En los casos no evidentes indica, entre paréntesis (en la ventana), la manera (formato, rango de valores, etc.) en que hay que dar los datos. También habilita/deshabilita botones, cajas, etc., para guiar al usuario por el camino que debe seguir para dar los datos. 
 
Ninguna de las consultas o formas deben aparecer vacíos. El programa debe estar bien documentado y estructurado. Las formas deben ser "amigables" para el usuario. Organiza los archivos de la solución en carpetas. 
 
Envía la aplicación (comprimida) por email al profesor (flopez@itam.mx). Copia completamente la carpeta raíz del proyecto, no sólo el contenido de la misma. 
 
Fecha límite de entrega: miércoles 20 de marzo, a las 22 hrs. (máximo). 
