   M S B A M L   `   `   `  ����  FluentLingua    FluentLingua.LessonsList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  LessonsList��5       � 	Resources 5
       �� 
TargetType �� Triggers �� Binding �� Property �� Value   	itemstyle��%�   '��       &	  �     �� 5   
   " ��6    5      �� 5       6   �� *IsLsnCompleted+.a�5      ��  � ��
 ����63   5      5      �� 5   
   " ��6"   .�5      -   5        5      5      .��5      � .+�5   
    � -   5          �Name$ 	ListFrame��5      $��0,50,0,0q�6#   67   �� 5   
   -   5         ��Name$ l_List__��5   �   $
��20px(�6   #��[  6B   $��0,50,0,0q�6r   	 �� SelectedIndex$	 0��6�   ��6#   �� *l_List+
 �� View
 5      �� 5      -   5        GridView��.P�5      �� $��
Номер��6S    �� Width$ 50��6b    �� DisplayMemberBinding 6%   �� *LessonNumber+6b   �� 5      $��Название��6Q   $	 550��6c    6%   �� *
LessonName+6c   5$      5&      5'      5(      