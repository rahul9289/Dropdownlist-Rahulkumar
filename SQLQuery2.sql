Select * From EmployeDetail
Select * From State
Select * From City
select * from Department


Select T1.Name, T1.Address, T1.Email, T2.StateName, T3.CityName, D4.DepartmentName from EmployeDetail As T1 full outer join  State As T2 on T1.StateID = T2.StateID
full outer join  City As T3 on T1.CityID = T3.CityID
full outer Join  Department As D4 on T1.DepartmentID = D4.DepartmentID

Select EmployeDetail.ID,EmployeDetail.ID, EmployeDetail.Address, EmployeDetail.Email,State.StateID, State.StateName, City.CityID,City.CityName,Department.DepartmentID, Department.DepartmentName from EmployeDetail left join 
State  on EmployeDetail.StateID = State.StateID
left  join  City on EmployeDetail.CityID = City.CityID
left Join  Department on EmployeDetail.DepartmentID = Department.DepartmentID






delete from EmployeDetail where ID = 2