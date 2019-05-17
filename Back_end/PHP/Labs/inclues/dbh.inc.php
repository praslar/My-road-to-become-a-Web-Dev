<?php
	 $conn=mysqli_connect("localhost","id9173791_praslar","nnccbdcmt","id9173791_loginform");
        if(!conn){
            die("Connection failed: ".mysqli_connect_error());
        } else {
            echo "Connection Successfully!";
        }