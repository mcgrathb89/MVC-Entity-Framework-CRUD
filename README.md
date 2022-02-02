# MVC-Entity-Framework-CRUD
Learned Entity framework (code first) teachniques here - https://www.youtube.com/watch?v=Ep0sFH-2nMQ connected to a SQL 2017 server for the database opperations.

The following demonstrates the created folder structure and classes along with the pruposes of those classes:

Context (Folder)
  MVCContext - This inherits from the DbContext to create database infromation for both teachers and subjects.

Services (Folder)
  ISubjectServices - This is an interface to form a blueprint for the CRUD operations.
  SubjectServices -  The CRUD blueprints from the interface are inherited here to use the Get and Delete methods.

Models (Folder)
  Subject and Teacher classses - These create the data points which are fed into the database using a one to many relationship (one teacher can teach many subjects)

Views (Folder)
  Subject (Folder)
    Index - This holds the views generated by the database information which I populated with simple data on subjects.

Thats pretty much everything, I will add the read and update methods soon...