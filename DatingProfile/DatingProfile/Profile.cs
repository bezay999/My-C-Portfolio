namespace DatingProfile;

public class Profile
{
   bool isSet = false;
   private string name;

   public string Name
   {
      get { return name; }
      set {name = value;}
   }
   private int age;

   public int Age
   {
      get { return age; }
      set {age = value;}
   }
   
   private string city;
   public string City
   {
      get { return city; }
      set {city = value;}
   }
   
   private string counrty;
   public string Country
   {
      get { return counrty; }
      set {counrty = value;}
   }
   
   private string pronouns = "they/them";
   public string Pronouns
   {
      get { return pronouns; }
      set {pronouns = value;}
   }
   
   private string hobby;
   public string Hobby
   {
      get { return hobby; }
      set {hobby = value;}
   }

   public Profile(string name, int age, string city, string counrty, string pronouns, string hobby)
   {
      this.name = name;
      this.age = age;
      if (age < 18)
      {
         throw new Exception("You must be older than 18 years old.");
      }
      this.city = city;
      this.counrty = counrty;
      this.pronouns = pronouns;
      this.hobby = hobby;
   }
   public Profile(string name, int age)
   {
      this.name = name;
      this.age = age;
      if (age <= 18)
      {
         throw new Exception("You must be older than 18 years old.");
      }
   }
   
   public void SetHobby(string hobby)
   {
      this.hobby = hobby;
         isSet = true;
   }
   public string ViewProfile()
   {
      if (!isSet)
      {
         throw new Exception("You must set your hobbies");
      }
         return "Name: " + Name + "\nAge: " + Age + "\nCity: " + City + "\nCountry: " + Country + "\nPronouns: " + Pronouns + "\nHobby: " + Hobby;
   }
}