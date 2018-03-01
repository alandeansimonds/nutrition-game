<?php
	require_once("config.php");

	$auth_host = $GLOBALS['auth_host'];
	$auth_user = $GLOBALS['auth_user'];
	$auth_pass = $GLOBALS['auth_pass'];
	$auth_dbase = $GLOBALS['auth_dbase'];
	
	
	$db = mysqli_connect($auth_host, $auth_user, $auth_pass,$auth_dbase) or die("Error " . mysqli_error($db));
	
	echo var_dump($_POST);

	$user_name = mysqli_real_escape_string($db,$_POST['name']);
	$user_password = mysqli_real_escape_string($db,$_POST['password']);

	//$sql = mysqli_query($db,"SELECT * FROM account WHERE (user = '$user_name' AND password = MD5('".$user_password."')) AND active IS NULL");
	//$sql = mysqli_query($db,"SELECT Id FROM account WHERE ((user = '$user_name' AND password = MD5('".$user_password."')) AND active IS NULL) LIMIT 1");
	$sql = mysqli_query($db,"SELECT Id FROM account WHERE ((user = '$user_name') AND (active IS NULL) AND (password = MD5('".$user_password."'))) LIMIT 1");
	$numRows= mysqli_num_rows($sql);

	echo "NumRows: ".$numRows."<br>";
	echo "Username: ".$user_name."<br>";
	echo "Password: ".$user_password."<br>";
	echo "MD5Password: ".MD5($user_password)."<br>";
	echo "Result Id:";

	$id = -1;
	while ($row = mysqli_fetch_array($sql)) {
		$id = $row["Id"];
		break;
	}

	echo $id;

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
