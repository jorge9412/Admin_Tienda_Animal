   M S B A M L   `   `   `  ����G  CAdminAlmacen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TiendaAnimalTiendaAnimal  5   	       TiendaAnimal.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TiendaAnimal     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5	   	    � Title$ 
Bienvenida��5   	   $	��600��5   	   $
��1000��5   	   .��5      � .+�5   
   �� $	��368��6   $	��Top=�6!    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5      ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF04294D��6#   � 5      $ 	#FF5CEC8E��6#    � Offset$ 1Q�65   � 5      $ 	#FF5CEC8E��6#   $ 1Q�65   5      5      �� 5    
   $	��384��6   $��Bottom=�6!   $��292,0,301,153q�6<    �� RadiusY$ 10��6S   	 �� RadiusX$	 10��6`   
������� 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"      
   
BlurRadius$
 20Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5$      �� 5%   
   $
��Left=�6   $��49��6+   $��
461,82,0,0q�67   $	��Top=�6K   $��49��6c   $��	/user.png��6n   �� 5'   
   $��Iniciar sesion��6   $
��Left=�6)   $	��Top=�6D   $��429,131,0,0q�6\   
�������$��18(�6�   �� 5)   
   -   5        $��txt_user��5)       �� 
CaretBrush �	#FF04294D)  #MaterialDesignThemes.Wpf.HintAssist   
Foreground �	#FF04294D.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF04294D$��391,166,388,355q�5,         Hint$ Usuario��5-       % !MaterialDesignFloatingHintTextBox#��[ 5.      $��Champagne & Limousines)�5/      $��18(�6:    J� RenderTransformOrigin$ 0.601,-1.432&�6H    � Cursor$ IBeam��6m   G� 50   
   -   5        $��txt_pass��50       G� 
CaretBrush �	#FF04294D �	#FF04294D$��391,250,388,271q�52       �	#FF04294D$ Contraseña��54       ) %MaterialDesignFloatingHintPasswordBox#��[ 55      $��Champagne & Limousines)�6U   $��18(�6}   $ IBeam��6�   �� 57   
   -   5         ��Name$ btn_ingresar��57      $	��150��6'   $��Center=�63   $	��Top=�6P   $��	0,348,0,0q�6h   $��Ingresar��6{   ���	#FF646161$
 Hand��6�   ��58      �� 59      $ 0.5,1&�6&   $ 0.5,0&�67   .��5:      � $ 	#FF04294D��6#   � 5;      $ 	#FF5CEC8E��6#   $ 1Q�65   5<      5>      5?      5@      