   M S B A M L   `   `   `  ����K  GBlogSystemClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BlogSystemClient.ViewsBlogSystemClient.Views  5   	   I)clr-namespace:BlogSystemClient.ViewModelsBlogSystemClient.ViewModels  5   	   C&clr-namespace:BlogSystemClient.HelpersBlogSystemClient.Helpers  5   	   !    BlogSystemClient.MainWindow   5   	   .Views$clr-namespace:BlogSystemClient.Views  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @
ViewModels)clr-namespace:BlogSystemClient.ViewModels     5   	   =
converters&clr-namespace:BlogSystemClient.Helpers     5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�6    � DataContext 5      1   +BlogSystemClient.ViewModels.MasterViewModel  5   
    � 	Resources 5
       �� 
TargetType �� Property �� Value �� DataType8   2BlogSystemClient.ViewModels.LoginRegisterViewModel.   (BlogSystemClient.Views.LoginRegisterView8   2BlogSystemClient.ViewModels.CreateArticleViewModel.   (BlogSystemClient.Views.CreateArticleView8   2BlogSystemClient.ViewModels.CreateCommentViewModel.   (BlogSystemClient.Views.CreateCommentView8   2BlogSystemClient.ViewModels.SingleArticleViewModel.	   (BlogSystemClient.Views.SingleArticleView;
   5BlogSystemClient.ViewModels.CreateSubcommentViewModel1   +BlogSystemClient.Views.CreateSubcommentView3   -BlogSystemClient.ViewModels.ArticlesViewModel)   #BlogSystemClient.Views.ArticlesView6   0BlogSystemClient.ViewModels.EditArticleViewModel,   &BlogSystemClient.Views.EditArticleView8   2BlogSystemClient.Helpers.BoolToVisibilityConverter   boolToVisibilityConverter��%�  '��       (�� v     5      *, +)(�� �     5      *, +)(�� �     5      *, +)(��     5      *, +)(�� N    5       *,
 +)(�� �    5$      *, +)(�� �    5(      *, +)&	  �    �� 5   
   " ��6   .�5      ��  � ��$ 85��6&   63   �� 5       � ��$ 30��6'   64   5      �� 5   
   "  5      .R�5        5      �� 5   
   "  5      .R�5        5      �� 5   
   "  5      .R�5        5      �� 5   
   "  5      .R�5      	  5      �� 5   
   " 
 5       .R�5!        5"      �� 5#   
   "  5$      .R�5%        5&      �� 5'   
   "  5(      .R�5)        5*        5+   
   6/   5,      .��5-      �� $	��500��6   .+�5.   
   �� ��6   �� *CurrentViewModel+�� 5/   
   $��Logout��6   y�6"   �� *IsLogoutVisible+ �� 	Converter# [  ��6~   �� *Logout+50      51      