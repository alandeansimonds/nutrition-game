<?php
	require_once("config.php");

	$auth_host = $GLOBALS['auth_host'];
	$auth_user = $GLOBALS['auth_user'];
	$auth_pass = $GLOBALS['auth_pass'];
	$auth_dbase = $GLOBALS['auth_dbase'];
	
	
	$db = mysqli_connect($auth_host, $auth_user, $auth_pass,$auth_dbase) or die("Error " . mysqli_error($db));
	
	//$sql = mysqli_query($db,"SELECT * FROM account WHERE (user = '$user_name' AND password = MD5('".$user_password."')) AND active IS NULL");

	$playerId = mysqli_real_escape_string($db, $_POST['playerId']);
	// Note: $recordNames and $recordValues are arrays.
	
	//$queryString = "INSERT INTO playerdata (playerId, datemName, datemValue) VALUES($playerId, '$recordName', '$recordValue') ON DUPLICATE KEY UPDATE datemValue='$recordValue'";
	$queryString = "SELECT datemName,datemValue FROM playerdata WHERE (playerId = $playerId)";

	$sql = mysqli_query($db, $queryString);
	
	if (!$sql) {
		echo "false";
		//echo mysqli_error($db);
	} else {
		$numRows = mysqli_num_rows($sql);
		if($numRows > 0){
			// Return a CSV table of records.
			while ($row = mysqli_fetch_array($sql)) {
				$datemName = $row["datemName"];
				$datemValue = $row["datemValue"];
				echo $datemName.",".$datemValue."\n";
			}
		} else {
			// Return false to indicate an error.
			echo "false";
		}
	}

	mysqli_close($db);
?> 
