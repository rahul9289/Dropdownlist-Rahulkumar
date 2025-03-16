use Admin



Create table StudentClass
(
 ID int not null primary key Identity,
 Name varchar(100),
 Address varchar(100),
 StateID int,
 CityID int,
 MaritalState varchar(100),
 CheckBox bit

)


 Create proc GetStdClass
 As
 Begin
  Select StudentClass.ID,StudentClass.Name,StudentClass.Address,State.StateID,State.StateName,City.CityID,City.CityName,StudentClass.MaritalState,StudentClass.CheckBox From StudentClass
  left join State on StudentClass.StateID = State.StateID
  left join City on StudentClass.CityID = City.CityID
  end

  exec GetStdClass

  Create proc InsertStudent
  (
  
  @Name varchar(100),
  @Address varchar(100),
  @StateID int,
  @CityID int,
  @MaritalState varchar(100),
  @CheckBox Bit
   
  )
  as
  begin
  insert into StudentClass(Name,Address,StateID,CityID,MaritalState,CheckBox)values
  (@Name,@Address,@StateID,@CityID,@MaritalState,@CheckBox)

  end
  exec  InsertStudent 'Akash','GL16',1,1,'Married','True'
   exec  InsertStudent 'Sumit','KL18',2,2,'Married','True'

 Select* from StudentClass

  Create Proc UpdateStudent
  (
  @ID int,
  @Name varchar(100),
  @Address varchar(100),
  @StateID int,
  @CityID int,
  @MaritalState varchar(100),
  @CheckBox Bit
   
  )
As
begin
  Update StudentClass set Name=@Name,Address = @Address, StateID=@StateID,CityID= @CityID,MaritalState=@MaritalState,CheckBox=@CheckBox Where ID = @ID
  end


  Create proc DeleteStudent
  @ID int
  As
  Begin
  Delete from StudentClass Where ID = @ID
  end

Create  table State
(
 StateID  int not null primary key,
 StateName varchar(100)

)
 insert into State(StateID,StateName)values(1,'Punjab')
  insert into State(StateID,StateName)values(2,'Gujrat')
 insert into State(StateID,StateName)values(3,'Maharasht')
 insert into State(StateID,StateName)values(4,'Jamukashmeer')


create proc SpState 
As
begin 
select * from State
end 


Create  table City
(
 CityID int not null Primary key,
 CityName varchar(100),
 StateID int  foreign key references  State(StateID)

)
 select  * from City

insert into City (CityID,CityName,StateID)values(1,'Chandigar',1)
insert into City (CityID,CityName,StateID)values(2,'Amritsar',1)
insert into City (CityID,CityName,StateID)values(3,'Maholi',1)
insert into City (CityID,CityName,StateID)values(4,'Ahmdabad',2)
insert into City (CityID,CityName,StateID)values(5,'kuch',2)
insert into City (CityID,CityName,StateID)values(6,'surat',2)
insert into City (CityID,CityName,StateID)values(7,'pune',3)
insert into City (CityID,CityName,StateID)values(8,'mumbai',3)
insert into City (CityID,CityName,StateID)values(9,'thane',3)
insert into City (CityID,CityName,StateID)values(10,'shreeNagar',4)
insert into City (CityID,CityName,StateID)values(11,'pulwama',4)
insert into City (CityID,CityName,StateID)values(12,'rajouri',4)

Select * from State
Select * from City
drop table City

Create proc SpCity 
 @StateID int

As
begin 
select * from City where StateID = @StateID
end 
