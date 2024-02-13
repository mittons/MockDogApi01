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

## Acknowledgements
- **The Dog API:** This application uses data from [The Dog API](https://www.thedogapi.com). I route the traffic through my own private backend proxy in order to secure my user key for the API, in line with the [The Dog API TOS](https://thedogapi.com/terms).

- **ChatGPT:** Powered by OpenAI, specifically ChatGPT-4. Files in this project vary from between being Content that is completely AI generated to being completely human-generated. The term Content, and other relevant definitions, can be observed on [The OpenAI TOS page](https://openai.com/policies/terms-of-use#using-our-services).

## License
This project is licensed under the [MIT LICENSE](LICENSE) - see the file for details.

While my project incorporates the work of others through third-party dependencies, I have not included a detailed `THIRD_PARTY_LICENSES` file at this time. I am deeply committed to respecting intellectual property, honoring the licensing requirements of all dependencies, and declaring an express desire to acknowledge all contributions while repsecting, and not limiting, those who choose not to be acknowledged.

Should you have any inquiries or suggestions regarding third-party attributions, or if there's a specific attribution you believe requires immediate attention, please do not hesitate to contact me at axel@axelgauti.is. I promise to address all such communications promptly, providing either a resolution or a commitment to resolve the matter within a reasonable timeframe, subject to my availability and capacity to respond.

This commitment is part of my broader ethical stance on promoting attribution transparently and fairly, without prejudging the worth of contributions based on past or potential acknowledgments. I welcome your feedback and suggestions on how I can improve my practices in this area.