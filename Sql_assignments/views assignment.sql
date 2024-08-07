-- 1. Create a View for Employees Working in Department d1
CREATE VIEW EmployeesInD1 AS
SELECT *
FROM employee
WHERE department_id = 'd1';

-- 2. Create a View for the Project Table Excluding the Budget Column
CREATE VIEW ProjectWithoutBudget AS
SELECT project_id, project_name
FROM project;

-- 3. Create a View for Employees Who Entered Their Projects in the Second Half of 1988
CREATE VIEW EmployeesEnteredInSecondHalf1988 AS
SELECT e.first_name, e.last_name
FROM employee e
JOIN works_on w ON e.employee_id = w.employee_id
WHERE w.enter_date BETWEEN '1988-07-01' AND '1988-12-31';

-- 4. Create a View with Renamed Columns for Exercise 3
CREATE VIEW EmployeesEnteredInSecondHalf1988Renamed AS
SELECT e.first_name AS first, e.last_name AS last
FROM employee e
JOIN works_on w ON e.employee_id = w.employee_id
WHERE w.enter_date BETWEEN '1988-07-01' AND '1988-12-31';

-- 5. Use the View from Exercise 3 to Display Full Details of Employees Whose Last Names Begin with M
SELECT *
FROM EmployeesEnteredInSecondHalf1988
WHERE last LIKE 'M%';

-- 6. Create a View for Full Details of Projects on Which Employee Named Smith Works
CREATE VIEW ProjectsBySmith AS
SELECT p.*
FROM project p
JOIN works_on w ON p.project_id = w.project_id
JOIN employee e ON w.employee_id = e.employee_id
WHERE e.last_name = 'Smith';

-- 7. Modify the View from Exercise 3 to Include Employees from Department d1 or d2
-- Drop the existing view if it exists
DROP VIEW IF EXISTS EmployeesEnteredInSecondHalf1988;

-- Create the modified view
CREATE VIEW EmployeesEnteredInD1OrD2 AS
SELECT e.first_name, e.last_name
FROM employee e
JOIN works_on w ON e.employee_id = w.employee_id
WHERE e.department_id IN ('d1', 'd2')
AND w.enter_date BETWEEN '1988-07-01' AND '1988-12-31';