<?php
if (isset($_POST['signup-submit'])) {

	require 'dbh.inc.php';

	$username = $_POST['uid'];
	$email = $_POST['mail'];
	$password = $_POST['pwd'];
	$passwordRepeat = $_POST['pwd-repeat'];

	if (!preg_match("/^[a-zA-z0-9]*$/", $username)) {
		header("Location:  ../signup.php?error=invalidusername&mail=".$email);
		exit();
	}
	else if($password !== $passwordRepeat){
		header("Location:  ../signup.php?error=passwordcheckuid=".$username."&mail=".$email);
		exit();
	}
	else
	{
		$sql = "SELECT uidUsers FROM users WHERE uidUsers=?";
		$stmt = mysqli_stmt_init($conn);
		if(!mysqli_stmt_prepare($stmt, $sql)){
			header("Location:  ../signup.php?error=sqlerror");
			exit();
		} else {
			//data type pass into database
			mysqli_stmt_bind_param($stmt, "s", $username);
			mysqli_stmt_execute($stmt);
			//store data to stmt
			mysqli_stmt_store_result($stmt);
			$resultCheck = mysqli_stmt_num_rows($stmt);
			if($resultCheck > 0)
			{
				header("Location:  ../signup.php?error=usertaken&mail=".$email);
				exit();
			} else {
				$sql = "INSERT INTO users (uidUsers, emailUsers, pwdUsers) VALUES (?,?,?)";
				$stmt = mysqli_stmt_init($conn);
				if(!mysqli_stmt_prepare($stmt, $sql)){
					header("Location: ../signup.php?error=sqlerror");
					exit();
				} else {
					//something c
					$hashedPwd = password_hash($password, PASSWORD_DEFAULT);
					//data type pass into database
					mysqli_stmt_bind_param($stmt, "sss", $username, $email, $hashedPwd);
					//something
					mysqli_stmt_execute($stmt);
					header("Location:  ../signup.php?signup=success");
					exit();
				}
			}

		}
	}
	mysqli_stmt_close($stmt);
	mysqli_close($conn);	
} else {
	header("Location:  ../sigup.php");
	exit();
}