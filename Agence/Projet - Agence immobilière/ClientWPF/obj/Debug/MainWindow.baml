   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   D @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ClientWPF	ClientWPF 5   	   ;"clr-namespace:ClientWPF.ConvertersClientWPF.Converters 5   	      ClientWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   )localclr-namespace:ClientWPF     5   	   0c"clr-namespace:ClientWPF.Converters     5   	   -   5          � Title$2  ,Gestion de biens immobiliers Lamure Rochette��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      ( "ClientWPF.Converters.Base64toImage   simpleConverter��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��1px �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   o� -   5         o�Name$
 menu��5      $
��Left=�6   $��0��68   $��3��6H   .@�5      m� $��
_Recherche��6   .@�5      m� -   5        $��_Recherche Simple��5      66   m� 5       -   5        $��_Recherche Avancée��5       5!      5"      m� 5$      -   5        $��_Ajouter��5$      5&      m� 5'      -   5        $
��_Raz��5'      5)      5*      �� 5+   
   -   5         ��Name$
 bien��5+      $��0��6    $��1��60   $��2��6>   ��. $��Visible=�6w   ��6�   �� *ListeBien.List+ �� SelectedItem 6�   �� *Detail+ �� Mode$ TwoWay=���5,      �� 5-      .R�5.      �� 	 �� Orientation$	 Vertical=�6!   .+�5/      �� $	 
Horizontal=�6)   .+�50   "   �� $��100px��6(   ��67   �� *PhotoPrincipaleBase64+
 �� 	Converter#
 [  51      �� 52      $	 
Horizontal=�6)   .+�53   "   �� $��Titre du bien : ��6(   $
��Bold"�6C   6X   �� 54   "   ��6(   �� *Titre+55      �� 56      $	 
Horizontal=�6*   .+�57   "   �� $��Prix : ��6(   $
��Bold"�6:   6N   �� 58   "   ��6(   �� *Prix+6D   59      �� 5<      $	 
Horizontal=�6&   .+�5=      �� -   5        
 � Tag 5=   8   �� *Id+.��6K   Supprimer le bien6^   �� 5?      -	   5         5?   7   �� *Id+.��6J   Modifier le bien6\   5@      5A      5C      5E      �� 5F   
   $��2��6   $��5��6'   $��5��68   $��Stretch=�6B   � 5H   
   $��3��6   $��2��6    $��1��64    5J      �� 5K      $��* �6    �� 5L      $��* �6    �� 5M      $��* �6    �� 5N       5P      �� 5Q      $��* �6#   �� 5R      $��* �6#   .+�5W      �� $��0��6   $��0��6#   $��Center=�5X      $��Center=�5Y      ��5Z      �� *Bien.Bien.PhotosBase64+ 5[      �� *Photo+$ TwoWay=���5^      �� 5_      .R�5`      � 5a      ��5c      �� 5d      .R�5e      �� $	 Vertical=�6%   .+�5f      �� $	 Vertical=�6)   .+�5g   "   �� $
��50px��5h      $
��50px��5i      
���� ��$��1q�5k      ._�5l   &   ��  ��Name$ PhotoDetail��6,   $
��50px��6A   $
��50px��6N   $��Uniform=�6�   ��6\   �� #
 [  6�   5m   #   5n      5p      5q      5s      �� 5t      $��1��6   $��0��6)   .+�5u      �� ��6   �� *!Bien.Bien.PhotoPrincipaleBase64+#
 [  6z   5v      �� 5x      $��0��6   $��2��6'   $��1��6;   $��3��6H   ��. $��Visible=�5z   <   .@�5|      �� $	 Vertical=�6&   .+�5}      �� $	 
Horizontal=�6%   .+�5~      �� $��Titre du bien : ��6$   $
��Bold"�6?   6T   �� 5      ��6$   �� *Bien.Bien.Titre+5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Type de Bien : ��6$   $
��Bold"�6>   6R   �� 5�      ��6$   �� *Bien.Bien.TypeBien+6N   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Type Chauffage : ��6$   $
��Bold"�6@   6T   �� 5�      ��6$   �� *Bien.Bien.TypeChauffage+6S   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Energie Chauffage : ��6$   $
��Bold"�6C   6W   �� 5�      ��6$   �� *Bien.Bien.EnergieChauffage+6V   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Type Transaction : ��6$   $
��Bold"�6B   6V   �� 5�      ��6$   �� *Bien.Bien.TypeTransaction+6U   5�      �� 5�      $	 
Horizontal=�6%   .+�5�      �� $��Prix : ��6$   $
��Bold"�66   6K   �� 5�      ��6$   �� *Bien.Bien.Prix+5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��
Adresse : ��6$   $
��Bold"�69   6M   �� 5�      ��6$   �� *Bien.Bien.Adresse+6M   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Code postal : ��6$   $
��Bold"�6=   6Q   �� 5�      ��6$   �� *Bien.Bien.CodePostal+6P   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Ville : ��6$   $
��Bold"�67   6K   �� 5�      ��6$   �� *Bien.Bien.Ville+6K   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Description : ��6$   $
��Bold"�6=   6Q   �� 5�      ��6$   �� *Bien.Bien.Description+6Q   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��
Surface : ��6$   $
��Bold"�69   6M   �� 5�      ��6$   �� *Bien.Bien.Surface+6M   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Nombres d'étages : ��6$   $
��Bold"�6B   6V   �� 5�      ��6$   �� *Bien.Bien.NbEtages+6N   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Nombres Pièces : ��6$   $
��Bold"�6@   6T   �� 5�      ��6$   �� *Bien.Bien.NbPieces+6N   5�      �� 5�      $	 
Horizontal=�6&   .+�5�      �� $��Numéro d'étage : ��6$   $
��Bold"�6@   6T   �� 5�      ��6$   �� *Bien.Bien.NumEtage+6N   5�      5�      5�      5�      5�      5�      