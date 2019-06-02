<!DOCTYPE html>
<html>
<head>
	<title>ATM Simulation</title>
	<link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="structure.css">
	<script type="text/javascript">
		function clr() 
		{ 
			document.getElementById("result").value = "" 
		} 
		function dis(val) 
		{ 
			document.getElementById("result").value+=val 
		}            
	</script>
</head>
<body>
	<div class="menu">
		<ul style="list-style: none; padding: 0px;">
			<li>
				<a>Cash WithDrawal</a>
			</li>
			<li>
				<a href="../home/home.html">Home</a>
			</li>
		</ul>
	</div>
	<div class="atm">
		<form method="post" action="index.php">
			<table class="inputMoney">
				<tr> 
					<td colspan="3"><input id="result" type="number" placeholder="Enter the money..." class="num" name="input" min="1000" required></td>
				</tr> 
				<tr> 
					<!-- dis("1") will call function dis to display value -->
					<td><input type="button" value="1" onclick="dis('1')"/> </td> 
					<td><input type="button" value="2" onclick="dis('2')"/> </td> 
					<td><input type="button" value="3" onclick="dis('3')"/> </td>  
				</tr> 
				<tr> 
					<td><input type="button" value="4" onclick="dis('4')"/> </td> 
					<td><input type="button" value="5" onclick="dis('5')"/> </td> 
					<td><input type="button" value="6" onclick="dis('6')"/> </td> 
				</tr> 
				<tr> 
					<td><input type="button" value="7" onclick="dis('7')"/> </td> 
					<td><input type="button" value="8" onclick="dis('8')"/> </td> 
					<td><input type="button" value="9" onclick="dis('9')"/> </td> 
				</tr> 
				<tr> 
					<!-- clr() function will call clr to clear all value -->
					<td><input type="button" value="C" onclick="clr()"/> </td> 
					<td><input type="button" value="0" onclick="dis('0')"/> </td> 
					
					<td><input type="submit" value="Draw" name="count" class="button" ></td>
				</tr> 
				<tr> 
					<td colspan="3"><span class="label">Displays the entered money in minimum amount of bills. </span></td>
				</tr> 
			</table>
			<table class="display">
				<tr>
					<th style="width: 100px; text-align: left; border-bottom: solid 2px #fff; ">Mệnh giá</th>
					<th style="text-align: left; border-bottom: solid 2px #fff; ">Số lượng</th>
				</tr>
				<?php
				if(isset($_POST['count']))
				{
					$money = $_POST['input'];
					$remainAmount = 0.0;
					$coins = array("0","0","0","0","0","0","0","0","0");

					makeChange($money,$remainAmount,$coins);

				}
				?>

				<tr>
					<td>500.000</td>
					<?php
					if($coins[8] > 0)
						echo "<td>$coins[8]</td>"
					?>
				</tr>
				<tr>
					<td>200.000</td>
					<?php
					if($coins[7] > 0)
						echo "<td>$coins[7]</td>"
					?>
				</tr>
				<tr>
					<td>100.000</td>
					<?php
					if($coins[6] > 0)
						echo "<td>$coins[6]</td>"
					?>
				</tr>
				<tr>
					<td>50.000</td>
					<?php
					if($coins[5] > 0)
						echo "<td>$coins[5]</td>"
					?>
				</tr>
				<tr>
					<td>20.000</td>
					<?php
					if($coins[4] > 0)
						echo "<td>$coins[4]</td>"
					?>
				</tr>
				<tr>
					<td>10.000</td>
					<?php
					if($coins[3] > 0)
						echo "<td>$coins[3]</td>"
					?>
				</tr>
				<tr>
					<td>5.000</td>
					<?php
					if($coins[2] > 0)
						echo "<td>$coins[2]</td>"
					?>
				</tr>
				<tr>
					<td>2.000</td>
					<?php
					if($coins[1] > 0)
						echo "<td>$coins[1]</td>"
					?>
				</tr>
				<tr>
					<td>1.000</td>
					<?php
					if($coins[0] > 0)
						echo "<td>$coins[0]</td>"
					?>
				</tr>
			</table>
		</form>
	</div>
	<?php
	function makeChange(&$oriAmount, &$remainAmount, &$coins)
	{
		if (($oriAmount % 500000) < $oriAmount)
		{
			$coins[8] = (int)($oriAmount / 500000);
			$remainAmount = $oriAmount % 500000;
			$oriAmount = $remainAmount;
			
		}
		if (($oriAmount % 200000) < $oriAmount)
		{
			$coins[7] = (int)($oriAmount / 200000);
			$remainAmount = $oriAmount % 200000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 100000) < $oriAmount)
		{
			$coins[6] = (int)($oriAmount / 100000);
			$remainAmount = $oriAmount % 100000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 50000) < $oriAmount)
		{
			$coins[5] = (int)($oriAmount /  50000);
			$remainAmount =$oriAmount %  50000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 20000) < $oriAmount)
		{
			$coins[4] = (int)($oriAmount /  20000);
			$remainAmount =$oriAmount %  20000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 10000) < $oriAmount)
		{
			$coins[3] = (int)($oriAmount /  10000);
			$remainAmount =$oriAmount %  10000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 5000) < $oriAmount)
		{
			$coins[2] = (int)($oriAmount /  5000);
			$remainAmount =$oriAmount %  5000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 2000) < $oriAmount)
		{
			$coins[1] = (int)($oriAmount /  2000);
			$remainAmount =$oriAmount %  2000;
			$oriAmount = $remainAmount;
		}
		if (($oriAmount % 1000) < $oriAmount)
		{
			$coins[0] = (int)($oriAmount /  1000);
			$remainAmount =$oriAmount %  1000;
			$oriAmount = $remainAmount;
		}
	}
	?>
</body>
</html>