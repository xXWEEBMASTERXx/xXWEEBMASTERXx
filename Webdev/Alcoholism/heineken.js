document.write( "<table align=center id='szorzotabla'>" )

for( i=1; i<=20; i++ )
{
    document.write( "<tr>" )

    for( j=1; j<=20; j++ )
    {
        if( i==1 || j==1)  document.write( "<td width='5%'             >" + i*j + "</td>" )
        else               document.write( "<td title='" +i+ "*" +j+ "'>" + i*j + "</td>" )
    }

    document.write( "</tr>" )

}

document.write( "</table>" )
