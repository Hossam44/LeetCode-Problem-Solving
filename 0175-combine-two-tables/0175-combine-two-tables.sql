select firstName,lastName,city,state
from Person as p left outer join Address as A
on P.personId=A.personId