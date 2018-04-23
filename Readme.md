# How to animate a map pushpin


<p>This example illustrates how to provide animation for a map pushpin.</p><p>To do this, it is necessary to create a <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfMapPushpinLocationAnimationtopic"><u>PushpinLocationAnimation</u></a> object and assign it to the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapMapPushpin_LocationChangedAnimationtopic"><u>MapPushpin.LocationChangedAnimation</u></a> property. After that it becomes possible to customize the animation duration (<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapPushpinLocationAnimation_Durationtopic"><u>PushpinLocationAnimation.Duration</u></a>) and easing function (<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapPushpinLocationAnimation_EasingFunctiontopic"><u>PushpinLocationAnimation.EasingFunction</u></a>). </p><p>In addition, you can change the pushpin state after its location animation is complete via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapPushpinLocationAnimation_Completedtopic"><u>PushpinLocationAnimation.Completed</u></a> event.  In this example, this event is used to change the pushpin location randomly each time the bouncing animation effect is complete. </p>

<br/>


