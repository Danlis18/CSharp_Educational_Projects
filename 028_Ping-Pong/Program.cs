using _028_Ping_Pong;

var ping = new Ping();
var pong = new Pong();

ping.Connect(pong);
pong.Connect(ping);

pong.StartPong(1);