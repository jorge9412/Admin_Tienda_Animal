   M S B A M L   `   `   `  ����G  CAdminAlmacen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AdminAlmacen.VistasAdminAlmacen.Vistas  5   P       AdminAlmacen.Vistas.envio   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8
viewmodels!clr-namespace:AdminAlmacen.Vistas     6P     � Title$  envio��5   	   $	��600��6   $
��1000��6$    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	   
������  � 	Resources 5       �� DataType"   AdminAlmacen.Vistas.Usuarios � DataContext��%j   (��       5      *, +)�� 5   
   Usuarios��"  5      .R�5         6"   �� 5      5      .��5      ��  �� CornerRadius$ 10��6   
�������._�5   
   � -   5         �Name$ 	Principal��5      
������ 	 � RowDefinitions	 5      �� 5      $
��151* �6    �� 5      $
��149* �6    .+�5      � -   5        $ Header��5      $��35��5      $	��Top=�5      
������ .+�5       �� $ 	10,10,0,0��6   
 J� Opacity$	
 0.9Q�62   ��5!      �� 5"       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5#      �  � Color$ 	#FF04294D��6+   � 5$      $ 	#FF5CEC8E��6+    � Offset$ 1Q�6=   5%      5'      � 5(       � ColumnDefinitions 5)      �� 5*      �� 5+      �� 5,      .+�5.      �� $��App de Envios��6    $��0��5/       $��20,0,0,0q�50       
�������$��15(�52       $
��Left=�53       $��Center=�54       �� 56      -   5         ��Name$ 	BtnCuenta��56      $��1��57      
������ 
������ $��15(�5:      
���   �$��Center=�5<      $
��Left=�5=       � Cursor$
 Hand��5>      .��5?      �  5@      �� 5A   "   $��15 �63   �� 5B   "   .+�5D      �� $��1��6(   $��	Mi cuenta��5E   (   
�������$��Center=�5G   (   $��Center=�5H   (   $��5,0,0,0q�5I   (   �� 5J      $��0��6$   $��Center=�5K   $   $��Center=�5L   $   $��/Vistas/config.png��5M   $   5N      5O      �� 5Q      -   5        $ BtnInfo��5Q      $��1��5R      
������ 
������ 
���   �$��15(�5V      $��Right=�5W      $��Center=�5X      $
 Hand��5Y      .��5Z      � 	 5[      �� 5\   "   $	��21* �60   �� 5]   "   $��4* �60    5_      �� 5`   "   $��15 �63   �� 5a   "   .+�5c      �� $��/Vistas/info.png��6$   $��0��5d   $   $	��Top=�5e   $   $��-5,2,0,0q�6<   $��2��6N   �� 5f      $��	Acerca de��6(   $��1��5g   (   
�������$
��Left=�5i   (   $	��Top=�5j   (   $��3,1,0,0q�5k   (   $��2��69   5l      5m      �� 5o      -   5        $ BtnMinimizar��5o      $��2��5p      
������ 
������ $��30��5s      $��50��5t      $��Right=�5u      $	��Top=�5v      $��	0,-3,55,0q�5w      .��5x      �� $��/Vistas/minimizar.png��6    $
 Hand��5y   !   $��59��6/   $��40��6;   5z      �� 5|      -   5        $ 	BtnCerrar��5|      $��2��5}      
������ 
������ $��30��5�      $��50��5�      $��Right=�5�      $	��Top=�5�      $��0,5,5,0q�5�      .��5�      �� $��/Vistas/close2.png��6    $
 Hand��5�   !   5�      5�      5�      � 5�      -   5        $ GridContent��5�      
������ $��Bottom=�5�      $��Right=�5�      $	��565��5�      $	��925��5�      $��2��6    5�      �� 5�      $	��29* �6'   �� 5�      $	��29* �6'   �� 5�      $	��29* �6'   �� 5�      $
��129* �6'   �� 5�      $	��29* �6'   	 5�      �� 5�      $	��36* �6$   �� 5�      $	��36* �6$   .+�5�      �� -   5        $ 0,0,0,10��5�      $	
 0.9Q�5�      
�������$��2��5�   `   $��5��6q   $��3,0,-3,0q�6�   ._�5�      �� -	   5        $��img_logo��5�      $
��Left=�6,   $	��Top=�6G   $	��738��6_   $��/Vistas/adminEnBlanco.png��6k   $��
138,84,0,0q�6�   $	��362��6�   5�      �� 5�      $��2��65   $��5��6F   $��Center=�6Z   ��6!   �� 6Z   5�      � 5�      -
   5        $ GridMenu��5�      
������ $��75��5�      $
��Left=�5�      $��0,35,0,0q�5�      $��2��6%   .+�5�      �� $	
 0.9Q�6   $ 0,0,0,10��5�      ��5�      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ 	#FF5CEC8E��6+   � 5�      $ 	#FF04294D��6+   $ 1Q�6=   5�      5�      �� 5�      $	��Top=�5�      ��5�      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ 	#FF04294D��6+   � 5�      $ 	#FF5CEC8E��6+   $ 1Q�6=   5�      .+�5�      � 
������ $	��Top=�5�      $��Right=�5�      $��	0,10,10,0q�5�      	 5�      �� 5�      $	��19* �6,   �� 5�      $	��11* �6,   .+�5�      d� -   5         d�Name$ BtnShowHide��5�   '   $��30��5�   '   $��30��5�   '   $
 Hand��5�   '   
������ $��2��5�   A    � ToolTip$
 Menu��5�   '    � Triggers 5�      :� 5�   "    :� RoutedEvent$ ToggleButton.Unchecked��6/   .[�5�   &   �� .��5�   *   �� -   5         ��Name$ 	HidePanel��5�   5   .��5�   .   W�  �� 
TargetName$ GridMenu��6>    �� TargetProperty$ Width�5�   >    g� 	BeginTime	 0:0:05�   >    W� From 2005�   >   	 W� To 756I    g� Duration$ 	0:0:0:0.5D�5�   >   5�   +   5�   '   5�   #   :� 5�   "   $ ToggleButton.Checked��6/   .[�5�   &   �� .��5�   *   �� -   5        $ 	ShowPanel��5�   5   .��5�   .   W� $ GridMenu��6>   $ Width�5�   1   	 0:0:05�   1    755�   1    2006;   $ 	0:0:0:0.5D�5�   1   5�   +   5�   '   5�   #   5�      5�      �� 5�      
������ 
������ $��0,10,0,0q�5�      $��Disabled=�5�      .@�5�      �� $��70��6'   $	��197��63   .��5�      �� -   5        $ 	BtnInicio��5�   %   $��70��5�   %   $��85��5�   %   $
��Left=�5�   %   $
 Hand��5�   %   
������ 
������ $��	-20,0,0,0q�5�   %   .��5�   "   � $	��200��6'   	 5�   &   �� 5�   *   $	��13* �68   �� 5�   *   $	��31* �68    5  &   �� 5  *   $��60 �6;   �� 5  *   .+�5  &   �� $��50��6,   $��Center=�5  ,   $��/Vistas/home.png��5  ,   $��2��6F   $
 Home��5  ,   �� 5
  &   $��1��60   $��Inicio��5  0   $��SemiBold"�5  0   $��15(�5  0   $	��Top=�5  0   $��Center=�5  0   $��0,12,0,0q�6M   $��2��6_   5  #   5     5     �� 5     $��70��6'   .��5     �� -   5        $ 	BtnEnvios��5  %   $��70��5  %   $��85��5  %   $
��Left=�5  %   $
 Hand��5  %   
������ 
������ $��	-20,0,0,0q�5  %   .��5  "   � $	��200��6'    5   &   �� 5!  *   $��60 �6;   �� 5"  *   .+�5$  &   �� $��50��6,   $��Center=�5%  ,   $��/Vistas/entrega.png��5&  ,   $��44��6I   $	��Top=�6U   $ Envios��5'  ,   �� 5(  &   $��1��5)  )   $��Envios��5*  )   $��SemiBold"�5+  )   $��15(�5,  )   $��Center=�5-  )   $��Center=�5.  )   $��36��6F   $	��120��6R   5/  #   50     51     �� 54     $��70��6'   .��55     �� -   5        $ BtnPersonas��55  %   $��70��56  %   $	��200��57  %   $
��Left=�58  %   $
 Hand��59  %   
������ 
������ $��	-20,0,0,0q�5<  %   .��5>  "   � $	��200��6'    5?  &   �� 5@  *   $��60 �6;   �� 5A  *   .+�5C  &   �� $��50��6,   $��0��5D  ,   $��Center=�5E  ,   $��/Vistas/red.png��5F  ,   $ Usuarios��5G  ,   �� 5H  &   $��1��60   $��Personas��5I  0   $��SemiBold"�5J  0   $��15(�5K  0   $��Center=�5L  0   $��Center=�5M  0   5N  #   5O     5P     5R     5T     5U     5W     5X     5Y     