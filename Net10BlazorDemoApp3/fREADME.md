# 05 – Product Create UI

This branch introduces the **Create Product** page, allowing users to add new products through a form with validation. Learners will explore Blazor’s form components, data binding, validation attributes, and service updates.

## 📁 Files Added

- `Components/Pages/ProductCreate.razor`

## 🛠️ Changes Made

- Added a new Razor component for creating a product  
- Implemented `<EditForm>` with validation support  
- Added `DataAnnotations` to the `Product` model  
- Introduced a new `AddProduct` method in `ProductService`  
- Added navigation from the product list to the create page  
- Implemented redirect back to the product list after creation  

## 🎯 Purpose

This branch teaches learners how to:

- Build forms using `<EditForm>`  
- Use two‑way data binding with `@bind-Value`  
- Apply validation using `DataAnnotations`  
- Add new items to an in‑memory service  
- Navigate programmatically after form submission  

This is the first branch where learners actively modify application state.

## 🧠 Key Concepts Introduced

- **EditForm** and form components  
- **ValidationMessage** and **ValidationSummary**  
- **DataAnnotations** (`[Required]`, `[StringLength]`, `[Range]`)  
- **Two‑way binding**  
- **Programmatic navigation** using `NavigationManager`  
- **Service updates** for adding new data  

## 🔗 Next Step

Move to branch **06-ui-product-edit** to introduce editing existing products and deeper validation patterns.