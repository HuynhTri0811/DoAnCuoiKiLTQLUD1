USE master
GO
CREATE DATABASE LTQLUD1_Seminar
GO
USE LTQLUD1_Seminar
GO
CREATE TABLE Users(
	User_id int IDENTITY(1, 1) NOT NULL,
	User_kyDanh varchar(50) NOT NULL,
	User_matKhau varchar(50) NOT NULL,
	User_status varchar(10) NULL,
 	CONSTRAINT PK_Users PRIMARY KEY CLUSTERED 
(
	User_id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Users (User_id, User_kyDanh, User_matKhau, User_status) VALUES (1, N'admin', N'123456', NULL)
INSERT Users (User_id, User_kyDanh, User_matKhau, User_status) VALUES (2, N'user01', N'123456', NULL)
