namespace InfrastructureLayer.Query
{
    public struct StudentPersonalInfoQuery
    {
        public readonly string spGetById => (@"
            SELECT 
		        StudentPIT.SrCode, 
                StudentName.LastName, 
                StudentName.FirstName, 
                StudentName.MiddleName,
		        DATE_FORMAT(StudentPIT.BirthDate, '%M %d, %Y') AS BirthDate,
                StudentPIT.Gender, 
                StudentAddress.HouseNumber, 
                StudentAddress.Barangay, 
		        StudentAddress.Municipality, 
                StudentAddress.Province, 
                StudentPIT.ContactNumber, 
                UserInfo.EmailAddress,
		        GuardianName.LastName AS GuardianLastName, 
                GuardianName.FirstName AS GuardianFirstName, 
                GuardianName.MiddleName AS GuardianMiddleName,
		        StudentPIT.EmergencyContactNumber AS GuardianContactNumber, 
                GuardianAddress.HouseNumber AS GuardianHouseNumber, 
                GuardianAddress.Barangay AS GuardianBarangay,
		        GuardianAddress.Municipality AS GuardianMunicipality, 
                GuardianAddress.Province AS GuardianProvince
	        FROM 
		        StudentPersonalInfoTbl as StudentPIT
	        INNER JOIN 
		        UserTbl UserInfo ON StudentPIT.SrCode = UserInfo.UserId
	        INNER JOIN 
		        NameTbl StudentName ON StudentPIT.FullName = StudentName.UserId
	        INNER JOIN 
		        AddressTbl StudentAddress ON StudentPIT.Address = StudentAddress.UserId
	        INNER JOIN 
		        NameTbl GuardianName ON StudentPIT.EmergencyContactName = GuardianName.UserId
	        INNER JOIN
		        AddressTbl GuardianAddress ON StudentPIT.EmergencyContactAddress = GuardianAddress.UserId
	        WHERE 
		        StudentPIT.SrCode = @p_SrCode;
        ");

        public readonly string spGetAll => (@"
            SELECT 
				StudentPIT.SrCode, 
				StudentName.LastName, 
				StudentName.FirstName, 
				StudentName.MiddleName,
				DATE_FORMAT(StudentPIT.BirthDate, '%M %d, %Y') AS BirthDate,
				StudentPIT.Gender, 
				StudentAddress.HouseNumber, 
				StudentAddress.Barangay, 
				StudentAddress.Municipality, 
				StudentAddress.Province, 
				StudentPIT.ContactNumber, 
				UserInfo.EmailAddress,
				GuardianName.LastName AS GuardianLastName, 
				GuardianName.FirstName AS GuardianFirstName, 
				GuardianName.MiddleName AS GuardianMiddleName,
				StudentPIT.EmergencyContactNumber AS GuardianContactNumber, 
				GuardianAddress.HouseNumber AS GuardianHouseNumber, 
				GuardianAddress.Barangay AS GuardianBarangay,
				GuardianAddress.Municipality AS GuardianMunicipality, 
				GuardianAddress.Province AS GuardianProvince
			FROM 
				StudentPersonalInfoTbl as StudentPIT
			INNER JOIN 
				UserTbl UserInfo ON StudentPIT.SrCode = UserInfo.UserId
			INNER JOIN 
				NameTbl StudentName ON StudentPIT.FullName = StudentName.UserId
			INNER JOIN 
				AddressTbl StudentAddress ON StudentPIT.Address = StudentAddress.UserId
			INNER JOIN 
				NameTbl GuardianName ON StudentPIT.EmergencyContactName = GuardianName.UserId
			INNER JOIN
				AddressTbl GuardianAddress ON StudentPIT.EmergencyContactAddress = GuardianAddress.UserId;
        ");

		public readonly string spDelete => (@"
			DELETE FROM StudentPersonalInfoTbl WHERE SrCode = @p_SrCode;
    
			DELETE FROM AddressTbl WHERE UserId = @p_StudentAddressCode;
			DELETE FROM AddressTbl WHERE UserId = @p_GuardianAddressCode;
    
			DELETE FROM NameTbl WHERE UserId = @p_StudentNameCode;
			DELETE FROM NameTbl WHERE UserId = @p_GuardianNameCode;
		");

		public readonly string spInsert => (@"
			INSERT INTO UserTbl (UserId, EmailAddress, AccountPassword, Position)
			VALUES (@p_SrCode, @p_EmailAddress, @p_DefaultPassword, @p_Position);
    
			INSERT INTO NameTbl (UserId, LastName, FirstName, MiddleName)
			VALUES (@p_StudentNameCode, @p_LastName, @p_FirstName, @p_MiddleName);
    
			INSERT INTO NameTbl (UserId, LastName, FirstName, MiddleName)
			VALUES (@p_GuardianNameCode, @p_GuardianLastName, @p_GuardianFirstName, @p_GuardianMiddleName);
    
			INSERT INTO AddressTbl (UserId, HouseNumber, Barangay, Municipality, Province)
			VALUES (@p_StudentAddressCode, @p_HouseNumber, @p_Barangay, @p_Municipality, @p_Province);
    
			INSERT INTO AddressTbl (UserId, HouseNumber, Barangay, Municipality, Province)
			VALUES (@p_GuardianAddressCode, @p_GuardianHouseNumber, @p_GuardianBarangay, @p_GuardianMunicipality, @p_GuardianProvince);
    
			INSERT INTO StudentPersonalInfoTbl
			VALUES (@p_SrCode, @p_StudentNameCode, @p_BirthDate, @p_Gender, @p_StudentAddressCode, @p_ContactNumber,
					@p_GuardianNameCode, @p_GuardianContactNumber, @p_GuardianAddressCode);
            
			INSERT INTO StudentAcademicInfoTbl
			VALUES (@p_SrCode, @p_StudentNameCode, null, null, null, null, null);
		");

		public readonly string spUpdate => (@"
			UPDATE NameTbl
			SET LastName = @p_LastName,
				FirstName = @p_FirstName,
				MiddleName = @p_MiddleName
			WHERE UserId = @p_StudentNameCode;
    
			UPDATE NameTbl
			SET LastName = @p_GuardianLastName,
				FirstName = @p_GuardianFirstName,
				MiddleName = @p_GuardianMiddleName
			WHERE UserId = @p_GuardianNameCode;
    
			UPDATE AddressTbl
			SET HouseNumber = @p_HouseNumber,
				Barangay = @p_Barangay,
				Municipality = @p_Municipality,
				Province = @p_Province
			WHERE UserId = @p_StudentAddressCode;
    
			UPDATE AddressTbl
			SET HouseNumber = @p_GuardianHouseNumber,
				Barangay = @p_GuardianBarangay,
				Municipality = @p_GuardianMunicipality,
				Province = @p_GuardianProvince
			WHERE UserId = @p_GuardianAddressCode;
    
			UPDATE UserTbl
			SET EmailAddress = @p_EmailAddress
			WHERE UserId = @p_SrCode;
    
			UPDATE StudentPersonalInfoTbl
			SET BirthDate = @p_BirthDate,
				Gender = @p_Gender,
				ContactNumber = @p_ContactNumber,
				EmergencyContactNumber = @p_GuardianContactNumber
			WHERE SrCode = @p_SrCode;
		");
    }
}
