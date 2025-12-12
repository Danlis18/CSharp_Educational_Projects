using _026_EventsPractice;
using System;
using System.Collections.Generic;

Shop shop = new Shop { ShopName = "Tech Store" };

Person person1 = new Person { Name = "Alice", Age = 15 };

person1.buyEvent += shop.OnBuy;
person1.Buy();
