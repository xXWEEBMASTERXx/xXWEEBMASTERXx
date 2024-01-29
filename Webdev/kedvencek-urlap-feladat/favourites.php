<?php include("data.php") ?>
<?php

$name = $_GET['name'] ?? "";
$email = $_GET['email'] ?? "";
$colorId = $_GET['color'] ?? "";
$hobbyIds = $_GET['hobbies'] ?? [];
$carId = $_GET['car'] ?? "";
$message = $_GET['message'] ?? "";

$errors = [];

if(count($_GET) == 0 )
{
    $errors[] = "Nem érkezett semmi a \$_GET tömbben!";
}
else
{
    foreach(["name","email","color", "car", "hobbies","message"] as $item)
    {
        if(!isset($_GET[$item]))
        {
            if(isset($_POST[$item]))
            {
                $errors[] = "A \$_GET['$item'] nem található, de a \$_POST['$item'] igen! Az űrlapnak mi a 'method' attrivútuma?";
            }
            else{
                $errors[] = "A \$_GET['$item'] nem található. Ki lett töltve az űrlap elem 'name' attribútuma?";
            }
        }
    }

    if(isset($_GET["color"]) && !in_array($_GET["color"],array_keys($colors)))
    {
        $errors[] = "A szín 'name' attribútuma jó, de az option elem 'value' értéke nem található meg a tömb kulcsai között!";   
    }

    if($carId == "on")
    {
        $errors[] = "Az autó 'name' attribútuma jó, de az 'input' elemnek meg kell adni a 'value' értékét. Ebben a példában a \$cars tömbbbeli indexe kell, hogy legyen a kiválasztott automárka esetén.";   
    }

    if(isset($_GET['car']) && !in_array($carId,array_keys($cars)))
    {
        $errors[] = "A \$_GET['car'] tartalma: '$_GET[car]', ugyanakkor ilyen kulcsa nincs a data.php-ban megtalálható \$cars tömbnek.";   
    }

    if($hobbyIds == "on")
    {
        $errors[] = "Az hobby részlegen vagy a 'name' vagy a 'value' nem jól lett kitöltve";   
    }

    if(isset($_GET['hobbies']))
    {
        foreach($hobbyIds as $hobbyId)
        {
            if(!in_array($hobbyId,array_keys($hobbies)))
            {
                $errors[] = "Az alábbi sorszám: '$hobbyId' nem található meg a data.php-ban lévő \$hobbies tömbben.";   
            }
        }
    }

}



?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Adatok</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-uWxY/CJNBR+1zjPWmfnSnVxwRheevXITnMqoEIeG1LJrdI0GlVs/9cVSyPYXdcSF" crossorigin="anonymous">
    <style>
        
    </style>
</head>
<body>
   

    <div class="container">
        <div class="row">
            <div class="col-12">
                <?php foreach($errors as $error): ?>
                    <div class="alert alert-danger my-3" role="alert">
                    <?= $error ?>
                    </div>
                <?php endforeach ; ?>
                <h1>Kedves <?= $name ?></h1>

                <p>Ha bármi kérdésünk lesz, akkor a(z) <b>"<?= $email ?>"</b> címen keresünk.
                
                Úgy látom a kedvenc színed a <span style="color: <?= $colorId ?>"><?=$colors[$colorId]?></span>.
                
                Szeretnénk a kedvedben járni, így a szolgálati kocsid lehetőség szerint egy <b><?= $cars[$carId] ?? "roncs" ?></b> lesz.</p>

                <p>Az érdeklődési körödről ennyit tudunk</p>

                <?php foreach($hobbies as $hobbyId => $hobbyName): ?>
                    <?php if(in_array($hobbyId,$hobbyIds)) : ?>
                            <li><b><?= $hobbyName ?>: igen</b></li>
                        <?php else: ?>
                            <li><?= $hobbyName ?>: nem</li>
                        <?php endif; ?>
                <?php endforeach; ?>

                <div class="my-3">
                <?php if(empty($message)): ?>
                    <p>Nem érkezett üzenet.</p>
                <?php else: ?>
                    <p><b>Az alábbi üzenet érkezett:</b></p>

                    <p><?= $message ?></p>
                <?php endif; ?>
                </div>

            </div>
        </div>
    </div>


</body>
</html>