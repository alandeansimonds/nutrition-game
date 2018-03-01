
<?php

require_once("config.php");

#$filename = $_FILES['csvFile']['name'];
$tempFilename = $_FILES["csvFile"]["tmp_name"];

#echo "Filename: ";
#echo $filename."\n";  
# Create link to the sql database.
$db = mysqli_connect($auth_host, $auth_user, $auth_pass, $auth_dbase) or die("Error " . mysqli_error($db));

$file = fopen($tempFilename, 'r');
$firstLine = true;
while (($line = fgetcsv($file)) !== FALSE) {
    //$line[0] = '1004000018' in first iteration
    if ($firstLine) {
        $firstLine = false;
        continue;
    }

    $usernameRaw = $line[0];
    $passwordRaw = $line[1];
    $emailRaw = $line[2];

    $username = mysqli_real_escape_string($db, $usernameRaw);
    $password = mysqli_real_escape_string($db, $passwordRaw);
    $email = mysqli_real_escape_string($db, $emailRaw);

    #mysqli_query($db,"INSERT INTO account(user,password,email,active) VALUES ('$username',MD5('".$password."'),'$email','$activation')");
    # The accounts will now be activated by default.
    # This is to work around the email server not working.
    mysqli_query($db, "INSERT INTO account(user,password,email,active) VALUES ('$username',MD5('" . $password . "'),'$email', NULL)");

    #print("Username: " . $username."<br>");
    #print("Password: " . $password."<br>");
    #print("Email: " . $email."<br>");
    #print_r($line);
    #break;
}
fclose($file);

mysqli_close($db);


echo "<br>End.";
?>