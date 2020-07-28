declare @profileid as int
set @profileid = (
select pro.ProfileID
from Profile pro join Account a on pro.AccountID = a.AccountID
where Username = 'mra'
);
with t as (
select count(FollowedID) as MyFollowing
from Follow
where FollowerID = @profileid

),
t2 as (
select count(FollowedID) as MyFollower
from Follow 
where FollowedID = @profileid

),
t3 as (
select count(postid) as NoOfPosts
from Post
where ProfileID = @profileid

)
select p.*, t.MyFollowing, t2.MyFollower, NoOfPosts
from Profile p,t,t2,t3
where p.ProfileID=@profileid
