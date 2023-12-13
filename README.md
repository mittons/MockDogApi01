# MockDogApiTest01
## About Project:
This project contains a smaller mock version of DogApi. It only has a single endpoint "/breeds" and returns a 3 instances instead of the full list.
It uses a simple controller, and a simple service stub for generating and accessing data. The model has custom json property names.
The code also ignores properties with null values when converting to json.
It opens up to connection from any IP on port 8003, and has a functioning docker file.

## Started On:
:calendar: December 11, 2023 *(AUTO-GENERATED)* :calendar:

## Reflections:
I feel like I can now do a simple mock api in asp.net. I did skip a step in how I initialize the service stub (I should do it in program.cs i think), but I can learn about that in the next project. I should also look into less "CORS-grained" CORS settings. 

## Notable (Milestone) Resources Created:
- Boilerplate web api code in c# asp.net
  - Boilerplate controller
  - Boilerplate mock service stub
  - Simple model
  - Simple Porgram.cs
  - Boilerplate Dockerfile
- Manipulation of json serialization 
  - Skipping serialization of properties set to null
  - Custom serialization of property names
- Listen to connections from any IP at specific port
- Setting up a CORS policy