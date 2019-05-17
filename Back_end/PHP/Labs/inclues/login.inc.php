<?php
if (isset($_POST['login-submit'])) {

	$mailuid = $_POST['mailuid'];
	$password = $_POST['pwd'];
	if {
		$sql = "SELECT * FROM users WHERE uidUsers=? OR emailUsers=?";
		$stmt = mysqli_stmt_init($conn);
		if(!mysqli_stmt_prepare($stmt, $sql)){
			header("Location:../index.php");
			exit();
		} else {
			//data type pass into database
			mysqli_stmt_bind_param($stmt, "ss", $mailuid,$mailuid);
			mysqli_stmt_execute($stmt);
			$result = mysqli_stmt_get_result($stmt);
			if ($row = mysqli_fetch_assoc($result)){
				$pwdCheck = password_verify($password, $row['pwdUsers']);
				if ($pwdCheck == false) {
					header("Location:../index.php?error=worngpwd");
					exit();
				}
				else if ($pwdCheck == true)
				{
					session_start();
					$_SESSION['userId'] = $row['idUsers'];
					$_SESSION['userUid'] = $row['uidUsers'];

					header("Location: ../index.php?login=sucess");
					exit();
				}
			}
		} else {
			header("Location: ../index.php")
			exit();
		}
		?>