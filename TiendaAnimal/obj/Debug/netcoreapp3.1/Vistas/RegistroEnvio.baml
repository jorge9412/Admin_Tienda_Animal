   M S B A M L   `   `   `  ����G  CAdminAlmacen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AdminAlmacen.VistasAdminAlmacen.Vistas  5   	   '    !AdminAlmacen.Vistas.RegistroEnvio   5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AdminAlmacen.Vistas     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5	   	    � Title$ Registro Envio��5   	   $	��600��6    $
��1000��6-   .��5      � $��0,0,0,10q�6   $	��600��6   $
��1000��6*   .+�5   
   �� $	��414��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF04294D��6#   � 5      $ 	#FF5CEC8E��6#    � Offset$ 1Q�65   � 5      $ 	#FF5CEC8E��6#   $ 1Q�65   5      5      �� 5   
   $	��509��6   $	��Top=�6!   $��209,25,44,0q�69    �� RadiusY$ 10��6N    �� RadiusX$ 10��6[   
�������	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5!      �� 5#   
   -   5         ��Name$ txt_nombre_cliente��5#      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Cliente��6.      
Foreground �	#FF04294D.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF04294D % !MaterialDesignFloatingHintTextBox#��[ 5&      $��Champagne & Limousines)�6M   $��18(�6u   $��227,86,540,452q�6�    � Cursor$ IBeam��6�   �� 5'   
   -   5        $ txt_apellidos_cliente��5'       �	#FF04294D �	#FF04294D �� 
CaretBrush �	#FF04294D$ 	Apellidos��5+      #��[ 6=   $��Champagne & Limousines)�6x   $��18(�6�   $��480,86,286,452q�6�   $ IBeam��6�   �� 5,   
   -   5        $ txt_cedula_cliente��5,       �	#FF04294D �	#FF04294D �	#FF04294D$ Cedula��50      #��[ 6:   $��Champagne & Limousines)�6u   $��18(�6�   $��728,84,58,452q�6�   �� 51   
   -   5        $ txt_celular_cliente��51       �	#FF04294D �	#FF04294D �	#FF04294D$ Celular��55      #��[ 6;   $��Champagne & Limousines)�6v   $��18(�6�   $��227,148,540,393q�6�   �� 56   
   -   5        $ txt_correo_cliente��56       �	#FF04294D �	#FF04294D �	#FF04294D$ Correo��5:      #��[ 6:   $��Champagne & Limousines)�6u   $��18(�6�   $��480,148,287,393q�6�   �� 5;   
   -   5        $ txt_direccion_cliente��5;       �	#FF04294D �	#FF04294D �	#FF04294D$ 
Dirección��5?      #��[ 6=   $��Champagne & Limousines)�6x   $��18(�6�   $��728,148,58,393q�6�   �� 5@   
   -   5         ��Name$ btn_guardar_envio��5@      $	��150��6,   $
��Left=�68   $��Bottom=�6S   $��
760,0,0,55q�6n   $��Guardar��6�   $��Normal"�6�   ���	#FFF3F1F7��5A      �� 5B      $ 0.5,1&�6&   $ 0.5,0&�67   .��5C      � $ 	#FF04294D��6#   � 5D      $ 	#FF5CEC8E��6#   $ 1Q�65   5E      5G      �� 5I   
   -   5        $ btn_cerrar_registro��5I      $	��156��6.   $
��Left=�6:   $��Bottom=�6U   $��
304,0,0,55q�6p   $��Cerrar��6�   $��Normal"�6�   ���	#FFF3F1F7$
 Hand��6�   ��5J      �� 5K      $ 0.5,1&�6&   $ 0.5,0&�67   .��5L      � $ 	#FF04294D��6#   � 5M      $ 	#FF5CEC8E��6#   $ 1Q�65   5N      5P      �� 5R   
   $��Información origen��6   $
��Left=�6-   $	��Top=�6H   $��
208,25,0,0q�6`   
�������$��28(�6�   ���	#FF5CEC8E$	��748��6�   �� 5S   
   -	   5         ��Name$ logoRegistro_��5S      $
��Left=�6'   $��36��6B   $��
910,28,0,0q�6N   $	��Top=�6b   $��44��6z   $w��qC:\Users\Asus\OneDrive\Documentos\Pascual bravo\HERRAMIENTAS 3\Admin_Tienda_Animal\TiendaAnimal\Assets\enviar.png��6�   $
��Fill=�6    �� StretchDirection$
 Both=�6  �� 5T   
   $��Información destino��6   $
��Left=�6.   $	��Top=�6I   $��209,251,0,0q�6a   
�������$��28(�6�   ���	#FF5CEC8E$	��747��6�   �� 5U   
   -
   5        $ txt_nombre_destinatario��5U       �	#FF04294D �	#FF04294D �	#FF04294D$ Nombre destinatario��5Y      #��[ 6G   $��Champagne & Limousines)�6�   $��18(�6�   $��482,294,285,244q�6�   $ IBeam��6�   �� 5Z   
   -   5        $ 	txt_fecha��5Z      ${�False��6%    �	#FF04294D �	#FF04294D �	#FF04294D$ Fecha creación��5^      #��[ 6B   $��Champagne & Limousines)�6}   $��18(�6�   $��227,295,539,243q�6�   $ IBeam��6�   �� 5_   
   -   5        $ txt_ciudad_destino��5_       �	#FF04294D �	#FF04294D �	#FF04294D$ Ciudad destino��5c      #��[ 6B   $��Champagne & Limousines)�6}   $��18(�6�   $��728,355,58,181q�6�   �� 5d   
   -   5        $ txt_ciudad_origen_envio��5d       �	#FF04294D �	#FF04294D �	#FF04294D$ Ciudad origen��5h      #��[ 6A   $��Champagne & Limousines)�6|   $��18(�6�   $��481,360,286,181q�6�   �� 5i   
   -   5        $  txt_direccion_destinatario��5i       �	#FF04294D �	#FF04294D �	#FF04294D$ Dirección destino��5m      #��[ 6E   $��Champagne & Limousines)�6�   $��18(�6�   $��728,296,58,245q�6�   �� 5n   
   -   5        $ txt_precio_envio��5n       �	#FF04294D �	#FF04294D �	#FF04294D$ Precio��5r      #��[ 6:   $��Champagne & Limousines)�6u   $��18(�6�   $��226,356,540,182q�6�   $ IBeam��6�   �� 5s   
   -   5        $ txt_descripcion_envio��5s       �	#FF04294D �	#FF04294D �	#FF04294D$ Descripción��5w      #��[ 6?   $��Champagne & Limousines)�6z   $��18(�6�   $��226,423,58,115q�6�   $ IBeam��6�   5x      5y      