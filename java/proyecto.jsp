<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Proyecto 319</title>
</head>
<body>
<h2>Fibonacci</h2>

<form action = "resultado.jsp" method = "GET">
	n: <input type = "number" name = "n_fibo">
    <br />
    <input type = "submit" value = "Mostrar" />
</form>
<br>
<h2>Calculadora</h2>
<br>

<form action = "resultado.jsp" method = "GET">
	a: <input type = "number" name = "a_calcu">
    <br />
    b: <input type = "number" name = "b_calcu">
    <br />
    operación(suma, resta, multi o divi): <input type = "text" name = "op_calcu">
    <br />
    <input type = "submit" value = "Calcular" />
</form>

<br>
<h2>Calculadora de matrices</h2>
<br>

<form action = "resultado.jsp" method = "GET">
	<h3>Matriz 1</h3>
	[0,0]: <input type = "number" name = "mat100">
    <br />
	[0,1]: <input type = "number" name = "mat101">
    <br />
	[1,0]: <input type = "number" name = "mat110">
    <br />
	[1,1]: <input type = "number" name = "mat111">
    <br />
    <h3>Matriz 2</h3>
    <br>
	[0,0]: <input type = "number" name = "mat200">
    <br />
	[0,1]: <input type = "number" name = "mat201">
    <br />
	[1,0]: <input type = "number" name = "mat210">
    <br />
	[1,1]: <input type = "number" name = "mat211">
    <br />
    operación(suma, resta o multi): <input type = "text" name = "op_matrices">
    <br />
    <input type = "submit" value = "Calcular" />
</form>


<br>
<h2>Criba de eratostenes</h2>
<br>

<form action = "resultado.jsp" method = "GET">
	n: <input type = "number" name = "n_criba">
    <br />
    <input type = "submit" value = "Mostrar" />
</form>

<br>
<h2>Separar lista en pares e impares</h2>
Ingresar los datos separados por un espacio
<form action = "resultado.jsp" method = "GET">
	lista: <input type = "text" name = "lista">
    <br />
    <input type = "submit" value = "Separar" />
</form>
<br>

</body>
</html>