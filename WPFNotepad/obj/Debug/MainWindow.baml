   M S B A M L   `   `   `  ����E  AWPFNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFNotepad
WPFNotepad  5   	   =#clr-namespace:WPFNotepad.ViewModelsWPFNotepad.ViewModels  5   	       WPFNotepad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFNotepad     5   	   :
viewmodels#clr-namespace:WPFNotepad.ViewModels     5   	     � Title$  	Notepad--��5	   	   $	��400��6   $	��525��6(    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      )   #WPFNotepad.ViewModels.MainViewModel  5   
   .��5      ]� $��5q�6   .+�5   
   o� $	��Top=�6   @�5      m� 5      $
��File��6    63   �� *File+.@�5      m� $	��New��6    m� Command 63   �� *
NewCommand+m� 5      $
��Open��6    63   �� *OpenCommand+m� 5      $
��Save��6    63   �� *SaveCommand+m� 5      $��
Save as...��6    63   �� *SaveAsCommand+m� 5      $��Print...��6    63   �� *PrintCommand+5      m� 5      $��Format��6    62   �� *Editor+.@�5       m� $��Format��6    62   �� *FormatCommand+m� 5!      $��	Word wrap��6    62   �� *WrapCommand+ m� 	IsChecked 6R   �� *Format.isWrapped+5"      m� 5$      $
��Help��6    6.   �� *Help+.@�5%      m� $��About��6    6.   �� *HelpCommand+5&      5*      ]� 5,   
   .+�5/      �� $��Bottom=�6    50      �� *File.Document+��51      �� *
FilePath+�� 54      $	��Top=�6    �� AcceptsReturn .  �� 
AcceptsTab .  55      �� *Editor+��56      �� *Format.Family+��57      �� *Format.Size+��58      �� *Format.Style+ �� TextWrapping 59      �� *Format.Wrap+��5:      �� *Format.Weight+��5=      �� *Document.Text+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�5>      5?      5@      