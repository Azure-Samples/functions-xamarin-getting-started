# Implementing a simple Azure Function with a Xamarin.Forms client

![Azure Functions logo](./Doc/Img/Azure-Functions-Logo.png)

[Azure Functions](http://gslb.ch/a10) are a great way to implement an API in an easy manner, without any deployment or maintenance headaches. You can implement the code in the Azure Web Portal directly (or in Visual Studio if you prefer, of course). Functions are also running at a very interesting cost, since they are only billed when they are actually executed. If your business is just starting and you have only a few users, the costs will be very low. Later when the business expands, you have the possibility to switch to a different plan making it easier to budget your costs.

Because they are very easy to implement and maintain, and accessible through HTTP, Azure Functions are a great way to implement an API for a mobile application. Microsoft offers great cross-platform tools for iOS, Android and Windows with [Xamarin](https://developer.xamarin.com). As such, Xamarin and Azure Functions are working great together. This article will show how to implement a very simple Azure Function in the Azure Web Portal or in Visual Studio at first, and build a cross-platform client with Xamarin.Forms, running on Android, iOS and Windows. 

Later we will refine this application by using the JavaScript Object Notation JSON as a communication medium between the server and the mobile clients.

## Table of content

- [Implementing the first version of the Xamarin.Forms client app](./Doc/first-client.md).

- [Creating the Azure Function in the Azure Web Portal](./Doc/creating.md).

    - [Modifying the function's interface and implementing it](./Doc/implementing.md).

- [Creating the Azure Function in Visual Studio](./Doc/creating-vs.md).

- [Modifying the Xamarin.Forms client app to use the Azure Function](./Doc/second-client.md).

## Modifying the application to use JavaScript Object Notation JSON instead

In this section, we will modify the function application interface to use JSON instead of normal text to pass the result to the client.

- [Modifying the server application to use JSON](./Doc/refactoring.md).

- [Modifying the client application to use JSON](./Doc/refactoring-client.md).

