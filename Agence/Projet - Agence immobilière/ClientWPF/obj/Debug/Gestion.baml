   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   D @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ClientWPF.ServiceAgenceClientWPF.ServiceAgence 5   	   %clr-namespace:ClientWPF	ClientWPF 5   	      ClientWPF.Gestion   5   	   .sys&clr-namespace:System;assembly=mscorlib  5   	   +s%clr-namespace:ClientWPF.ServiceAgence  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ClientWPF     5   	   -   5          � Title$  Ajout/Modification��5
   	    � 	Resources 5         BienTypeProvider S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName  TypeTransac  TypeChauffage  EnergieChauffage��%H  &	        &	 �     &	     &	 �    S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $$ s:BienImmobilierBase+eTypeBien��6   5      S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $+ %s:BienImmobilierBase+eTypeTransaction��6   5      S� 5   
   $ 	GetValues��5      "  5       5       M� 5!      $) #s:BienImmobilierBase+eTypeChauffage��6   5#      S� 5%   
   $ 	GetValues��5&      "  5'       5(      M� 5)      $, &s:BienImmobilierBase+eEnergieChauffage��6   5+      5,      .��5.      �  � RowDefinitions 5/   
   �� 50      $��* �6   �� 51      $��* �6   �� 52      $��* �6   �� 53      $��* �6   �� 54      $��* �6   �� 55      $��* �6   �� 56      $��* �6   �� 57      $��* �6   �� 58      $��* �6   �� 59      $��* �6   �� 5:      $��* �6   �� 5;      $��* �6   �� 5<      $��* �6   �� 5=      $��* �6   �� 5>      $��* �6   �� 5?      $��* �6    � ColumnDefinitions 5B   
   �� 5C      $��* �6   �� 5D      $��* �6   �� 5E      $��* �6   �� 5F      $��* �6   .+�5I   
   �� -   5         ��Name$ label��5I      $��Titre��6   $��0��61   $��0��6A   �� 5J   
   -   5        	 ��Name$	 trtbien��5J      $��1��6G   $��0��6W   ��6$   �� *RecupBien.Titre+6W   �� 5L   
   -   5        $ label2��5L      $��Type de Transaction��6    $��0��6?   $��1��6O   �� 5M   
   -   5        
 ��Name$
 TypeTransacold��5M      $��1��6c   $��1��6s    �� SelectedValue 6-   �� *RecupBien.TypeTransaction+��6�   ��  �� Source# [ �� 5O   
   -   5        $ label3��5O      $��Type de Bien��6    $��0��69   $��2��6I   �� 5P   
   -   5        $
 TypeBienanc��5P      $��1��6X   $��2��6h    6*   �� *RecupBien.TypeBien+��6u   �� # [  �� 5R   
   -   5        $ label4��5R      $
��Prix��6    $��0��60   $��3��6@   �� 5S   
   -	   5        $	 Prixan��5S      $��1��6D   $��3��6T   ��6#   �� *RecupBien.Prix+6T   �� 5U   
   -
   5        $ label6��5U      $��Ville��6    $��0��61   $��4��6A   �� 5V   
   -   5        $	 Villeancienne��5V      $��1��6K   $��4��6[   ��6)   �� *RecupBien.Ville+6[   �� 5X   
   -   5        $ label7��5X      $��Description ��6    $��0��68   $��5��6H   �� 5Y   
   -   5        $	 Descanc��5Y      $��1��6K   $��5��6[   ��6#   �� *RecupBien.Description+6[   �� 5[   
   -   5        $ label8��5[      $��Adresse ��6    $��0��64   $��6��6D   �� 5\   
   -   5        $	 
Adresseanc��5\      $��1��6J   $��6��6Z   ��6&   �� *RecupBien.Adresse+6Z   �� 5^   
   -   5        $ label9��5^      $��Photo��6    $��0��61   $��7��6A   �� 5`   
   -   5        $��Ajouter Photo��5`      $��1��6A   $��7��6Q   �� 5d   
   -   5        $ label99��5d      $��Code postal ��6!   $��2��69   $��0��6I   �� 5e   
   -   5        $	 CPanc��5e      $��3��6H   $��0��6X   ��6!   �� *RecupBien.CodePostal+6X   �� 5g   
   -   5        $ label10��5g      $��Surface ��6!   $��2��65   $��1��6E   �� 5h   
   -   5        $	 Surfanc��5h      $��3��6H   $��1��6X   ��6#   �� *RecupBien.Surface+6X   �� 5j   
   -   5        $ label11��5j      $��Nombre d'étages ��6!   $��2��6=   $��2��6M   �� 5k   
   -   5        $	 NbEtaanc��5k      $��3��6I   $��2��6Y   ��6$   �� *RecupBien.NbEtages+6Y   �� 5m   
   -   5        $ label12��5m      $��Nombre de pièces��6!   $��2��6=   $��3��6M   �� 5n   
   -   5        $	 NbPieanc��5n      $��3��6I   $��3��6Y   ��6$   �� *RecupBien.NbPieces+6Y   �� 5p   
   -   5        $ label13��5p      $��Numéro d'étages ��6!   $��2��6=   $��4��6M   �� 5q   
   -   5        $	 	NumEtaanc��5q      $��4��6J   $��4��6Z   ��6%   �� *RecupBien.NumEtage+6Z   �� 5s   
   -   5        $ label14��5s      $��Montant charges ��6!   $��2��6>   $��5��6N   �� 5t   
   -   5        $	 MCanc��5t      $��4��6L   $��5��6\   ��6!   �� *RecupBien.MontantCharges+6\   �� 5v   
   -   5        $ label24��5v      $��Date mise en transaction ��6!   $��0��6G   $��8��6W   (  "System.Windows.Controls.DatePicker  5w   
   $��1��6g   $��8��6w      SelectedDate 6   �� *!RecupBien.DateMiseEnTransaction+ �� StringFormat$ 
yyyy-MM-dd��6w   �� 5z   
   -   5        $ label15��5z      $��Type chauffage��6!   $��2��6;   $��6��6K   �� 5{   
   -    5        $
 TypeChaufold��5{      $��3��6\   $��6��6l    6)   �� *RecupBien.TypeChauffage+��6y   �� # [ �� 5}   
   -!   5        $ label16��5}      $��Energie Chauffage��6!   $��2��6>   $��7��6N   �� 5~   
   -"   5        $
 energiechauffold��5~      $��3��6d   $��7��6t    6.   �� *RecupBien.EnergieChauffage+��6�   �� # [ �� 5�   
   -#   5         ��Name$ button��5�      $��VALIDER��6!   $��3��6G   $��8��6W   6g   5�      5�      