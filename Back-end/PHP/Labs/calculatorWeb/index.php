<!DOCTYPE html>
<html>
<head>
	<title>PHP Programming Crash Course</title>
	<link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="structure.css">
</head>
<body>
	<?php
	if (isset($_POST['count'])) {
		$num1 = $_POST['num1'];
		$num2 = $_POST['num2'];
		$operation = $_POST['operation'];
switch ($operation) {
	case 'add':
		$result = $num1+$num2;
		break;
	case 'sub':
		$result = $num1-$num2;
		break;
	case 'mul':
		$result = $num1*$num2;
		break;
	case 'div':
		$result = $num1/$num2;
		break;
		}	}
	  ?>
	<div class="calculator">
		<h3 class="title">CALCULATOR</h3>
		<form method="post" action="index.php">
			<input type="number" autocomplete="off" placeholder="Enter the first number" class="num" name="num1" required>
			<input type="number"  autocomplete="off" placeholder="Enter the second number" class="num" name="num2" required>
			<select class="opt" name='operation'>
				<option value="add">+</option>
				<option value="sub">-</option>
				<option value="mul">*</option>
				<option value="div">/</option>
			</select>
			<input type="submit" value="=" name="count" class="button" >
		</form>
		<?php if(isset($_POST['count'])){ ?>
			<input type="number" value="<?php echo $result; ?>" class="num">
		<?php } else{ ?>
			<input type="number" value="0" class="num">
		<?php } ?>
	</div>
</body>
</html>