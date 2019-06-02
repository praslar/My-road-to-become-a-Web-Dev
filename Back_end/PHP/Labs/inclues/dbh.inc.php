<?php
	 $conn=mysqli_connect("localhost","root","","phpLabs");
        if(!$conn){
            die("Connection failed: ".mysqli_connect_error());
        } else {
            echo "Connection Successfully!";
        }