   M S B A M L   `   `   `  ����O  KCH04.ContentControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CH04.ContentControlsCH04.ContentControls  5   	   %    CH04.ContentControls.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4local"clr-namespace:CH04.ContentControls     5   	     � Title$  
MainWindow��5   	   $
��Auto��6   $	��525��6*    � 	Resources 5      !  CH04.ContentControls.Person
   Age   Name   p1��%;   &	          5   
   $ 10��6   $
 Bart��6    6,   5      .��5	      �� .+�5
   
   �� $��Click me��6   $��4q�6$   $��4q�6/   $��16(�5      $
��Left=�6   �� 5   
   $��4q�6   $
��Left=�6   $��4q�67   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��copy.png��6   $��16��6*   $��16��65   �� 5      $
��Copy��6   $��10,0,0,0q�6(   $��Center=�5      $��16(�67   5      5      �� 5   
   #��[  6   $��16(�6/   $��4q�5      $��4q�6   $
��Left=�6(   �� 5   
   #��[  6   $��16(�6/   $��4q�5      $��4q�6   $
��Left=�6(   ��5      �� 5      .R�5      � $��16(�6    � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5       � RowDefinitions 5      �� 5       $
��Auto �6,   �� 5!      $
��Auto �6,   .+�5#      �� $��Name:��6$   �� 5$      $��6,0,0,0q�5%   $   
����  �$��1��5&   6   ��5$   $   �� *Name+5&   6   �� 5'      $
��Age:��6$   $��1��60   �� 5(      $��6,0,0,0q�5)   $   $��1��65   
���  ��$��1��5*   5    �� TextAlignment$ Right=�5+   $   ��5(   $   �� *Age+5+   $   5,      5-      5/      �� 51   
   $��10q�6   ��52      �� 53      $ 
Horizontal=�6   .+�54      �� $��cup.png��6   �� 55      $��Tea options��6    $��6,0,0,0q�63   56      .��58      �� .+�59      �� $��4q�6   .��6&   Sugar6-   �� 5:      $��4q�6   .��6&   Mint6,   �� 5;      $��4q�6   .��6&   Milk6,   �� 5<      $��4q�6   .��6&   
Cinnamon60   5=      5>      9� 5@   
   -   5         9�Name$ 	_bookInfo��5@      $��10q�6   	 9� ExpandDirection$
	 Down=�62   ��5A      �� 5B      .R�5C      �� 
����  �$��1q�60   
 �� Padding$
 4q�6D   ._�5D      �� ��6$   �� *Name+ �� StringFormat$ 	Book: {0}��5E      5F      ��5H      �� 5I      .R�5J      �� 
����  �$��2q�60   $
 4q�6D   ._�5K      �� .+�5L      �� ��6(   �� *Name+$ 	Name: {0}���� 5M      ��6(   �� *Author+$ Author: {0}���� 5N      ��6(   �� *YearPublished+$ Published: {0}��5O      5P      5Q      5S      5U      5V      