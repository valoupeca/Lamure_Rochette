   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   D @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ClientWPF.ServiceAgenceClientWPF.ServiceAgence 5   	   %clr-namespace:ClientWPF	ClientWPF 5   	       ClientWPF.Recherche_Simple   5   	   .sys&clr-namespace:System;assembly=mscorlib  5   	   +s%clr-namespace:ClientWPF.ServiceAgence  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ClientWPF     5   	     � Title$  Recherche_Simple��5
   	    � 	Resources 5         BienTypeProvider S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName  TypeTransac��%!  &	        &	 �     S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $$ s:BienImmobilierBase+eTypeBien��6   5      S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $+ %s:BienImmobilierBase+eTypeTransaction��6   5      5      .��5      �  � RowDefinitions 5   
   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6    � ColumnDefinitions 5*   
   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   .+�5/   
   �� -   5         ��Name$ label��5/      $��Type de Transaction��6   $��0��6=   $��0��6M   �� 50   
   -   5        $ label2��50      $��Type de Bien��6    $��0��67   $��1��6G   �� 51   
   -   5        $ label3��51      $
��Prix��6    $��0��6/   $��2��6?   �� 52   
   -   5        $ label4��52      $��Ville��6    $��0��60   $��3��6@   �� 53   
   -   5        	 ��Name$	 typebien��53      $��1��6%   $��0��65   
 �� SelectedValue
 6B   �� *
Bienselect+��6g   ��  �� Source# [  �� 54   
   -   5        $	 typetransaction��54      $��1��6,   $��1��6<   
 6I   �� *TransacSelect+��6r   �� # [ �� 55   
   -   5         ��Name$ 	prixentre��55      $��1��6&   $��2��66   �� 56   
   -   5        $ 
villeentre��56      $��1��6'   $��3��67   �� 57   
   -	   5         ��Name$ button��57      $(��"VALIDER VOS CRITERES DE RECHERCHES��6!   $��1��6N   $��4��6^   6�   59      5:      