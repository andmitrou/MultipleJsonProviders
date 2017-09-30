## Welcome to the MultipleJsonProviders

### Introduction
***
MultipleJsonProviders is a very simple project allowing to integrate different json parsing frameworks and use them inside other projects through the abstracted layer of MultipleJsonProviders.

It is developed using a Structural software design pattern called the **Adapter Design Pattern**.
The base case of Adapter Design Pattern is that it enables conversion the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.


![Designer Pattern](http://www.dofactory.com/images/diagrams/net/adapter.gif)

Source: http://www.dofactory.com

## MultipleJsonProviders Analysis using Adapter Pattern
<br/>
<b>Target</b>: The Interface called **IJsonProvider**. It exposes two methods : Serialise,Deserialize that are exposed to the Client.
<br/>
<b>Adapter</b>: Is Any Class that it is located in JsonMultipleProviders.Providers namespace and implement the IJsonProvider interface.
<br/>
<b>Adaptee</b>: Any Json Framework that is used for serialisation, deserialisation. For example in that project it is used the embedded .net JavaScriptSeriazer and Newtonsoft.


