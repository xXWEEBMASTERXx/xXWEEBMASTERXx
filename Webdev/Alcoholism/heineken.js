function terfogat_szamol(mibol)
    {

        pint  = parseFloat( document.terfogat.pint.value  )
        liter = parseFloat( document.terfogat.liter.value )

        if( mibol=="pintből"  && pint >0 )
        {
            document.terfogat.liter.value = pint  * 0.473
        }

        if( mibol=="literből" && liter>0 )
        {
            document.terfogat.pint.value  = liter / 0.473
        }

    }

function suly_szamol(mibol)
    {

        uncia  = parseFloat( document.suly.uncia.value  )
        gramm = parseFloat( document.suly.gramm.value )

        if( mibol=="unciából"  && uncia >0 )
        {
            document.suly.gramm.value = uncia  * 28.35
        }

        if( mibol=="grammból" && gramm>0 )
        {
            document.suly.uncia.value  = gramm / 28.35
        }

    }

function homerseklet_szamol(mibol)
    {

        Celsius  = parseFloat( document.homerseklet.Celsius.value  )
        Fahrenheit = parseFloat( document.homerseklet.Fahrenheit.value ) 

        if( mibol=="Celsiusból"  && Celsius >0 )
        {
            document.homerseklet.Fahrenheit.value = Math.round((Celsius * (9 / 5) ) + 32) 
        }

        if( mibol=="Fahrenheitből" && Fahrenheit>0 )
        {
            document.homerseklet.Celsius.value  = Math.round((Fahrenheit - 32) * (5 / 9))
        }

    }

function tavolsag_szamol(mibol)
    {

        uncia  = parseFloat( document.suly.uncia.value  )
        gramm = parseFloat( document.suly.gramm.value )

        if( mibol=="hüvelykból"  && hüvelyk >0 )
        {
            document.suly.gramm.value = hüvelyk  * 28.35
        }

        if( mibol=="mmből" && mm>0 )
        {
            document.tavolsag.hüvelyk.value  = mm / 28.35
        }

    }