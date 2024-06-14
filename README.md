// App
To bypass any migration issue, MS SQL Server and EF Core are omitted.
To bypass any auth issue, Identity for both Admin and User auth is omitted.

// DB & Services
Initially, I tried to use a Singleton approach - to mock the Teachers DB table to a single, global List<Teacher> and created a service for the Teacher-CRUD operations.
But app won't even run as it failed to register the DB & Services in Program file. (now commented in Program.cs)
To bypass above, I made the corresponding Controller heavy and highly dependency-coupled with the Teachers list and service. 
No asynchrony used, as no procedure needed to be awaited for simple List modifications.

// Controllers
No API Controllers created as app uses only RazorViews for user interaction.

// DTOs
Different structure for TeacherDto types is used for demonstration. 
During Teacher creation, only some of its properties can be passed (initialized), leaving others purposely empty, to be filled on Editing (Update) process.

Problems faced:
Mistakenly gave AdminTeachersController the 'internal' access modifier and used debugger to come closer to the cause.
