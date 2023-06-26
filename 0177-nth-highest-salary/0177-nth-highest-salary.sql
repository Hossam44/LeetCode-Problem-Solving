CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN 
    (
        select max(salary)
        from
        (
            select salary 
            from
            (
                select salary,
                DENSE_RANK() OVER (ORDER BY salary DESC) AS DR
                from Employee
            ) as first_query
            where DR = @N
        ) as second_query
        
    );
END