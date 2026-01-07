# 04 – Product Details UI

This branch introduces the **Product Details** page, completing the navigation flow from the product list to an individual product view. Learners see how Blazor components receive route parameters, retrieve specific data, and render a detailed view.

## 📁 Files Added

- `Components/Pages/ProductDetails.razor`

## 🛠️ Changes Made

- Added a new Razor component for displaying details of a single product  
- Introduced route parameters using `@page "/products/{id:int}"`  
- Injected `ProductService` to retrieve the selected product  
- Added navigation links from the product list to the details page  
- Updated the service call to match the actual method name in `ProductService`

## 🎯 Purpose

This branch teaches learners how to:

- Navigate between components  
- Use route parameters to pass data through the URL  
- Retrieve a single item from a service  
- Render conditional UI when data is missing  
- Build a clean details page layout  

This is the first branch where the app feels interactive and connected.

## 🧠 Key Concepts Introduced

- **Route parameters** (`{id:int}`)  
- **Component parameters** (`[Parameter] public int id { get; set; }`)  
- **Filtering data** using LINQ  
- **Navigation from list to details**  
- **Conditional rendering** for missing or invalid IDs  

## 🔗 Next Step

Move to branch **05-ui-product-create** to introduce form handling, validation, and adding new products to the list.
