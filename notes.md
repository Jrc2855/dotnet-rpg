# .NET 7 Web API & Entity Framework Jumpstart

## Things that the UDEMY course will cover
1. First we'll go over the Web API
  * This will cover the Model-View-Controller pattern
  * Best Practices
  * Asynchronous implementations with async/ await
  * Data-Transfer-Objects
  * CRUD
  * HTTP Request Methods

2. After these we'll go over Authentication
  * Registration & Login
  * Cryptography algorithm HMACSHA512 (Whatever that last part means)
  * JSON Web Tokens (JWT's)

3. Database Relationships
  * One-To-One
  * One-To-Many
  * Many-To-Many

4. Extras (More than crud)
  * RPG Fights
  * Highscore

## Notes

## Model-View-Controller (MVC)
* The Model is essentially the stats of your character
* The View is the image, or 3d rendered model that represents your character
* The Controller is the logic that calculates everything that happens to your Character.
* So the example I thought of was in Pokemon. The Model would be your Pokemons stats, The View is the Image/ Model of your pokemon that the player sees, and the controller is the logic that runs during your battles (Damage taken, stats altered, attacks used, etc)

### Models
* How did we make the models?
* We started by creating some new C# Classes, one titled Character.cs, and one titled RPGClass.cs. In the Character class we used some boiler plate code to get our class started then we added a 'public class character' on line 8. Then we added 'public' to the start of each new line followed by the data type and then the Stat Name (HP, Strength, Defense, etc)
* Then we created a new class called the RPG Class and we used that to create some new RPG Classes (Knight, Mage, Cleric) and we referred to the Knight Class inside of our Character Class File. So our Models are basically setup for now.
* Now we're going to go over the Controllers

### Questions
1. What is .Net used for?

* According to ChatGPT: .Net is a software development framework developed by Microsoft. It provides a programming model and a set of libraries for building various types of applications, including web applications, desktop applications, mobile applications, gaming applications, and more.

2. Is this a language that is specific to Web Development or is it generally useful for all programming?

* According to my question and answer above. It's able to be used in all sorts of programming.
