   M S B A M L   `   `   `  ����  CH09.PathBasedAnimation(    "CH09.PathBasedAnimation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         rg E� IsClosed E� 
StartPoint � Points��%�   &	        B� 5   
   .��5      E�  . $ 20,20&�6)   .��5      � 1 �    �� -1 �� �� -1 �� -1 ��6"   5	      5
      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   .+�5      A� -   5         A�Name$ e1��5      
���  ��
���   �$��2��5   0   $��40��6D   $��40��6O    �� Left$ 20��5   "   
 �� Top$ 20��63   5      �� 5   
   $��Start Animation��6   $��16(�6+   $��8q�69   	 � Triggers	 5      :� 5      
 :� RoutedEvent$
 Button.Click��6   .[�5      �� .��5      �� .��5      T�  g� Duration$ 0:0:3D�67    �� 
TargetName$ e1��5   7    �� TargetProperty$ (Canvas.Left)�5   7    T� PathGeometry# [  5   7    T� Source$ X=�6Z   T� 5      $ 0:0:3D�67   $ e1��5   7   $ (Canvas.Top)�5    7   # [  5!   7   $ Y=�6Z   5"      5#      5$      5&      5'      5(      