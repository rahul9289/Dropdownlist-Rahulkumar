 This my file 
 
 select *  from UserDetails



Create table UserDetails

(
 ID int not null Primary key Identity,
 Name varchar(100),
 Address varchar(100),
 Email varchar(100),
 Gender varchar(100),
 CountryName varchar(100)
 )

 

 Create proc GetUSerDt
 As
 begin 
 select *  from UserDetails
 end
 

exec GetUSerDt

 Create proc InsertUserDt
  (
  
  @Name varchar(100),
  @Address varchar(100),
  @Email varchar(100),
  @Gender varchar(100),
  @CountryName Varchar(100)
   
  )

  as
  begin

  SET IDENTITY_INSERT UserDetails OFF

  insert into UserDetails(Name,Address,Email,Gender,CountryName)values
  (@Name,@Address,@Email,@Gender,@CountryName)

  end

 
 exec InsertUserDt'sumit','Ad086','adg@gmail.com','male', 'USA'
  exec InsertUserDt'Rakes','Ad0878','akb@gmail.com','female', 'Canada'
    exec InsertUserDt'Jay1','Ad0878','akb@gmail.com','male', 'Malesya'



  Create proc UpdateUserDt
  (
  @ID int,
  @Name varchar(100),
  @Address varchar(100),
  @Email varchar(100),
  @Gender varchar(100),
  @CountryName Varchar(100)
   
  )

  as
  begin


    Update UserDetails set Name = @Name,Address = @Address,Email = @Email,Gender = @Gender, CountryName = @CountryName Where ID = @ID

  end
 
  exec UpdateUserDt  1,'Anil','asd078','adt@gmail.com','female','Japan'
 

 Create proc DeleteUserDt

   @ID int

  As
  Begin
  Delete from UserDetails Where ID = @ID
  end
   
  

  exec DeleteUserDt 21
 
  select *  from UserDetails


