   M S B A M L   `   `   `  ����N  JTM.DailyTrackR.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TM.DailyTrackR.ViewTM.DailyTrackR.View  5   	   $    TM.DailyTrackR.View.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:TM.DailyTrackR.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ TM Daily TrackR��5	   	   $	��450��6!   $	��800��6.    � 
ResizeMode$ 	CanResize=�5
   	    � Topmost$ False��5   	    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 �� TextAlignment  ComboboxTemplate �� Orientation��%f  &	        &	 1    �� 5   
   " ��6$   .�5      ��  � ��
 ���@�6?   �� 5       � ��$	 100��6'   65   �� 5       � ��$	 200��6&   64   �� 5       � ��
 �   �6;   �� 5       � ��$ 10q�6'   64   �� 5       � ��$
 Bold"�6+   6:   �� 5       � ��$ 20(�6)   66   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� 
����+��
������$��5q�6U   $	 10��6i   ._�5      �� $��Click��6(   $
 Center=�65   $��Center=�6L   $��2q�6g   6t   5      5      5      5       �� 5!   
   .R�5"      �� $ 
Horizontal=�6   .+�5#      �� $��20(�66   $
��Bold"�6D   ��6   �� *
Username+6X   �� 5$      $��=>��6   $��20(�6&   $
��Bold"�64   6H   �� 5%      $��20(�66   $
��Bold"�6D   ��6   �� *
Username+6X   5&      5'      5(      .��5*      �� .+�5/   
   �� ��6   �� *ListOfNumber+6:   �� 50   
   #��[  6   $��Delete��66   ��6G   �� *DeleteElementFromIndexExecute+6{   �� 51   
   $��	NewWindow��6   ��6%   �� *NewWindowComman+6K   52      5      