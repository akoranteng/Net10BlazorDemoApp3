# 03 – Products UI

This branch introduces the first UI component in the application. It displays a list of products retrieved from the `ProductService`, completing the flow from model → data → UI.

## 📁 Files Added

- `Components/Pages/ProductList.razor`

## 🛠️ Changes Made

- Registered `ProductService` with dependency injection in `Program.cs`
- Injected the service into the `ProductList` component
- Loaded product data using `OnInitialized`
- Rendered the product list in the UI

## 🎯 Purpose

Learners will understand:

- how to build a Razor component  
- how to inject a service into a component  
- how to load data during component initialization  
- how to render lists using Razor syntax  
- how the UI layer consumes the data layer  

This branch represents the first visible output of the application and demonstrates how Blazor components interact with services.

## 🧠 Key Concepts Introduced

- Dependency Injection (DI) in Blazor  
- Component lifecycle (`OnInitialized`)  
- Rendering collections  
- UI composition in MAUI Blazor Hybrid apps  

## 🔗 Next Step

Continue to branch `04-ui-product-details` to build a details page for individual products and introduce route parameters.