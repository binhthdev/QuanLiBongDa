CREATE DATABASE FootballDB;
GO

USE FootballDB;
GO

CREATE TABLE Team (
    TeamID VARCHAR(50) PRIMARY KEY,             -- TeamID không tự động tăng, kiểu VARCHAR thay vì INT
    TeamName NVARCHAR(100) NOT NULL,            -- Tên đội
    Logo NVARCHAR(255),                         -- Đường dẫn đến logo (có thể là URL hoặc đường dẫn file)
    FoundedYear DATE,                           -- Năm thành lập
    Address NVARCHAR(255),                      -- Địa chỉ đội
    City NVARCHAR(100),                         -- Thành phố
    Nation NVARCHAR(100),                       -- Quốc gia
    Stadium NVARCHAR(100)                       -- Sân vận động
);

CREATE TABLE Player (
    PlayerID VARCHAR(50) PRIMARY KEY,           -- PlayerID không tự động tăng, kiểu VARCHAR thay vì INT
    PlayerName NVARCHAR(100) NOT NULL,          -- Tên cầu thủ
    Age DATE,                                   -- Tuổi cầu thủ
    Position NVARCHAR(50),                      -- Vị trí cầu thủ (ví dụ: Tiền đạo, Hậu vệ, ...)
    ShirtNumber VARCHAR(10),                    -- Số áo của cầu thủ, kiểu VARCHAR thay vì INT
    TeamID VARCHAR(50),                         -- Khóa ngoại liên kết tới Team, kiểu VARCHAR thay vì INT
    Nationality NVARCHAR(100),                  -- Quốc tịch của cầu thủ
	Image NVARCHAR(MAX),                        -- Đường dẫn hoặc URL ảnh
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)  -- Khóa ngoại tham chiếu tới TeamID trong bảng Team
);

CREATE TABLE Referee (
    RefereeID NVARCHAR(50) PRIMARY KEY,      -- ID của trọng tài, là khóa chính
    RefereeName NVARCHAR(100) NOT NULL,      -- Tên của trọng tài
    Nationality NVARCHAR(100),               -- Quốc tịch của trọng tài
    DateOfBirth DATE                         -- Ngày sinh của trọng tài
);

CREATE TABLE Salary (
    SalaryID INT IDENTITY(1,1) PRIMARY KEY,              -- ID tự động tăng, là khóa chính
    PlayerID VARCHAR(50) NOT NULL,                      -- Khóa ngoại liên kết tới bảng Player
    TeamID VARCHAR(50) NOT NULL,                        -- Khóa ngoại liên kết tới bảng Team
    MonthlySalary DECIMAL(18,2) NOT NULL,               -- Lương hàng tháng
    Bonus DECIMAL(18,2) DEFAULT 0,                      -- Tiền thưởng (mặc định là 0)
    Allowance DECIMAL(18,2) DEFAULT 0,                  -- Phụ cấp (mặc định là 0)
    SalaryDate DATE NOT NULL,                           -- Ngày trả lương
    FOREIGN KEY (PlayerID) REFERENCES Player(PlayerID), -- Tham chiếu tới PlayerID trong bảng Player
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)        -- Tham chiếu tới TeamID trong bảng Team
);

SELECT 
    s.SalaryID,
    p.PlayerName,
    p.Position,
	p.ShirtNumber,
	p.Nationality,
    t.TeamName,
    s.MonthlySalary,
    s.Bonus,
    s.Allowance,
    s.SalaryDate
FROM Salary s
JOIN Player p ON s.PlayerID = p.PlayerID
JOIN Team t ON s.TeamID = t.TeamID;

