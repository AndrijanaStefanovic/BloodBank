   M S B A M L   `   `   `  ����D  @BloodBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BloodBank.ViewBloodBank.View  5   	       BloodBank.View.DonorView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BloodBank.View     5   	     � Title$  	DonorView��5   	   $	��450��6   $	��300��6(   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��lblId��5      $��0��5      $��0��5      $��Center=�5      $��Right=�5      $��Medical ID:��5      �� 5   
   -   5        $
��tbId��5%      $��1��5      $��0��5       $��Center=�5!      $
��Left=�5"      $	��150��5#      $��10,0,0,0q�5$      5%      �� 5'   
   -   5        $��lblName��5+      $��0��5'      $��1��5(      $��Center=�5)      $��Right=�5*      $��Name:��5,      �� 5-   
   -   5        $��tbName��53      $��1��5-      $��1��5.      $��Center=�5/      $
��Left=�50      $	��150��51      $��10,0,0,0q�52      53      �� 55   
   -   5        $��lblLastName��59      $��0��55      $��2��56      $��Center=�57      $��Right=�58      $��
Last name:��5:      �� 5;   
   -   5        $��
tbLastName��5A      $��1��5;      $��2��5<      $��Center=�5=      $
��Left=�5>      $	��150��5?      $��10,0,0,0q�5@      5A      �� 5C   
   -   5        $��lblEmail��5G      $��0��5C      $��3��5D      $��Center=�5E      $��Right=�5F      $��Email:��5H      �� 5I   
   -   5        $��tbEmail��5O      $��1��5I      $��3��5J      $��Center=�5K      $
��Left=�5L      $	��150��5M      $��10,0,0,0q�5N      5O      �� 5Q   
   -	   5        $��lblBloodType��5U      $��0��5Q      $��4��5R      $��Center=�5S      $��Right=�5T      $��Blood type:��5V      �� 5W   
   -
   5        $��cbBloodType��5]      $��1��5W      $��4��5X      $��Center=�5Y      $
��Left=�5Z      $��80��5[      $��10,0,0,0q�5\       �� DisplayMemberPath$ DisplayName��5^       �� SelectedValuePath$ Value��5_      ��5`      �� *
BloodTypes+]� 5b   
   $��1��6   $��5��5c      .+�5d      �� -   5        $��btnOK��5h      $	��Top=�5d      $
��Left=�5e      $��70��5f      $��	10,10,0,0q�5g      $��OK��5i      5j      �� 5k      -   5        $��	btnCancel��5o      $	��Top=�5k      $��Right=�5l      $��70��5m      $��10,10,10,10q�5n      $��Cancel��5p      5q      5r      5s      