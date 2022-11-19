## CST150-Activity2/6

# BMI calculator

### Summary

1. Throughout this Activity, I learned more things about TryParse than I did previously. Not only does TryParse output the number into the desired variable, but it also returns a boolean. This makes it very useful in error handling with textboxes and numbers.

2. Although it was not too much of a challenge to fix, I kept having the issue of my error messages staying up after the problem was fixed. I realized that I needed to reset them. Another thing was that the BMI from the previous run would stay up if an error was made. I wanted the BMI to clear on an error and the error to clear upon fixing it.

### HOW TO USE:
1. Enter height in meters.
<img width="753" alt="Screenshot 2022-11-19 at 11 09 54 AM" src="https://user-images.githubusercontent.com/102087890/202865433-ab9f6103-47bc-4632-bd6d-73650fbdd656.png">

2. Enter weight in kilograms.
<img width="753" alt="Screenshot 2022-11-19 at 11 10 17 AM" src="https://user-images.githubusercontent.com/102087890/202865448-4017902d-b18f-4198-92f6-93553b08cf81.png">

3. Hit calculate button and see results!
<img width="754" alt="Screenshot 2022-11-19 at 11 10 33 AM" src="https://user-images.githubusercontent.com/102087890/202865452-fe9ba5b2-3adc-4478-ba25-2e830ffe4391.png">

### ERROR Handling:
In order for the BMI to be calculated, one must enter a number greater than 0 for the height and weight. If there is a string, empty textbox, or a number less than 1, there will be an error message. Once the error is fixed, the message will go away on calculate. 

#### Invalid Height/Weight:

1. zero/blank
<img width="754" alt="Screenshot 2022-11-19 at 11 15 07 AM" src="https://user-images.githubusercontent.com/102087890/202865678-a1a874d5-a5d3-4ba1-a527-f02986c9131f.png">

2. negatives/strings
<img width="757" alt="Screenshot 2022-11-19 at 11 15 41 AM" src="https://user-images.githubusercontent.com/102087890/202865685-59c6b98b-7d04-4f83-aa85-f3a8b2d99fe1.png">

Video Wakthrough: https://www.loom.com/share/72bc76074fcd479cb541eac017555e76
