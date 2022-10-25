<?php
  $sehirler = array("kastamonu","zonguldak","samsun","adıyaman");

   $i = 0;

  while ($i < count ($sehirler)) 
  {
	  $b = $sehirler[$i];
	  
	  echo $b ."\n";
	  
	  $i++
  }  
?>


<?php
   $sehir = array("izmit","kastamonu","edirne","izmir");
   $sayac=0;
   for($i=0;$i<4;$i++)
   {
	   echo $sehir[$i]."<br>";
   }
   do{
	   echo $sehir[$sayac]."<br>";
	   $sayac++;
   }while($sayac<count($sehir));
?>



<?php
   $sehrim = array("ankara","eskisehir","edirne","sivrihisar","balıkesir");
   
   foreach($sehrim as $1st){
	   echo $1st."<br/>";
   }
?>