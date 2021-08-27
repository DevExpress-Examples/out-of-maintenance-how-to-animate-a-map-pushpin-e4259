<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571132/12.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4259)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/PushpinLocationAnimation/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PushpinLocationAnimation/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/PushpinLocationAnimation/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PushpinLocationAnimation/MainWindow.xaml.vb))
<!-- default file list end -->
# How to animate a map pushpin


<p>This example illustrates how to provide animation for a map pushpin.</p><p>To do this, it is necessary to create a <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfMapPushpinLocationAnimationtopic"><u>PushpinLocationAnimation</u></a> object and assign it to the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapMapPushpin_LocationChangedAnimationtopic"><u>MapPushpin.LocationChangedAnimation</u></a> property. After that it becomes possible to customize the animation duration (<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapPushpinLocationAnimation_Durationtopic"><u>PushpinLocationAnimation.Duration</u></a>) and easing function (<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapPushpinLocationAnimation_EasingFunctiontopic"><u>PushpinLocationAnimation.EasingFunction</u></a>). </p><p>In addition, you can change the pushpin state after its location animation is complete via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapPushpinLocationAnimation_Completedtopic"><u>PushpinLocationAnimation.Completed</u></a> event.  In this example, this event is used to change the pushpin location randomly each time the bouncing animation effect is complete. </p>

<br/>


