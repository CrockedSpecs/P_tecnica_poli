1.	¿Para que funciona el BoxCollider?
	este componente sirve para detectar colisiones en forma de caja/cubo. Esto permite la interacción entre objetos
2.	¿Qué funcionalidad tienen los Prefabs?
	los prefabs permiten guardar objetos reutilizables, para instanciarlos múltiples veces dentro de un juego. Estos objetos guardan los métodos y los atributos de un gameObject, para su posterior uso
3.	¿Qué rol cumplen los enum en C#? 
	es una forma de agrupar valores relacionados bajo un nombre común.
4.	¿Para qué sirven los UnityWebRequest? 
	se usan para relaizar solicitudes de red, como enviar datos a un servidor
5.	¿Para qué sirve un json? 
	Se usan para gaurdar y cargar datos
6.	¿Qué resultados mostraría la consulta SELECT * FROM Simulación?
	todas las columnas y filas de una tabla llamada Simulación
7.	¿Qué resultados mostraría la consulta SELECT COUNT(*) FROM Simulación? 
	Da el numero total de filas presentes en la tabla
8.	¿Cómo sería la consulta si se quiere buscar datos de la tabla Simulación entre un rango de fechas? 
	SELECT * FROM Simulación
	WHERE fecha_columna BETWEEN 'fecha inicial' AND 'fecha final';
9.	¿Como se eliminaría un registro en específico de la tabla Simulación? 
	DELETE FROM Simulación
	WHERE id = id;
10.	¿Como actualizaríamos un registro en específico de la tabla Simulación?
	UPDATE Simulación
	SET columna1 = 'nuevo valor', columna2 = 'otro valor'
	WHERE id = id; 
