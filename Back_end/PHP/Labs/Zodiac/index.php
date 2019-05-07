<!DOCTYPE html>
<html>
<head>
	<title>Horoscope</title>
	<link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
	<link href="https://fonts.googleapis.com/css?family=Sofia" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="structure.css">
</head>
<body>
	<div id="wrapper">
		<div id="info">
			<div id="info-content">
				<form action="#" method="post">
					<h1>Zodiac Sign</h1>
					<table >
						<tr>
							<td>Date of birth</td>
							<td><input id="name" class="input" type="number" name="date" min=1 max=31 value="1"></td>
						</tr>
						<tr>
							<td>Month</td>
							<td><select name="month">
								<option value="1">January</option>
								<option value="2">February</option>
								<option value="3">March</option>
								<option value="4">April</option>
								<option value="5">May</option>
								<option value="6">June</option>
								<option value="7">July</option>
								<option value="8">August</option>
								<option value="9">September</option>
								<option value="10">October</option>
								<option value="11">November</option>
								<option value="12">December</option>
							</select></td>
						</tr>
						<tr >							
							<td colspan="2" class="single">
								<?php
								if(isset($_POST['date']) && isset($_POST['month']))
								{
									$date = $_POST['date'];
									$month = $_POST['month'];
									switch ($month) {
										case '1':
										if($date <= 20)
											echo "Capricor";
										else
											echo "Aquarius";
										break;
										case '2':
										if($date <= 19)
											echo "Aquarius";
										else
											echo "Pisces";
										break;
										case '3':
										if($date <= 20)
											echo "Pisces";
										else
											echo "Aries";
										break;
										case '4':
										if($date <= 20)
											echo "Aries";
										else
											echo "Taurus ";
										break;
										case '5':
										if($date <= 21)
											echo "Taurus ";
										else
											echo "Gemini ";
										break;
										case '6':
										if($date <= 21)
											echo "Gemini";
										else
											echo "Cancer ";
										break;
										case '7':
										if($date <= 23)
											echo "Cancer ";
										else
											echo "Leo";
										break;
										case '8':
										if($date <= 23)
											echo "Leo";
										else
											echo "Virgo ";
										break;
										case '9':
										if($date <= 23)
											echo "Virgo ";
										else
											echo "Libra ";
										break;
										case '10':
										if($date <= 23)
											echo "Libra ";
										else
											echo "Scorpio ";
										break;
										case '11':
										if($date <= 22)
											echo "Scorpio ";
										else
											echo "Sagittarius ";
										break;
										case '12':
										if($date <= 21)
											echo "Sagittarius ";
										else
											echo "Capricorn";
										break;
										default:
										echo "Ehhh...What did you do?!";
										break;
									}
								}
								?>
							</td>
						</tr>
						<tr >
							<td colspan="2" class="single"><button>Horospoce</button></td>					
						</tr>
					</table>
				</form>
			</div>
		</div>
		<input type="checkbox" id="menu" name="menu" class="menu-checkbox">
		<div class="menu">
			<label class="menu-toggle" for="menu"><span>Toggle</span></label>
			<ul>
				<li>
					<a href="#">Aquarius</a>
				</li>
				<li>
					<a href="#">Pisces</a>
				</li>
				<li>
					<a href="#">Aries</a>
				</li>
				<li>
					<a href="#">Taurus</a>
				</li>
				<li>
					<a href="#">Gemini</a>
				</li>
				<li>
					<a href="#">Cancer</a>
				</li>
				<li>
					<a href="#">Leo</a>
				</li>
				<li>
					<a href="#">Virgo</a>
				</li>
				<li>
					<a href="#">Libra</a>
				</li>
				<li>
					<a href="#">Scorpio</a>
				</li>
				<li>
					<a href="#">Sagittarius</a>
				</li>
				<li>
					<a href="#">Capricorn</a>
				</li>
			</ul>
		</div>
	</div><!-- #wrapper -->
</body>
</html>