<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>VAR_DEMO</title>
</head>
<body>

	<script>
		var a = 1;
		var b = 5;
		var c = a * b;
		var d = a + b;
		var e = a - b;
		var f = a / b;

		document.write("*******Values obtained are********", "<br>");
		document.write(" The value of a is " + a, "<br>");
		document.write(" The value of b is " + b, "<br>");
		document.write(" The value of c is " + c, "<br>");
		document.write(" The value of d is " + d, "<br>");
		document.write(" The value of e is " + e, "<br>");
		document.write(" The value of f is " + f, "<br>");

		for (var i = 1; i <= 15; i++) {
			document.write("value of i : " + i, "<br>");
		}
		var j = 50;
		if (j > 5) {
			alert("less in count");
			alert("please check the number");
		}

	</script>
</body>
</html>