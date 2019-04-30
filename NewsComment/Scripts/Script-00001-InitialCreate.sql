create table [dbo].[News]
(id uniqueidentifier primary key,
NewsHeadlines nvarchar(100),
Statue nvarchar(1000));

create table [dbo].[Comments]
(id uniqueidentifier primary key,
Comment nvarchar(100),
NewsId uniqueidentifier foreign key(NewsId) References News(id))