-- Table: Shift (Ca làm việc)
CREATE TABLE Shift (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    description NVARCHAR(MAX)
);

-- Table: Day (Ngày làm việc trong tuần)
CREATE TABLE Day (
    id INT IDENTITY(1,1) PRIMARY KEY,
    day_number INT NOT NULL CHECK (day_number BETWEEN 2 AND 6) -- Thứ 2 đến Thứ 6
);

-- Table: ShiftSchedule (Lịch ca làm việc theo ngày)
CREATE TABLE ShiftSchedule (
    id INT IDENTITY(1,1) PRIMARY KEY,
    shift_id INT FOREIGN KEY REFERENCES Shift(id),
    day_id INT FOREIGN KEY REFERENCES Day(id),
    from_time TIME NOT NULL,
    to_time TIME NOT NULL
);

-- Table: EmployeeType (Loại nhân viên)
CREATE TABLE EmployeeType (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    status NVARCHAR(20) UNIQUE NOT NULL CHECK (status IN ('fulltime', 'partime'))
);

-- Table: Employee (Nhân viên)
CREATE TABLE Employee (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    type_id INT FOREIGN KEY REFERENCES EmployeeType(id),
    status NVARCHAR(20) NOT NULL DEFAULT 'unregistered' CHECK (status IN ('unregistered', 'registered', 'approved', 'present', 'absent'))
);

-- Table: WorkArea (Khu vực làm việc)
CREATE TABLE WorkArea (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    status NVARCHAR(20) UNIQUE NOT NULL CHECK (status IN ('dining', 'hotstove', 'coldstove'))
);

-- Table: EmployeeWorkArea (Gán nhân viên vào khu vực làm việc)
CREATE TABLE EmployeeWorkArea (
    id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT FOREIGN KEY REFERENCES Employee(id),
    work_area_id INT FOREIGN KEY REFERENCES WorkArea(id)
);

-- Table: ShiftRegistration (Đăng ký lịch làm việc của nhân viên Part-time)
CREATE TABLE ShiftRegistration (
    id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT FOREIGN KEY REFERENCES Employee(id),
    shift_schedule_id INT FOREIGN KEY REFERENCES ShiftSchedule(id),
    status NVARCHAR(20) NOT NULL DEFAULT 'unregistered' CHECK (status IN ('unregistered', 'registered', 'approved')),
    registered_at DATETIME DEFAULT GETDATE()
);

-- Table: ShiftSwapRequest (Yêu cầu đổi ca của nhân viên Part-time)
CREATE TABLE ShiftSwapRequest (
    id INT IDENTITY(1,1) PRIMARY KEY,
    employee_from INT FOREIGN KEY REFERENCES Employee(id),
    employee_to INT FOREIGN KEY REFERENCES Employee(id),
    shift_schedule_id INT FOREIGN KEY REFERENCES ShiftSchedule(id),
    status NVARCHAR(30) NOT NULL DEFAULT 'pending_staff_agree' CHECK (status IN ('pending_staff_agree', 'pending_manager_approve', 'success', 'rejected')),
    requested_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE EmployeeShift (
    id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT FOREIGN KEY REFERENCES Employee(id),
    shift_schedule_id INT FOREIGN KEY REFERENCES ShiftSchedule(id),
    work_area_id INT FOREIGN KEY REFERENCES WorkArea(id),
    assigned_at DATETIME DEFAULT GETDATE()
);
