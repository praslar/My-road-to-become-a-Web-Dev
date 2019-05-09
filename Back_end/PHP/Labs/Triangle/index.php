<!DOCTYPE html>
<html>
<head>
	<title>Triangle</title>
	<link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
</head>
<style type="text/css">
	body{
		font-family: 'Montserrat', sans-serif;
		font-size: 25px;
	}
	.title{
		position: absolute;
		margin-left: 500px;
		margin-top: 0px;
		padding: 5px;
		width: 260px;	}

		#lines
		{	
			position: absolute;
			margin-left: 1000px;
		}
		#interation
		{	
			position: absolute;
			width: 260px;
			padding: 5px;
		}
		input
		{
			height: 20px;
			border-radius: 20px;
			width: 100px;
			text-align: center;
		}

		#drawed
		{
			position: absolute;

			margin-left: 500px;
			margin-top: 20px;
			width: 200px;
			height: 200px;
			border-radius: 20px;
			border: 2px solid #000;
			font-size: 18px;
			padding-left: 100px;
			padding-top: 20px;
			padding-bottom: 20px;
		}
		#options button
		{
			margin-top: 150px;
			position: relative;
			width: 200px;
			height: 200px;
			padding: 5px 90px;
			margin-right: 20px;
			margin-left: 165px;
			border-radius: 20px;
			border: 1px solid #000;

		}

	</style>
	<body>
		<form action="index.php" method="post">
			<div id="interation">
				<input type="radio" name="iteration" value="for" required> For </br>
				<input type="radio" name="iteration" value="while"> While </br>
				<input type="radio" name="iteration" value="doWhile"> Do while </br>		
			</div>
			<h1 class="title">Triangles</h1>
			<div id="lines">
				<label>Number of line: </label>
				<input type="number" name="lineNumber" value="6" min=6 max=9 required>
			</div>
			<div id="options">
				<button name="option" value="regular" style="background-image: url('img/regular.png'); background-size: cover; "></button>
				<button name="option" value="rightTop" style="background-image: url('img/rightTop.svg');  background-size: cover;"></button>
				<button name="option" value="right" style="background-image: url('img/rightTriangle.svg'); background-size: cover;"></button>
			</div>
			<div id="drawed">
				<?php
				if(isset($_POST['iteration']))
				{
					$interation = $_POST['iteration'];
				}
				if(isset($_POST['option']))
				{
					$option = $_POST['option'];
				}
				if(isset($_POST['iteration']))
				{
					switch($interation)
					{
						case 'for':
						switch ($option) {
							case 'regular':
							regularFor();
							break;
							case 'rightTop':
							rightTopFor();
							break;
							case 'right':
							rightFor();
							break;		
						}
						break;
						case 'while':
						
						switch ($option) {
							case 'regular':
							regularWhile();
							break;
							case 'rightTop':
							rightTopWhile();
							break;
							case 'right':
							rightWhile();
							break;		
						}

						break;

						case 'doWhile':
						
						switch ($option){
							case 'regular':
							regularDoWhile();
							break;
							case 'rightTop':
							rightTopDoWhile();
							break;
							case 'right':
							rightDoWhile();
							break;
						}

						break;
					}		
				}		
				?>
			</div>
		</form>
		<?php  
		function rightTopFor()
		{
			$row = $_POST['lineNumber'];
			for($i=0;$i<$row;$i++){  
				for($j=$row-$i;$j>0;$j--){  
					echo "* ";  
				}  
				echo "<br>";  
			} 
		}
		
		function rightTopWhile()
		{
			$row = $_POST['lineNumber'];
			$i = 0;
			while ($i < $row) {
				$j = $row-$i;
				while ($j>0) {
					echo "* ";
					$j--;
				}
				$i++;
				echo "<br>";
			}
		}
		function rightTopDoWhile()
		{
			$row = $_POST['lineNumber'];
			$i = 0;
			do {
				$j = $row-$i;
				do {
					echo "* ";
					$j--;
				} while($j>0);
				$i++;
				echo "<br>";
			} while ($i<$row);
		}
		function regularFor()
		{
			$row = $_POST['lineNumber'];
			for ($i=0; $i < $row; $i++) { 
				for ($j=$row-$i; $j > 0 ; $j--) { 
					echo "&nbsp";			
				}
				for ($k=0; $k<=$i; $k++) { 	
					echo "* ";				
				}
				echo "<br>";			
			}
		}
		function regularWhile()
		{
			$row = $_POST['lineNumber'];
			$i = 0;
			
			while ($i < $row) {
				$j = $row-$i;
				while ($j>0) {
					echo "&nbsp";
					$j--;
				}

				$k = 0;

				while ($k<=$i) {
					echo "* ";
					$k++;
				}
				echo "<br>";
				$i++;	
			}
		}
		function regularDoWhile()
		{
		
			$row = $_POST['lineNumber'];
			$i = 0;
			do {
				$j = $row-$i;
				do {
					echo "&nbsp";
					$j--;
				} while($j>0);
				$i++;
				$k = 0;
				do {
					echo "* ";
					$k++;
				} while ( $k<$i);
				echo "<br>";
			} while ($i<$row);
		}

		function rightFor()
		{
				$row = $_POST['lineNumber'];
				for ($i=0; $i < $row ; $i++) { 
					for ($j=0; $j <= $i; $j++) { 
						echo "* ";
					}
					echo "<br>";
				}
		}
		function rightWhile()
		{
				$row = $_POST['lineNumber'];
				$i =0;
				
				while ($i < $row) {
					$j = 0;
					while ($j <= $i) {
						echo "* ";
						$j++;
					}
					$i++;
					echo "<br>";
				}
		}
		function rightDoWhile()
		{
				$row = $_POST['lineNumber'];
				$i = 0;
				do {
					$j =0;
					do {
						echo "* ";
						$j++;
					} while ($j < $i+1);
					$i++;
					echo "<br>";
				} while ($i <= $row);
		}
		?>
	</body>
	</html>
