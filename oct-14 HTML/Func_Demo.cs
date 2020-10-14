<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>DEMO</title>
	<style>
		body
		{
			background-color:darkseagreen;
		}
	</style>
</head>
<body id="body1">

	<h1 id="hid" align="center">KIDS</h1>
	<h2 id="hid2">Welcome</h2>
	<img src="kid.jpg" width="250" height="250" id="img1" />
	<button onclick="f1()">Click ME</button>
	<button onclick="changecontent()">Click here to change h1 content</button>
	<button onclick="changebackground()">click here to change background</button>
	<button onclick="hide()">click here to hide the content</button>
	<br />
	<button>SUBMIT</button>

	<script type="text/javascript">
		function f1() {
			window.alert("Hi");
		}
		function changeimagesize() {
			document.getElementById('img1').width = '250';
		}
		function changethebackground() {
			document.getElementById('body1').style.backgroundColor = 'green';
		}
		function hide() {
			document.getElementById('hid').style.display = 'none';
		}
	</script>
</body>
</html>