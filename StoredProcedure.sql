-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE StoredProcedureEmpDetails
@EmployeeName varchar(255),
@PhoneNumber varchar(255),
@Address varchar(255),
@Department varchar(255),
@Gender char(1),
@BasicPay float,
@Deductions float,
@TaxablePay float,
@Tax float,
@NetPay float,
@StartDate Date,
@City varchar(255),
@Country varchar(255)

	-- Add the parameters for the stored procedure here
	
AS
BEGIN
insert into employee_payroll1 
values(@EmployeeName,@PhoneNumber,@Address,@Department,@Gender,@BasicPay,@Deductions,@TaxablePay,@Tax,@NetPay,@StartDate,@City,@Country)



	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmployeeID,EmployeeName,PhoneNumber,Address,Department,Gender,BasicPay,Deductions,TaxablePay,Tax,NetPay,StartDate,City,Country from employee_payroll1
           
END
GO
