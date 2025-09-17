# TestApp - Blazor Server Interview Challenge

## Overview
This repository contains a coding challenge designed to evaluate candidates' proficiency with **Blazor Server** and **.NET 8**. Candidates will build a quote management system that demonstrates their understanding of Blazor components, data binding, event handling, and state management.

## Getting Started for Candidates

### Fork This Repository
1. **Fork this repository** to your own GitHub account by clicking the "Fork" button at the top right
2. **Clone your fork** to your local machine:
   ```bash
   git clone https://github.com/YOUR-USERNAME/TestApp.git
   cd TestApp
   ```
3. **Open the solution** in Visual Studio 2022 or your preferred IDE
4. **Run the application** to see the challenge description and sample data

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022 (recommended) or VS Code with C# extension
- Basic knowledge of C# and web development

### Running the Application
1. Open `TestApp.sln` in Visual Studio
2. Set the startup project to the main Blazor project
3. Press F5 or use the "Start" button
4. Navigate to the home page to see the full challenge description
5. Click "Start Challenge" to begin working on the quotes page

## Challenge Requirements

### Core Requirements (Must Implement)
- **Edit Functionality** - Allow editing of quote fields
- **Save Changes** - Persist changes in memory using the provided service
- **Data Validation** - Validate required fields and numeric inputs
- **Real-time Calculations** - Update total price when unit price or quantity changes
- **Status Management** - Allow changing quote status (Draft, Pending, Approved, Rejected)

### Bonus Requirements (Optional)
- Add new quotes functionality
- Delete quotes with confirmation dialog
- Search/filter quotes by customer or status
- Enhanced form validation with error messages
- Responsive design improvements

## Technical Details
- **Framework**: Blazor Server (.NET 8)
- **Styling**: Bootstrap 5 (pre-included)
- **Data Storage**: In-memory (using provided QuoteService)
- **Sample Data**: 4 pre-loaded quotes included

## Project Structure
```
TestApp/
├── Models/
│   └── Quote.cs                 # Quote data model
├── Services/
│   └── QuoteService.cs          # In-memory data service (partially implemented)
├── Pages/
│   ├── Home.razor              # Challenge description page
│   └── Quotes.razor            # Main quotes page (your work goes here)
└── Shared/                     # Layout components
```

## Time Expectations
- **Recommended time**: 2-3 hours
- **Focus on**: Core requirements first, then bonus features if time permits

## Submission Instructions

### When You're Done
1. **Commit your changes** to your fork:
   ```bash
   git add .
   git commit -m "Complete quote management system implementation"
   git push origin main
   ```

2. **Create a Pull Request** (optional) or simply ensure your fork is updated

3. **Share your repository URL** with the interviewer

4. **Include a brief summary** of what you implemented:
   - Which core requirements you completed
   - Any bonus features you added
   - Any challenges you encountered
   - What you would improve with more time

### What We're Looking For
- **Functionality**: Does it meet the core requirements?
- **Code Quality**: Clean, readable, well-structured code
- **Blazor Knowledge**: Proper use of Blazor concepts and patterns
- **Error Handling**: Graceful handling of edge cases and validation
- **User Experience**: Intuitive and responsive interface

## Need Help?
- Check the home page of the running application for detailed requirements and tips
- Review the provided sample code and models
- Focus on implementing core features before adding extras
- Don't hesitate to ask clarifying questions during the interview

## Questions?
If you have any questions about the requirements or technical setup, please reach out to your interviewer or recruiting contact.

---

**Good luck with the challenge.**
