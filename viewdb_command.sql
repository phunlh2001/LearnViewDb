go
use TestViewDb
go
if exists (select 1 from sys.views where name = 'vw_person_car')
	drop view dbo.vw_person_car
go
create view dbo.vw_person_car
as
select	p.id,
		p.name,
		c.category
	from Person p 
	inner join Car c on p.house = c.house