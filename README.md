# MunicipalServiceApp

This application allows users to report issues that the municipality should address. The app is built using C# and Windows Forms in the .NET Framework.

## Features
- Report issues by filling out details like location, category, description and attaching an image.
- Store multiple user inputs.
- View user reports.
- View local events and announcements.
- View service request status.
- Simple, clean interface for municipal services.

---

## System Requirements

- **Operating System**: Windows 10 or higher
- **Development Environment**: Visual Studio 2019 or higher
- **Framework**: .NET Framework 4.8

---

## Installation

1. Clone the repository or download the source code:
   ```bash
   git clone https://github.com/ST10051000/MunicipalServiceApp.git
2. Open the solution file (MunicipalServiceApp.sln) in Visual Studio.
3. Ensure that the .NET Framework 4.8 is installed on your system. If necessary, you can install the correct .NET Framework via the Visual Studio installer or directly from the Microsoft website.

---

## Compile

1. Open Visual Studio and load the project by opening MunicipalServiceApp.sln.
2. From the top menu, select Build > Build Solution.
3. The build process should complete without errors, generating the necessary binaries in the bin/Debug or bin/Release folder.

---

## Run

1. In Visual Studio, go to the top menu and click on Debug > Start Without Debugging to run the application.

---

## How to use the application

Home 

- On start-up the user will be met with the homepage with different options on what to do. 
- In the navigation bar at the top there are options - Home, Menu and View. 
- Menu has further navigation options being - Report Issues, Local Events and Announcements and Service Request Status.
- View has further navigation options being Reports.
- The homepage also has three buttons - Report Issues, Events and Announcements and Request Services.
- These three buttons will do the same as the menu navigation options. It will navigate the user to their desired page. 

Report Issues

- This form will collect the user input, the report information. 
- The user should enter the fields with the location, category, description and they should add an attachment by clicking the attach button and selecting an attachment. 
- The report will not be saved if the user has not filled in all the fields, a error message will be displayed. 
- While the user is entering the details, a progress bar will display their progress with a little motivation. 
- Once the user has filled in all the fields they can click the "Submit" button which will then save all the information. 
- The user also has the option to view the reports they have entered by clicking on the "View Reports" button. This will take them to the reports form. 

Reports

- When the user clicks on the "View Reports" button on the report issues form or the View > Reports option in the navigation bar then they will be navigated to this page. 
- This form will display all the details about the issues that the user has reported. 
- (location, category, description and attachment).

Local Events and Announcements

- This page does not contain anything yet.

Service Request Status

- This page does not contain anything yet.
