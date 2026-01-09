✏️ Branch: 05-ui-product-edit
🔧 Feature Introduced
Implements the Edit Product form using Blazor’s <EditForm> with full model binding, validation, and enhanced navigation support.

📋 What This Branch Adds
- ProductEdit.razor component with:
- Editable fields for Name, Description, Category, and Price
- Two‑way binding using @bind-Value
- Validation via:
- <DataAnnotationsValidator />
- <ValidationSummary />
- Submit handling with OnValidSubmit="SaveChanges"
- Required FormName attribute for Blazor Web App POST behavior
- Safe navigation using NavigationManager.NavigateTo("/products")
- Updated ProductList.razor:
- Added Description column to align with edit form
- Defensive null checks
- Clean Bootstrap table styling
- Currency formatting for price
- Navigation links to /products/edit/{id}

🧠 Gotchas & Lessons Learned
- Blazor Web Apps (.NET 8/10) require a unique FormName for POST forms
Missing this causes the error:
“The POST request does not specify which form is being submitted.”
- Navigation must occur outside conditional blocks to avoid NavigationException.
- <EditForm> does not infer which form was posted — the FormName attribute is mandatory in enhanced navigation mode.
- Aligning list and edit views improves clarity and makes the CRUD loop demo‑ready.

🧪 How to Test
- Navigate to /products
- Click View on any product
- Modify any field
- Click Save
- Confirm:
- Redirect back to /products
- Updated values appear in the list

📚 Learning Path Context
This branch builds on earlier steps:
- 01-models-product — Product model
- 02-data-productservice — In‑memory CRUD service
- 03-ui-product-list — Product table UI
- 04-ui-product-details — Detail view
- 05-ui-product-edit — Edit form with validation and enhanced navigation
Upcoming branches may include:
- Delete functionality
- Toast notifications
- SQLite or EF Core persistence
- Curriculum slide scaffolding
- UI polish and UX enhancements




- 
