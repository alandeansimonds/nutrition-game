<?php
	require_once("config.php");

	$auth_host = $GLOBALS['auth_host'];
	$auth_user = $GLOBALS['auth_user'];
	$auth_pass = $GLOBALS['auth_pass'];
	$auth_dbase = $GLOBALS['auth_dbase'];
	
	
	$db = mysqli_connect($auth_host, $auth_user, $auth_pass,$auth_dbase) or die("Error " . mysqli_error($db));
	

	//$user_name = mysqli_real_escape_string($db,$_POST['name']);
	//$user_password = mysqli_real_escape_string($db,$_POST['password']);

	//$sql = mysqli_query($db,"SELECT * FROM account WHERE (user = '$user_name' AND password = MD5('".$user_password."')) AND active IS NULL");

	$playerId = mysqli_real_escape_string($db, $_POST['playerId']);
	// Note: $recordNames and $recordValues are arrays.
	$recordNames = $_POST['recordName'];
	$recordValues = $_POST['recordValue'];

	foreach( $recordNames as $key => $rawRecordName ) {
		//print "The name is ".$name." and value is ".$recordValues[$key]."\n";
		
		$recordName = mysqli_real_escape_string($db, $rawRecordName);
		$recordValue = mysqli_real_escape_string($db, $recordValues[$key]);

		$queryString = "INSERT INTO playerdata (playerId, datemName, datemValue) VALUES($playerId, '$recordName', '$recordValue') ON DUPLICATE KEY UPDATE datemValue='$recordValue'";

		$sql = mysqli_query($db, $queryString);
	}

	//$rows= mysqli_num_rows($sql);
	//if($rows > 0){
	echo "true";
	//}else{
	//	echo "false";
	//}

	mysqli_close($db);
	
?> 
