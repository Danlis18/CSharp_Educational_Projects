using _026_Events;
// Подія - це механізм,
// який дозволяє об'єктам повідомляти інші об'єкти про те,
// що щось сталося.

// Подія - це ситуація,
// при виникненні якої виконується дія(метод)
// або декілька дій(методів).

Counter counter = new Counter(); //Видавець
Handler1 handler1 = new Handler1(); //Підписка
Handler2 handler2 = new Handler2(); //Підписка
Handler3 handler3 = new Handler3(); //Підписка
counter.eventCount += handler1.Message; //Підписка метода на подію
counter.eventCount += handler2.Message; //Підписка метода на подію
counter.eventCount += handler3.Message; //Підписка метода на подію
counter.Count();

