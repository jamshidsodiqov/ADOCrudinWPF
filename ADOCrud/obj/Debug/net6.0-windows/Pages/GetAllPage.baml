   M S B A M L   `   `   `  ����B  >ADOCrud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ADOCrud.PagesADOCrud.Pages  5          ADOCrud.Pages.GetAllPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:ADOCrud.Pages  5        N� Title$  
GetAllPage��5
      .��5      �� 
�������._�5   
   � .+�5      �� -   5         ��Name$ exitgetall_btn��5      $	��Top=�5      $
��Left=�5      $��	20 20 0 0q�5      ���#F54126 &  "MaterialDesignIconForegroundButton#��[  5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
Backburger=�6*   5      ]� 5      $��5��6   .+�5      �� -   5        $ getall��5      $	��200��5      $��30��5      $��0 30 0 0q�5       $	��Top=�5!        MaterialDesignRaisedButton#��[ 5"      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5#      .��5$      �� $��GET ALL��6    5%      5&      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ DataGrid��5)      $��0,85,0,0q�5(       � 	Resources 5+      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�  '        '  �     �� 5,      "  6   .�5-      ��  � ��
 ���@�67   �� 5.       � ��$ SemiBold"�67   �� 5/       � ��$ 0,0,1,2q�6<   �� 50       � ��
 �   �68   �� 51       � ��$ Center=�6G   52      �� 53      "  6   .�54      ��  � ��$ SemiBold"�67   �� 55       � ��$ 0,0,1,2q�6<   �� 56       � ��
 �   �68   �� 57       � ��$ Center=�6G   58      59      	   Columns	 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn
   Header$
 id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5=      $
 	firstname��6)   $	 150 6Z    6<   �� *	FirstName+6Z     5>      $
 lastname��6)   $	 150 6X    6;   �� *
LastName+6X     5?      $
 email��6)   $	 250 6R    68   �� *Email+6R     5@      $
 password��6)   $ * 6X    6;   �� *
Password+6X   5B      5F      5G      5H      