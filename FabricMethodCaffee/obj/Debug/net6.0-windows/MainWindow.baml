   M S B A M L   `   `   `  ����M  IFabricMethodCaffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FabricMethodCaffeeFabricMethodCaffee  5   	   #    FabricMethodCaffee.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FabricMethodCaffee     5   	     � Title$  
MainWindow��5   	   $��JetBrains Mono)�5	   	   $��20(�5
   	   
�����w�$
��1019��5   	   $
��Auto��5   	    � 	Resources 5      -   'FabricMethodCaffee.DoubleToIntConverter   DoubleToIntConverter �� 
TargetType  ChatTextboxStyle �� Property �� Value  SendMesgTextBox��%P  &	        &	      &	 z    '�� �      5   
   6%   �� 5   
   " ��6   �5      �� 5       �@��TextWrapping$
 Wrap=�61   �� 5       � ��$	 400��6*   �� 5       � ��$	 400��6+   �� 5       � ��$	 300��6-   �� 5      # �@��VerticalScrollBarVisibility$
 Auto=�6@   �� 5       � ��$ 10q�6+   �� 5       �@��
IsReadOnly$
 True��6/   5      �� 5   
   " ��6   �5      �� 5        �@��TextWrapping$
 Wrap=�61   �� 5!       � ��$ 50��6+   �� 5"       � ��$	 300��6*   �� 5#      # �@��VerticalScrollBarVisibility$
 Auto=�6@   �� 5$       � ��$ 10q�6+   5&      �� 5'   
   " ��6   �5(      �� 5)       � ��$
 Bold"�6/   �� 5*       � ��
 �����6/   �� 5+       � ��$ 40(�6-   5-      5.      .��50      � -   5         �Name$ ContentGrid��50      $��Center=�51   	   $��Center=�6$    � RowDefinitions 52   
   �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $
��Auto �6   .+�58   
   �� -   5         ��Name$ UserSelectionBox��59      $��Center=�5:      $��Center=�5;      $	��200��5<      $��Center=�5=      .@�5?      �� $	��Bob��6   �� 5@      $	��Rob��6   �� 5A      $
��Alex��6   5B      � 5D   
   $��1��6   .+�5E      �� -   5         ��Name$ BobPanel��5E      $��Center=�6+   $y�Visible=�6H   .+�5F      �� $	��Bob��6   $��Center=�6'   �� 5G      -   5        	 ��Name$	 BobChatTextBox��5G      #��[ 62   �� 5H      -   5        $	 
BobTextBox��5H      #��[ 6.   5I      �� 5J      -   5        $ RobPanel��5J      $��Center=�6+   $y�Hidden=�6H   .+�5K      �� $	��Rob��6   $��Center=�6'   �� 5L      -   5        $	 RobChatTextBox��5L      #��[ 62   �� 5M      -   5        $	 
RobTextBox��5M      #��[ 6.   5N      �� 5O      -	   5        $ 	AlexPanel��5O      $��Center=�6,   $y�Hidden=�6I   .+�5P      �� $
��Alex��6   $��Center=�6(   �� 5Q      -
   5        $	 AlexChatTextBox��5Q      #��[ 63   �� 5R      -   5        $	 AlexTextBox��5R      #��[ 6/   5S      5T      �� 5V   
   $��2��6   $��Center=�6"   $��Center=�6=   $��10q�6Z   .+�5W      �� -   5        $ 	SendToBox��5W      $��Center=�5X      $��Center=�5Y      $	��200��5Z      .@�5[      �� $	��Bob��6   �� 5\      $	��Rob��6   �� 5]      $
��Alex��6   �� 5^      $	��All��6   5_      �� 5`      -   5        
 ��Name$
 SendButtonSync��5`      $��	Send Sync��6-   $	��200��6A   $��0, 10, 0, 10q�6M   6c   �� 5a      -   5        $
 SendButtonASync��5a      $��
Send ASync��6.   $	��200��6C   6O   �� 5c      $	��200��6    �� Orientation$ 
Horizontal=�5d      $��Center=�62   .+�5e      �� -   5         ��Name$ DelayBar��5f       �� Orientation$ 
Horizontal=�5g      $	��100��5h      $��30��6!    � Maximum$ 10Q�5i       � Minimum$ 1Q�6"   �� 5j      -   5         ��Name$ DelayValueTextBox��5j      $��10��5p      
���   �$��20q�5r      ��5k      ��  �� ElementName$ DelayBar�� �� Path$ Value� �� 	Converter# [  5r      5s      5u      5z      5|      