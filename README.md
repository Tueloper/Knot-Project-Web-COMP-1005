# Knot-Web-Application

## Built with
- #### C#
- ####.NET 6.0
- #### Squlite
- #### UnitTesting
- #### API application
- #### JavaScript


## Report
This app was built to follow what was discussed in class, where we have seperate projects for API, Test, Logic And UI. Its really sophiscated and yet simple if understood properly.

## Scope:
### User Entity
- id
- name
- email
- password

### Note 
- id
- Title
- Content
- Description
- DateCreated
- LastModified
- UserId

## APIs Created
- User can signup
- User can Login
- User can view Profile
- User can add Post
- User can edit post
- User can update post
- User can delete post
- User can get single post

## Challenges
### Login API: 
<img width="921" alt="image" src="https://user-images.githubusercontent.com/45209679/208222221-93210a40-4626-4aca-ae5e-844ee9272862.png">

For some weird reason, i couldn't get to make the login to work. So i changed the id type from string to int, make changes across other Entities but yet no result as to why it fails.

- I also deleted the Tables, added multiple keys to the User Entity because i thought, the error was key based but that caused more errors.

### UI Issues:
I couldn't get my react application to run, because of the error below:
<img width="1478" alt="image" src="https://user-images.githubusercontent.com/45209679/208223042-21ecc6b5-2761-470d-b05d-f119332b4bec.png">


- I checked multiple links, updated my path, rebooted the system, worked on some suggested solutions on the following links:
- https://stackoverflow.com/questions/69666804/why-cant-visual-studio-fro-mac-run-node
- https://stackoverflow.com/questions/55086195/the-resolvepackageassets-task-failed-unexpectedly-system-typeloadexception

But no response on the problem.

### API Result
![image](https://user-images.githubusercontent.com/45209679/208224167-1d774ee1-ea9a-4fb0-82bc-89bc4db89f99.png)

![image](https://user-images.githubusercontent.com/45209679/208224705-ebf7ffee-565d-4eec-892e-5e55eae4970d.png)






















