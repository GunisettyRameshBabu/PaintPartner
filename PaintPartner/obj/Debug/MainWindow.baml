   M S B A M L   `   `   `  ����G  CPaintPartner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PaintPartnerPaintPartner  5   	   9!clr-namespace:PaintPartner.CommonPaintPartner.Common  5   	       PaintPartner.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PaintPartner     5   	   4common!clr-namespace:PaintPartner.Common     5   	     � Title$  PaintPartner��5
   	    � WindowState$ 	Maximized=�6   .��5      � ��5   
   �� 5       j� Stretch$
 None=�6A    �� ImageSource 6   �� *BackGroundSlide+6A    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      $��* �6   6)   �� 5      $��0.05* �6   6-   .+�5   
       PaintPartner.Common.Header  $��0��6   ���#064d79 � DataContext 6:   �� *Header+6[       PaintPartner.WelcomeScreen  5   
   $��Center=�6   $��Center=�6;   $��1��6V   $y�Hidden=�6c   $
��1200��5      $	��600��6+   
������  5      �� *WelcomeScreenViewModel+5   S      PaintPartner.LogIn  5   
   $��Center=�6   $��Center=�63   $��1��6N   $y�Visible=�6[   6r       PaintPartner.Common.Footer  5   
   $��2��6   6(   5      5      