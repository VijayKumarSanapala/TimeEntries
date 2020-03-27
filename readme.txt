Name: VijayKumar Sanapala.
Date: 26/03/2020.






Step 1:

1.Creating the Database (TestEntries)
2.Creating and Designing the table use the below script to create the table.

USE [TimeEntries]


CREATE TABLE [dbo].[TimeEntriesViewModel](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[EmailAddress] [varchar](50) NULL,
	[Date] [date] NULL,
	[Task] [varchar](150) NULL,
	[HoursWorked] [decimal](4, 2) NULL,
	[Comment] [varchar](150) NULL,
	[LastModifiedBy] [int] NULL,
	[LastModifiedOn] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_TimeEntriesViewModel] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


Step 2: Create New Project in Visual Studio 2017.
1.Go to File, New, then Project.
2.Select Visual C# - Web, then select ASP.NET MVC 5 Web Application.
3.Provide the project a name(TimeEntriesEmployees) and specify the location and click on OK.
4.Select a template as Empty and view engine as Razor.
5.Click on OK.

Step 3: Connecting database through EDMX Diagram(Entity Model).
1.Creating the folder (Entity)
2.Click on Entity-> Add New Item.
3.Select Data from the left menu and then ADO.NET Entity Data Model.
4.Enter TimeEntriesViewModel as the name and click OK.
5.This launches the Entity Data Model Wizard.
6.Select "Generate from database" and click Next.
7.Select the connection to the database you created in the first section. Enter TimeEntriesEntities as the name of the connection string and click Next.
8.Click the checkbox next to the ‘Tables’ to import all tables and click ‘Finish’.
9.The new model is added to your project and opened for you to view in the Entity Framework Designer. 
10.An Web.config file has also been added to your project with the connection details for the database.
11.TimeEntriesViewModel.tt file contains all your SQL table class files with all the entities.

Step 4: Create Data Access Layer (DAL).
1.Right click on DAL folder and add Class Library project .
2.Then Give the class name as TimeEntriesDAL.
3.Write the Data Access Logic for that class file (GetAll(),GetById(),Save(),Update(),Delete())methods and some logic.
4.Build the Project checking is there any Errors.


Step5: Create Business Entities Layer or Business Access Layer (BAL).
1.Right click on DAL(DataAccessLayer) Folder.
2.Add the BAL project reference to DAL(TimeEntriesBAL tdal = new TimeEntriesBAL()).
3.Write the Business Logic for that class file (GetAll(),GetById(),Save(),Update(),Delete())methods and some logic.
4.Build the Project checking is there any Errors.

Step 6: Add a Controller.
1.Right click on controller folder, click on Add -> Controller and name it TimeEntriesController.cs Then click on Add.
2.In that Controller giving connection to BAL(TimeEntriesBAL Tbal = new TimeEntriesBAL()).
3.Writing the methods to (GetAll(),GetById(),Save(),Update(),Delete()) the controller.


Step 7: Add View
1.Right click on the TimeEntriesRazor() action method in the "TimeEntriesController" class.
2.Then select "Add View" from the context menu.
3.Next select View name = TimeEntriesRazor, View engine = Razor
4.Select "Create a strongly-typed view" checkbox
5.Click "Add" button
6.Then write the code based on our requirement in our view.
7.Likewise create reamaining views (AddEmployeeEntry.cshtml,TimeEntriesRazor.cshtml,UpdateEmployeeEntry.cshtml).

Step 8. Create Display Classes
1.create display classes folder in model folder
2.create data Anotations for perform Validations.

Step 9. Create CSS(Cascading Style Sheets)
1.Create Styles by using this CSS.













