# QuestionPaperMaker

This is a program made for taking a Template of Final/Exam questions and converting them to a printable/randomized format similar to [ExamProj](https://github.com/NecRaul/ExamProj).

## Dependencies

```C# Dependecies
DevExpress.Win.Design
DocX
```

## DevExpress

If there's an issue regarding DevExpress during the initial build, use Project Converter to change version to fit your version.

## Why DevExpress

I needed the Rich Edit Controller for easily managing and transforming the `.doc/.docx` files.

## How to run it

After converting/building the project, put the **`QuestionPaperTemplate.docx`** file in `bin\Debug\net6.0-windows` folder. At that point, you can carry the `net6.0-windows` folder with you to any machine running Windows.

## How to write questions

Questions are divided into "difficulties" via certain keywords (there are 4 difficulties in total).

These difficulties, along with questions should be on a new line/paragraph for it to count as a seperator/question.

### This code is really bad

I wrote this based on one of my teacher's request as they needed it for quickly transforming the questions at hand to question papers that can be given in a midterm/final exam.

This is a very strict, unreliable, non-scalable project that only serves one purpose - transforming one type of strict Word document to another.
