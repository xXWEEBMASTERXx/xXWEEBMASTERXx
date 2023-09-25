<!doctype html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>A thesis on Blaise being a gypsy.</title>
</head>
<body>
    <?php
        $nberek=[[1,"rooland", 1, 69420],[2,"balazs", 2, 42069],[3,"amogus", 3, 696969]];
        $kotsi=[[1,"Tesla","Cybertruck"],[2,"IMP Vehicle","Truck"],[3,"opel","astra"]];
        //1.feladat
        foreach ($nberek[0] as $i)
        {
            echo $i . "<br>";
        }
        //2.feladat
        foreach ($kotsi[0] as $i)
        {
            echo $i . "<br>";
        }
        //3.feladat
        echo $nberek[0][1];
        $num = 0;
        $num2 = 0;
        foreach ($kotsi as $i)
        {
            $num++;
            if ($num == 3)
            {
                $num =0;
                $num2++;
            }
            if ($nberek[0][2] == $i)
            {
                echo $kotsi[$num2][$num] . "<br>";
            }
        }
        //4.feladat
        $rooland = [];
        $balazs = [];
        $amogus = [];

        $num = 0;
        $num2 = 0;
        $num3 = 0;
        $num4 = 0;
        foreach ($kotsi as $i)
        {
            $num++;
            if ($num == 3)
            {
                $num =0;
                $num2++;
            }
            if ($nberek[$num2][2] == $kotsi[$num2][0])
            {
                if ($num == 1)
                {
                    foreach ($nberek as $i)
                    {
                        if ($num > 1)
                        {
                            break;
                        }
                        $num3++;
                        if ($num == 3)
                        {
                            $num3 =0;
                            $num4++;
                        }
                        array_push($rooland,$nberek[0][$num3]);
                    }
                    foreach ($kotsi as $i)
                    {
                        if ($num > 1)
                        {
                            break;
                        }
                        $num3++;
                        if ($num == 3)
                        {
                            $num3 =0;
                            $num4++;
                        }
                        array_push($rooland,$kotsi[0][$num3]);
                    }
                }
            }
                else if ($num == 2)
                {
                        foreach ($nberek as $i)
                        {
                            if ($num > 2 && $num < 2)
                            {
                                break;
                            }
                            $num3++;
                            if ($num == 3)
                            {
                                $num3 =0;
                                $num4++;
                            }
                            array_push($balazs,$nberek[0][$num3]);
                        }
                        foreach ($kotsi as $i)
                        {
                            if ($num > 2 && $num < 2)
                            {
                                break;
                            }
                            $num3++;
                            if ($num == 3)
                            {
                                $num3 =0;
                                $num4++;
                            }
                            array_push($balazs,$kotsi[0][$num3]);
                        }
                }
                else
                {
                        foreach ($nberek as $i)
                        {
                            if ($num > 3 && $num < 3)
                            {
                                break;
                            }
                            $num3++;
                            if ($num == 3)
                            {
                                $num3 =0;
                                $num4++;
                            }
                            array_push($amogus,$nberek[0][$num3]);
                        }
                        foreach ($kotsi as $i)
                        {
                            if ($num > 3 && $num < 3)
                            {
                                break;
                            }
                            $num3++;
                            if ($num == 3)
                            {
                                $num3 =0;
                                $num4++;
                            }
                            array_push($amogus,$kotsi[0][$num3]);
                        }
                }
            }
        //5.feladat
        vardump($rooland);
        vardump($balazs);
        vardump($amogus);
    ?>
</body>
</html>