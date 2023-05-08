using InventoryStore;

Meat meat1 = new Meat("Steak");
Meat meat2 = new Meat("Pork");
Meat meat3 = new Meat("Chicken");
Meat meat4 = new Meat("Beef");

Produce produce1 = new Produce("Orange", "Onion");
Produce produce2 = new Produce("Apple", "Tomato");
Produce produce3 = new Produce("Banana", "Corn");
Produce produce4 = new Produce("Mango", "Carrot");

Inventory inven = new Inventory();
inven.MeatList.Add(meat1);
inven.MeatList.Add(meat2);
inven.MeatList.Add(meat3);
inven.MeatList.Add(meat4);
inven.ProduceList.Add(produce1);
inven.ProduceList.Add(produce2);
inven.ProduceList.Add(produce3);
inven.ProduceList.Add(produce4);
