namespace InfrastructureLayer.Query
{
    public struct InstructorPersonalInfoQuery
    {
        public readonly string spGetById => (@"
			SELECT 
				InstructorPIT.ItrCode, 
				InstructorName.LastName, 
				InstructorName.FirstName, 
				InstructorName.MiddleName,
				DATE_FORMAT(InstructorPIT.BirthDate, '%M %d, %Y') AS BirthDate,
				InstructorPIT.Gender, 
				InstructorAddress.HouseNumber, 
				InstructorAddress.Barangay, 
				InstructorAddress.Municipality, 
				InstructorAddress.Province, 
				InstructorPIT.ContactNumber, 
				UserInfo.EmailAddress,
				GuardianName.LastName AS GuardianLastName, 
				GuardianName.FirstName AS GuardianFirstName, 
				GuardianName.MiddleName AS GuardianMiddleName,
				InstructorPIT.EmergencyContactNumber AS GuardianContactNumber, 
				GuardianAddress.HouseNumber AS GuardianHouseNumber, 
				GuardianAddress.Barangay AS GuardianBarangay,
				GuardianAddress.Municipality AS GuardianMunicipality, 
				GuardianAddress.Province AS GuardianProvince
			FROM 
				InstructorPersonalInfoTbl as InstructorPIT
			INNER JOIN 
				UserTbl UserInfo ON InstructorPIT.ItrCode = UserInfo.UserId
			INNER JOIN 
				NameTbl InstructorName ON InstructorPIT.FullName = InstructorName.UserId
			INNER JOIN 
				AddressTbl InstructorAddress ON InstructorPIT.Address = InstructorAddress.UserId
			INNER JOIN 
				NameTbl GuardianName ON InstructorPIT.EmergencyContactName = GuardianName.UserId
			INNER JOIN
				AddressTbl GuardianAddress ON InstructorPIT.EmergencyContactAddress = GuardianAddress.UserId
			WHERE 
				InstructorPIT.ItrCode = @p_ItrCode;
        ");

        public readonly string spGetAll => (@"
            SELECT 
				InstructorPIT.ItrCode, 
				InstructorName.LastName, 
				InstructorName.FirstName, 
				InstructorName.MiddleName,
				DATE_FORMAT(InstructorPIT.BirthDate, '%M %d, %Y') AS BirthDate,
				InstructorPIT.Gender, 
				InstructorAddress.HouseNumber, 
				InstructorAddress.Barangay, 
				InstructorAddress.Municipality, 
				InstructorAddress.Province, 
				InstructorPIT.ContactNumber, 
				UserInfo.EmailAddress,
				GuardianName.LastName AS GuardianLastName, 
				GuardianName.FirstName AS GuardianFirstName, 
				GuardianName.MiddleName AS GuardianMiddleName,
				InstructorPIT.EmergencyContactNumber AS GuardianContactNumber, 
				GuardianAddress.HouseNumber AS GuardianHouseNumber, 
				GuardianAddress.Barangay AS GuardianBarangay,
				GuardianAddress.Municipality AS GuardianMunicipality, 
				GuardianAddress.Province AS GuardianProvince
			FROM 
				InstructorPersonalInfoTbl as InstructorPIT
			INNER JOIN 
				UserTbl UserInfo ON InstructorPIT.ItrCode = UserInfo.UserId
			INNER JOIN 
				NameTbl InstructorName ON InstructorPIT.FullName = InstructorName.UserId
			INNER JOIN 
				AddressTbl InstructorAddress ON InstructorPIT.Address = InstructorAddress.UserId
			INNER JOIN 
				NameTbl GuardianName ON InstructorPIT.EmergencyContactName = GuardianName.UserId
			INNER JOIN
				AddressTbl GuardianAddress ON InstructorPIT.EmergencyContactAddress = GuardianAddress.UserId;
        ");

        public readonly string spDelete => (@"
			DELETE FROM InstructorAcademicInfoTbl WHERE ItrCode = @p_ItrCode;

			DELETE FROM InstructorPersonalInfoTbl WHERE ItrCode = @p_ItrCode;
    
			DELETE FROM AddressTbl WHERE UserId = @p_InstructorAddressCode;
			DELETE FROM AddressTbl WHERE UserId = @p_GuardianAddressCode;
    
			DELETE FROM NameTbl WHERE UserId = @p_InstructorNameCode;
			DELETE FROM NameTbl WHERE UserId = @p_GuardianNameCode;
			
		");

         public readonly string spInsert => (@"
			INSERT INTO UserTbl (UserId, EmailAddress, AccountPassword, Position)
			VALUES (@p_ItrCode, @p_EmailAddress, @p_DefaultPassword, @p_Position);
    
			INSERT INTO NameTbl (UserId, LastName, FirstName, MiddleName)
			VALUES (@p_InstructorNameCode, @p_LastName, @p_FirstName, @p_MiddleName);
    
			INSERT INTO NameTbl (UserId, LastName, FirstName, MiddleName)
			VALUES (@p_GuardianNameCode, @p_GuardianLastName, @p_GuardianFirstName, @p_GuardianMiddleName);
    
			INSERT INTO AddressTbl (UserId, HouseNumber, Barangay, Municipality, Province)
			VALUES (@p_InstructorAddressCode, @p_HouseNumber, @p_Barangay, @p_Municipality, @p_Province);
    
			INSERT INTO AddressTbl (UserId, HouseNumber, Barangay, Municipality, Province)
			VALUES (@p_GuardianAddressCode, @p_GuardianHouseNumber, @p_GuardianBarangay, @p_GuardianMunicipality, @p_GuardianProvince);
    
			INSERT INTO InstructorPersonalInfoTbl
			VALUES (@p_ItrCode, @p_InstructorNameCode, @p_BirthDate, @p_Gender, @p_InstructorAddressCode, @p_ContactNumber,
					@p_GuardianNameCode, @p_GuardianContactNumber, @p_GuardianAddressCode);
            
			INSERT INTO InstructorAcademicInfoTbl(ItrCode, InstructorNameId, AcademicYear)
			VALUES (@p_ItrCode, @p_InstructorNameCode, @p_AcademicYear);
		");

        public readonly string spUpdate => (@"
			UPDATE NameTbl
			SET LastName = @p_LastName,
				FirstName = @p_FirstName,
				MiddleName = @p_MiddleName
			WHERE UserId = @p_InstructorNameCode;
    
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
			WHERE UserId = @p_InstructorAddressCode;
    
			UPDATE AddressTbl
			SET HouseNumber = @p_GuardianHouseNumber,
				Barangay = @p_GuardianBarangay,
				Municipality = @p_GuardianMunicipality,
				Province = @p_GuardianProvince
			WHERE UserId = @p_GuardianAddressCode;
    
			UPDATE UserTbl
			SET EmailAddress = @p_EmailAddress
			WHERE UserId = @p_ItrCode;
    
			UPDATE InstructorPersonalInfoTbl
			SET BirthDate = @p_BirthDate,
				Gender = @p_Gender,
				ContactNumber = @p_ContactNumber,
				EmergencyContactNumber = @p_GuardianContactNumber
			WHERE ItrCode = @p_ItrCode;
		");
    }
}
