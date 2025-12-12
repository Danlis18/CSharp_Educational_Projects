using _028_Ping_Pong;

Ping ping = new Ping();
Pong pong = new Pong();

ping.Connect(pong);
pong.Connect(ping);

pong.StartPong(1);
