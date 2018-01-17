<?php
	require_once("config.php");

	$auth_host = $GLOBALS['auth_host'];
	$auth_user = $GLOBALS['auth_user'];
	$auth_pass = $GLOBALS['auth_pass'];
	$auth_dbase = $GLOBALS['auth_dbase'];
	
	//DEBUG
	//echo var_dump($_POST);

	$db = mysqli_connect($auth_host, $auth_user, $auth_pass,$auth_dbase) or die("Error " . mysqli_error($db));
	
	// Production (Release):
	$user_name = mysqli_real_escape_string($db,$_POST['name']);
	$user_password = mysqli_real_escape_string($db,$_POST['password']);
	// Debugging:
	//$user_name = mysqli_real_escape_string($db,$_GET['name']);
	//$user_password = mysqli_real_escape_string($db,$_GET['password']);

	//$sql = mysqli_query($db,"SELECT * FROM account WHERE (user = '$user_name' AND password = MD5('".$user_password."')) AND active IS NULL");

	// Check activation first.
	$sqlActivationCheck = mysqli_query($db,"SELECT Id FROM account WHERE ((user = '$user_name') AND (active IS NULL)) LIMIT 1");
	$numRowsCheck = mysqli_num_rows($sqlActivationCheck);

	//DEBUG
	//echo var_dump($_POST);

	if (0 == $numRowsCheck) {
		// Not yet activated.
		echo -2;
		//echo "user_name: ".$user_name;
		//echo "POST[name]: ".$_POST['name'];
	} else {
		$sql = mysqli_query($db,"SELECT Id FROM account WHERE ((user = '$user_name') AND (password = MD5('".$user_password."'))) LIMIT 1");
		$numRows= mysqli_num_rows($sql);

		$id = -1;
		while ($row = mysqli_fetch_array($sql)) {
			$id = $row["Id"];
			break;
		}

		echo $id;
	}

	//if($numRows > 0){
		//echo "true";
		// Send back the associated Player Id.
		
	//}else{
		//echo "false";
		// Send back an invalid Player Id.
	//	echo "-1";
	//}
	mysqli_close($db);
	
?> 
