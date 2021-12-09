using LinkedListApplicaton;
//LinkedList list = new LinkedList();
//list.Add(56);
////list.Add(30);
//list.Add(70);
//list.InsertAtParticularPosition(2, 30);
LinkedList list2 = new LinkedList();
//Appends the Nodes
list2.AddFirst(56);
list2.AddFirst(30);
list2.AddFirst(70);

//Remove first node 50 from the linked list
list2.RemoveFirstNode();
list2.Display();
Console.ReadKey();

