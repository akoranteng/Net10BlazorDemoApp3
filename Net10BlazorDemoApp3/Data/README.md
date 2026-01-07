# 02 – Product Service

This branch introduces the `ProductService`, which provides sample product data to the application. It builds on the `Product` model created in the previous branch and establishes the foundation for data access in the app.

## 📁 Files Added

- `Data/ProductService.cs`

## 🎯 Purpose

The ProductService demonstrates how Blazor apps retrieve and manage data.  
Learners will understand:

- how to create a simple data service class  
- how services encapsulate data access logic  
- how the service returns strongly typed `Product` objects  
- how this service will later be registered with dependency injection  
- how UI components will consume this service in the next branch  

## 🧠 Key Concepts Introduced

- Service classes in .NET  
- Returning lists of models  
- Preparing the data layer for DI and UI binding  

## 🔗 Next Step

Continue to branch `03-ui-products` to build the UI that displays product data from this service.