#Trevoir Williams Udemy Course
##Complete ASP.NET Core and Entity Framework Development

Here's the link for the course: https://www.udemy.com/course/complete-aspnet-core-31-and-entity-framework-development/

##Development step by step

In this section we will have a step by step guide on what we've done and during the course

1- Created the class "employee.cs" inside the "Data" folder
1.1- inherited from the IdentityUser class from Microsoft.AspNetCore.Identity
1.2- inside the "Program.cs", we changed the class inside AddDefaultIdentity to Employee
1.3- inside the class AplicationDbContext, in the Data folder, we extended the IdentityDbContext to IdentityDbContext<Employee>, so we can get the changes into the database 
	 and for the program to know wich of them it should use 
1.4- We've created a migration, so we could apply the changes that were made:
	- add-migration ExtendedUserTable
	- We saw that we needed to have nullable fields in the database, so we needed do make that change
	- used "remove-migration" to remove the latest migration
	- gone to the Employee class and added the "?" in some fields that we needed to have as nullable
	- used again the add-migration ExtendedUserTable
	- update-database (to update the database)
