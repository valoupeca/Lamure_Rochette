   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ClientWPF	ClientWPF  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   A%clr-namespace:ClientWPF.ServiceAgenceClientWPF.ServiceAgence  5   	   !    ClientWPF.Recherche_Avancee   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ClientWPF     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   3s%clr-namespace:ClientWPF.ServiceAgence     5   	     � Title$  Recherche_Avancee��5
   	    � 	Resources 5         BienTypeProvider S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  TypeTransac  TypeChauffage  EnergieChauffage��%H  &	        &	 �     &	     &	 �    S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $$ s:BienImmobilierBase+eTypeBien��6   5      S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $+ %s:BienImmobilierBase+eTypeTransaction��6   5      S� 5   
   $ 	GetValues��5      "  5       5       M� 5!      $) #s:BienImmobilierBase+eTypeChauffage��6   5#      S� 5%   
   $ 	GetValues��5&      "  5'       5(      M� 5)      $, &s:BienImmobilierBase+eEnergieChauffage��6   5+      5,      .��5.      �  � RowDefinitions 5/   
   �� 50      $��* �6   �� 51      $��* �6   �� 52      $��* �6   �� 53      $��* �6   �� 54      $��* �6   �� 55      $��* �6   �� 56      $��* �6   �� 57      $��* �6   �� 58      $��* �6   �� 59      $��* �6   �� 5:      $��* �6   �� 5;      $��* �6   �� 5<      $��* �6   �� 5=      $��* �6   �� 5>      $��* �6    � ColumnDefinitions 5@   
   �� 5A      $��* �6   �� 5B      $��* �6   .+�5E   
   �� -   5         ��Name$ label��5E      $��Type de Transaction��6   $��0��6=   $��0��6M   �� 5F   
   -   5        $ label2��5F      $��Type de Bien��6    $��0��67   $��1��6G   �� 5G   
   -   5        $ label3��5G      $��Type de Chauffage��6    $��0��6<   $��2��6L   �� 5H   
   -   5        $ label4��5H      $��Energie de chauffage��6    $��0��6?   $��3��6O   �� 5I   
   -   5        $ label5��5I      $��Prix minimum��6    $��0��67   $��4��6G   �� 5J   
   -   5        $ label6��5J      $��Prix maximum��6    $��0��67   $��5��6G   �� 5K   
   -   5        $ label7��5K      $��Etage minimum��6    $��0��68   $��6��6H   �� 5L   
   -   5        $ label8��5L      $��Etage maximum��6    $��0��68   $��7��6H   �� 5M   
   -	   5        $ label9��5M      $��Surface minimum��6    $��0��6:   $��8��6J   �� 5N   
   -
   5        $ label10��5N      $��Surface maximum��6!   $��0��6;   $��9��6K   �� 5P   
   -   5        $ label11��5P      $��Nombres pièces minimum��6!   $��0��6B   $��10��6R   �� 5Q   
   -   5        $ label12��5Q      $��Nombres pièces maximum��6!   $��0��6B   $��11��6R   �� 5R   
   -   5        $ label13��5R      $��Ville��6!   $��0��61   $��12��6A   �� 5T   
   -   5        	 ��Name$	 typebien��5T      $��1��6%   $��0��65   
 �� SelectedValue
 6B   �� *
Bienselect+��6g   ��  �� Source# [  �� 5U   
   -   5        $	 typetransaction��5U      $��1��6,   $��1��6<   
 6I   �� *TransacSelect+��6r   �� # [ �� 5V   
   -   5        $	 typechauffage��5V      $��1��6*   $��2��6:   
 6G   �� *ChaufSelect+��6m   �� # [ �� 5W   
   -   5        $	 energiechauffage��5W      $��1��6-   $��3��6=   
 6J   �� *EnergieSelect+��6s   �� # [ �� 5Y   
   -   5         ��Name$ prixmin��5Y      $��1��6$   $��4��64   �� 5Z   
   -   5        $ prixmax��5Z      $��1��6$   $��5��64   �� 5[   
   -   5        $ etagemin��5[      $��1��6%   $��6��65   �� 5\   
   -   5        $ etagemax��5\      $��1��6%   $��7��65   �� 5]   
   -   5        $ surfmin��5]      $��1��6$   $��8��64   �� 5^   
   -   5        $ surfmax��5^      $��1��6$   $��9��64   �� 5_   
   -   5        $ nombrepiecemin��5_      $��1��6+   $��10��6;   �� 5`   
   -   5        $ nombrepiecemax��5`      $��1��6+   $��11��6;   �� 5a   
   -   5        $ ville��5a      $��1��6"   $��12��62   �� 5c   
   -   5         ��Name$ button��5c      $(��"VALIDER VOS CRITERES DE RECHERCHES��6!   $��1��6N   $��14��6^   6�   5e      5f      