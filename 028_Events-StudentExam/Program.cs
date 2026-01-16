using _028_Events_StudentExam;

Student student = new Student("Danylo");
Parent parent = new Parent("Didok");

parent.Subscribe(student);

student.Session();