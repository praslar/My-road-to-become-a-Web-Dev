<!DOCTYPE html>
<html>
<head>
	<title>Bob's Auto Parts - Order Results</title>
	<link href="https://fonts.googleapis.com/css?family=Gugi|Montserrat|ZCOOL+KuaiLe" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="structure.css">
</head>
<body>
	<h1>bob's Auto Parts</h1>
	<h2>Order Results</h2>

	<?php

	define('TIREPRICE', 100);
	define('OILPRICE', 10);
	define('SPARKPRICE', 4);

	echo '<p>Order processed</p>';
	echo "<p>Order processed at ".date('H:i:s, jS F Y')."</p>";
		// create short variable names

	$tireqty = $_POST['tireqty'];
	$oilqty = $_POST['oilqty'];
	$sparkqty = $_POST['sparkqty'];
	$find = $_POST['find'];

	$tireqty = htmlspecialchars($tireqty);

	echo "$tireqty tires<br/>";
	echo htmlspecialchars($oilqty).' bottle of oil<br/>';
	echo htmlspecialchars($sparkqty).' spark plugs<br/>';

	$totalqty = 0;
	$totalqty = $tireqty + $oilqty + $sparkqty;
	echo "<p>Items ordered: $totalqty</p>";

	$totalamount = 0.0;

	$totalamount =  $tireqty * TIREPRICE
	+	$oilqty * OILPRICE
	+	$sparkqty * SPARKPRICE;
	echo "Subtotal: $".number_format($totalamount,2)."</br>";
	$taxrate = 0.10;
	$totalamount = $totalamount*(1 + $taxrate);
	echo "Total including tax: $".number_format($totalamount,2)."</p>";

	switch ($find) {
		case 'a':
		echo "<p>Regular customer.</p>";
		break;
		case 'b':
		echo "<p>Customer referred by TV advert.</p>";
		break;
		case 'c':
		echo "<p>Customer referred by phone directory.</p>";
		break;
		case 'd':

		echo "<p>Customer referred by word of mouth.</p>";
		break;
		default:
		echo "<p>Ehhh...what the heck!</p>";
		break;
	}
 
	?>
	<h2>bob's Auto Parts - Freight Costs</h2>
	<table class="freight">
		<tr>
			<th>Distance</th>
			<th>Cost</th>
		</tr>

		<tr>
			<?php
				$distance = 50;
				while ($distance <= 250) {
					echo "<tr>";
					echo "<td>$distance</td>";
					$cost = $distance/10;
					echo "<td>$cost</td>";
					echo "</tr>";
					$distance+=50;
				}
			  ?>
		</tr>
	</table>
</BODY>
</HTML>